using Apache.NMS;
using System;
using System.Windows.Forms;

namespace AMQ.Consumer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        ActiveMQConsumer mq = new ActiveMQConsumer();

        private void btn_Start_Click(object sender, EventArgs e)
        {
            mq.URI = txt_URI.Text.Trim();
            mq.UserName = txt_UserName.Text.Trim();
            mq.Password = txt_Password.Text.Trim();
            mq.IsTopic = rb_Topic.Checked;
            mq.TopicName = txt_TopicName.Text.Trim();
            mq.ClientID = txt_ClientID.Text.Trim();
            mq.Selector = txt_Selector.Text.Trim();
            mq.CreateConsumer();
            mq.SendMessageEvent += ActiveMQHelper_SendMessageEvent;

            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            mq.SendMessageEvent -= ActiveMQHelper_SendMessageEvent;
            mq.Close();

            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
        }

        private void ActiveMQHelper_SendMessageEvent(IMessage msg)
        {
            try
            {
                ITextMessage message = (ITextMessage)msg;
                rtb_msg.Invoke((MethodInvoker)(() =>
                {
                    rtb_msg.AppendText(string.Format("{0}:{1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message.Text));
                    rtb_msg.ScrollToCaret();

                    if (rtb_msg.Text.Length > 20000) rtb_msg.Clear();
                }));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_msg.Clear();
        }
    }
}
