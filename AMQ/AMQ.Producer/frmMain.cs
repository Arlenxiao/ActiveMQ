using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AMQ.Producer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Init();
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void btn_TimerSend_Click(object sender, EventArgs e)
        {
            Timer_Send.Interval = Convert.ToInt32(txt_Interval.Text);
            Timer_Send.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Timer_Send.Enabled = false;
        }

        private void Timer_Send_Tick(object sender, EventArgs e)
        {
            SendData();
        }
        private void 清除ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb_msg.Clear();
        }

        #region
        /// <summary>
        /// 随机字符串
        /// </summary>
        /// <returns></returns>
        private string RandString(Int32 max = 32)
        {
            string str = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+";//75个字符
            Random r = new Random();
            string result = string.Empty;
            //生成一个8位长的随机字符，具体长度可以自己更改
            int len = r.Next(0, max);
            for (int i = 0; i < len; i++)
            {
                int m = r.Next(0, 75);//这里下界是0，随机数可以取到，上界应该是75，因为随机数取不到上界，也就是最大74，符合我们的题意
                string s = str.Substring(m, 1);
                result += s;
            }
            return result;
        }
        #endregion

        #region Init
        ActiveMQProduce mq = new ActiveMQProduce();

        private void Init()
        {
            mq.URI = txt_URI.Text.Trim();
            mq.UserName = txt_UserName.Text.Trim();
            mq.Password = txt_Password.Text.Trim();
            mq.IsTopic = rb_Topic.Checked;
            mq.TopicName = txt_TopicName.Text.Trim();
            mq.Start();
            mq.CreateProduce();
        }

        private void SendData()
        {
            if (chk_random.Checked)
            {
                mq.Message = RandString();
            }
            else
            {
                mq.Message = txt_SendData.Text;
            }
            mq.Send();

            rtb_msg.Invoke((MethodInvoker)(() =>
            {
                rtb_msg.AppendText(string.Format("{0}:{1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), mq.Message));
                rtb_msg.ScrollToCaret();

                if (rtb_msg.Text.Length > 1000) rtb_msg.Clear();
            }));
        }



        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var name = txt_PropertyName.Text.Trim();
            var value = txt_PropertyValue.Text.Trim();
            mq.MessageProperties.TryAdd(name, value);

            BindData();
        }

        private void BindData()
        {
            BindingSource bs = new BindingSource(components);
            bs.DataSource = mq.MessageProperties.Values;

            dgv_Property.DataSource = (from v in mq.MessageProperties
                                       select new
                                       {
                                           PropertyName = v.Key,
                                           PropertyValue = v.Value
                                       }).ToArray();
        }
    }
}
