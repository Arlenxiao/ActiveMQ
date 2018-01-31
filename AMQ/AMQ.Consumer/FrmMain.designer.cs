namespace AMQ.Consumer
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gb_Setting = new System.Windows.Forms.GroupBox();
            this.txt_ClientID = new System.Windows.Forms.TextBox();
            this.lbl_ClientID = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_Selector = new System.Windows.Forms.TextBox();
            this.lbl_Selector = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.rb_Queue = new System.Windows.Forms.RadioButton();
            this.rb_Topic = new System.Windows.Forms.RadioButton();
            this.txt_TopicName = new System.Windows.Forms.TextBox();
            this.lbl_TopicName = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_URI = new System.Windows.Forms.TextBox();
            this.lbl_URI = new System.Windows.Forms.Label();
            this.rtb_msg = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Setting.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Setting
            // 
            this.gb_Setting.Controls.Add(this.txt_ClientID);
            this.gb_Setting.Controls.Add(this.lbl_ClientID);
            this.gb_Setting.Controls.Add(this.btn_Stop);
            this.gb_Setting.Controls.Add(this.txt_Selector);
            this.gb_Setting.Controls.Add(this.lbl_Selector);
            this.gb_Setting.Controls.Add(this.btn_Start);
            this.gb_Setting.Controls.Add(this.rb_Queue);
            this.gb_Setting.Controls.Add(this.rb_Topic);
            this.gb_Setting.Controls.Add(this.txt_TopicName);
            this.gb_Setting.Controls.Add(this.lbl_TopicName);
            this.gb_Setting.Controls.Add(this.txt_Password);
            this.gb_Setting.Controls.Add(this.txt_UserName);
            this.gb_Setting.Controls.Add(this.lbl_Password);
            this.gb_Setting.Controls.Add(this.lbl_UserName);
            this.gb_Setting.Controls.Add(this.txt_URI);
            this.gb_Setting.Controls.Add(this.lbl_URI);
            this.gb_Setting.Location = new System.Drawing.Point(2, 8);
            this.gb_Setting.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gb_Setting.Name = "gb_Setting";
            this.gb_Setting.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gb_Setting.Size = new System.Drawing.Size(1405, 492);
            this.gb_Setting.TabIndex = 1;
            this.gb_Setting.TabStop = false;
            this.gb_Setting.Text = "MQ Setting";
            // 
            // txt_ClientID
            // 
            this.txt_ClientID.Location = new System.Drawing.Point(232, 295);
            this.txt_ClientID.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_ClientID.Name = "txt_ClientID";
            this.txt_ClientID.Size = new System.Drawing.Size(369, 42);
            this.txt_ClientID.TabIndex = 15;
            // 
            // lbl_ClientID
            // 
            this.lbl_ClientID.AutoSize = true;
            this.lbl_ClientID.Location = new System.Drawing.Point(75, 305);
            this.lbl_ClientID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_ClientID.Name = "lbl_ClientID";
            this.lbl_ClientID.Size = new System.Drawing.Size(148, 30);
            this.lbl_ClientID.TabIndex = 14;
            this.lbl_ClientID.Text = "Client ID";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(1120, 395);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(188, 58);
            this.btn_Stop.TabIndex = 13;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_Selector
            // 
            this.txt_Selector.Location = new System.Drawing.Point(932, 210);
            this.txt_Selector.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_Selector.Name = "txt_Selector";
            this.txt_Selector.Size = new System.Drawing.Size(369, 42);
            this.txt_Selector.TabIndex = 12;
            // 
            // lbl_Selector
            // 
            this.lbl_Selector.AutoSize = true;
            this.lbl_Selector.Location = new System.Drawing.Point(775, 220);
            this.lbl_Selector.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Selector.Name = "lbl_Selector";
            this.lbl_Selector.Size = new System.Drawing.Size(133, 30);
            this.lbl_Selector.TabIndex = 11;
            this.lbl_Selector.Text = "Selector";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(925, 395);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(188, 58);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // rb_Queue
            // 
            this.rb_Queue.AutoSize = true;
            this.rb_Queue.Location = new System.Drawing.Point(1152, 300);
            this.rb_Queue.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rb_Queue.Name = "rb_Queue";
            this.rb_Queue.Size = new System.Drawing.Size(125, 34);
            this.rb_Queue.TabIndex = 9;
            this.rb_Queue.Text = "Queue";
            this.rb_Queue.UseVisualStyleBackColor = true;
            // 
            // rb_Topic
            // 
            this.rb_Topic.AutoSize = true;
            this.rb_Topic.Checked = true;
            this.rb_Topic.Location = new System.Drawing.Point(922, 300);
            this.rb_Topic.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rb_Topic.Name = "rb_Topic";
            this.rb_Topic.Size = new System.Drawing.Size(125, 34);
            this.rb_Topic.TabIndex = 8;
            this.rb_Topic.TabStop = true;
            this.rb_Topic.Text = "Topic";
            this.rb_Topic.UseVisualStyleBackColor = true;
            // 
            // txt_TopicName
            // 
            this.txt_TopicName.Location = new System.Drawing.Point(232, 208);
            this.txt_TopicName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_TopicName.Name = "txt_TopicName";
            this.txt_TopicName.Size = new System.Drawing.Size(369, 42);
            this.txt_TopicName.TabIndex = 7;
            this.txt_TopicName.Text = "DeviceToServer";
            // 
            // lbl_TopicName
            // 
            this.lbl_TopicName.AutoSize = true;
            this.lbl_TopicName.Location = new System.Drawing.Point(70, 218);
            this.lbl_TopicName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_TopicName.Name = "lbl_TopicName";
            this.lbl_TopicName.Size = new System.Drawing.Size(148, 30);
            this.lbl_TopicName.TabIndex = 6;
            this.lbl_TopicName.Text = "TopicName";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(932, 132);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(369, 42);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.Text = "manager";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(232, 132);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(369, 42);
            this.txt_UserName.TabIndex = 4;
            this.txt_UserName.Text = "admin";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(775, 142);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(133, 30);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(85, 142);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(133, 30);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "UserName";
            // 
            // txt_URI
            // 
            this.txt_URI.Location = new System.Drawing.Point(232, 52);
            this.txt_URI.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_URI.Name = "txt_URI";
            this.txt_URI.Size = new System.Drawing.Size(1069, 42);
            this.txt_URI.TabIndex = 1;
            this.txt_URI.Text = "activemq:tcp://127.0.0.1:61616";
            // 
            // lbl_URI
            // 
            this.lbl_URI.AutoSize = true;
            this.lbl_URI.Location = new System.Drawing.Point(160, 60);
            this.lbl_URI.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_URI.Name = "lbl_URI";
            this.lbl_URI.Size = new System.Drawing.Size(58, 30);
            this.lbl_URI.TabIndex = 0;
            this.lbl_URI.Text = "URI";
            // 
            // rtb_msg
            // 
            this.rtb_msg.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtb_msg.ContextMenuStrip = this.contextMenuStrip1;
            this.rtb_msg.ForeColor = System.Drawing.Color.Green;
            this.rtb_msg.Location = new System.Drawing.Point(2, 515);
            this.rtb_msg.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rtb_msg.Name = "rtb_msg";
            this.rtb_msg.Size = new System.Drawing.Size(1399, 556);
            this.rtb_msg.TabIndex = 3;
            this.rtb_msg.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(154, 44);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 1085);
            this.Controls.Add(this.rtb_msg);
            this.Controls.Add(this.gb_Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumer";
            this.gb_Setting.ResumeLayout(false);
            this.gb_Setting.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Setting;
        private System.Windows.Forms.TextBox txt_Selector;
        private System.Windows.Forms.Label lbl_Selector;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.RadioButton rb_Queue;
        private System.Windows.Forms.RadioButton rb_Topic;
        private System.Windows.Forms.TextBox txt_TopicName;
        private System.Windows.Forms.Label lbl_TopicName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_URI;
        private System.Windows.Forms.Label lbl_URI;
        private System.Windows.Forms.RichTextBox rtb_msg;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txt_ClientID;
        private System.Windows.Forms.Label lbl_ClientID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
    }
}

