namespace AMQ.Producer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gb_Setting = new System.Windows.Forms.GroupBox();
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
            this.gb_Send = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_random = new System.Windows.Forms.CheckBox();
            this.txt_SendData = new System.Windows.Forms.TextBox();
            this.lbl_ms = new System.Windows.Forms.Label();
            this.lbl_SendData = new System.Windows.Forms.Label();
            this.lbl_Interval = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Interval = new System.Windows.Forms.TextBox();
            this.btn_TimerSend = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Property = new System.Windows.Forms.DataGridView();
            this.txt_PropertyValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PropertyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_msg = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_Send = new System.Windows.Forms.Timer();
            this.gb_Setting.SuspendLayout();
            this.gb_Send.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Property)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Setting
            // 
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
            this.gb_Setting.Location = new System.Drawing.Point(5, 32);
            this.gb_Setting.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gb_Setting.Name = "gb_Setting";
            this.gb_Setting.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gb_Setting.Size = new System.Drawing.Size(1405, 288);
            this.gb_Setting.TabIndex = 0;
            this.gb_Setting.TabStop = false;
            this.gb_Setting.Text = "MQ Setting";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(1120, 205);
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
            this.rb_Queue.Location = new System.Drawing.Point(932, 212);
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
            this.rb_Topic.Location = new System.Drawing.Point(780, 212);
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
            // gb_Send
            // 
            this.gb_Send.Controls.Add(this.tabControl1);
            this.gb_Send.Location = new System.Drawing.Point(5, 335);
            this.gb_Send.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gb_Send.Name = "gb_Send";
            this.gb_Send.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gb_Send.Size = new System.Drawing.Size(1405, 462);
            this.gb_Send.TabIndex = 1;
            this.gb_Send.TabStop = false;
            this.gb_Send.Text = "MQ Send";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1389, 411);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_random);
            this.tabPage1.Controls.Add(this.txt_SendData);
            this.tabPage1.Controls.Add(this.lbl_ms);
            this.tabPage1.Controls.Add(this.lbl_SendData);
            this.tabPage1.Controls.Add(this.lbl_Interval);
            this.tabPage1.Controls.Add(this.btn_Send);
            this.tabPage1.Controls.Add(this.txt_Interval);
            this.tabPage1.Controls.Add(this.btn_TimerSend);
            this.tabPage1.Controls.Add(this.btn_Stop);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabPage1.Size = new System.Drawing.Size(1369, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_random
            // 
            this.chk_random.AutoSize = true;
            this.chk_random.Location = new System.Drawing.Point(25, 92);
            this.chk_random.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chk_random.Name = "chk_random";
            this.chk_random.Size = new System.Drawing.Size(141, 34);
            this.chk_random.TabIndex = 15;
            this.chk_random.Text = "Random";
            this.chk_random.UseVisualStyleBackColor = true;
            // 
            // txt_SendData
            // 
            this.txt_SendData.Location = new System.Drawing.Point(182, 15);
            this.txt_SendData.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_SendData.Multiline = true;
            this.txt_SendData.Name = "txt_SendData";
            this.txt_SendData.Size = new System.Drawing.Size(1166, 236);
            this.txt_SendData.TabIndex = 8;
            this.txt_SendData.Text = "{action:\"Device/Write\",args:{start:1,data:\"020202\"} }";
            // 
            // lbl_ms
            // 
            this.lbl_ms.AutoSize = true;
            this.lbl_ms.Location = new System.Drawing.Point(902, 285);
            this.lbl_ms.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_ms.Name = "lbl_ms";
            this.lbl_ms.Size = new System.Drawing.Size(43, 30);
            this.lbl_ms.TabIndex = 14;
            this.lbl_ms.Text = "ms";
            // 
            // lbl_SendData
            // 
            this.lbl_SendData.AutoSize = true;
            this.lbl_SendData.Location = new System.Drawing.Point(20, 22);
            this.lbl_SendData.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_SendData.Name = "lbl_SendData";
            this.lbl_SendData.Size = new System.Drawing.Size(148, 30);
            this.lbl_SendData.TabIndex = 7;
            this.lbl_SendData.Text = "Send Data";
            // 
            // lbl_Interval
            // 
            this.lbl_Interval.AutoSize = true;
            this.lbl_Interval.Location = new System.Drawing.Point(558, 285);
            this.lbl_Interval.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Interval.Name = "lbl_Interval";
            this.lbl_Interval.Size = new System.Drawing.Size(133, 30);
            this.lbl_Interval.TabIndex = 13;
            this.lbl_Interval.Text = "Interval";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(182, 272);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(188, 58);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Interval
            // 
            this.txt_Interval.Location = new System.Drawing.Point(705, 278);
            this.txt_Interval.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_Interval.Name = "txt_Interval";
            this.txt_Interval.Size = new System.Drawing.Size(176, 42);
            this.txt_Interval.TabIndex = 12;
            this.txt_Interval.Text = "1000";
            // 
            // btn_TimerSend
            // 
            this.btn_TimerSend.Location = new System.Drawing.Point(960, 272);
            this.btn_TimerSend.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_TimerSend.Name = "btn_TimerSend";
            this.btn_TimerSend.Size = new System.Drawing.Size(188, 58);
            this.btn_TimerSend.TabIndex = 10;
            this.btn_TimerSend.Text = "TimerSend";
            this.btn_TimerSend.UseVisualStyleBackColor = true;
            this.btn_TimerSend.Click += new System.EventHandler(this.btn_TimerSend_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(1162, 272);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(188, 58);
            this.btn_Stop.TabIndex = 11;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Delete);
            this.tabPage2.Controls.Add(this.btn_Add);
            this.tabPage2.Controls.Add(this.dgv_Property);
            this.tabPage2.Controls.Add(this.txt_PropertyValue);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_PropertyName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabPage2.Size = new System.Drawing.Size(1370, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Property";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(30, 185);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(188, 58);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(30, 112);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(188, 58);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Property
            // 
            this.dgv_Property.AllowUserToAddRows = false;
            this.dgv_Property.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Property.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Property.Location = new System.Drawing.Point(278, 88);
            this.dgv_Property.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dgv_Property.Name = "dgv_Property";
            this.dgv_Property.ReadOnly = true;
            this.dgv_Property.RowTemplate.Height = 23;
            this.dgv_Property.Size = new System.Drawing.Size(1062, 245);
            this.dgv_Property.TabIndex = 9;
            // 
            // txt_PropertyValue
            // 
            this.txt_PropertyValue.Location = new System.Drawing.Point(965, 20);
            this.txt_PropertyValue.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_PropertyValue.Name = "txt_PropertyValue";
            this.txt_PropertyValue.Size = new System.Drawing.Size(369, 42);
            this.txt_PropertyValue.TabIndex = 8;
            this.txt_PropertyValue.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Property Value";
            // 
            // txt_PropertyName
            // 
            this.txt_PropertyName.Location = new System.Drawing.Point(278, 20);
            this.txt_PropertyName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_PropertyName.Name = "txt_PropertyName";
            this.txt_PropertyName.Size = new System.Drawing.Size(369, 42);
            this.txt_PropertyName.TabIndex = 6;
            this.txt_PropertyName.Text = "SID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Property Name";
            // 
            // rtb_msg
            // 
            this.rtb_msg.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtb_msg.ContextMenuStrip = this.contextMenuStrip1;
            this.rtb_msg.ForeColor = System.Drawing.Color.Green;
            this.rtb_msg.Location = new System.Drawing.Point(5, 812);
            this.rtb_msg.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rtb_msg.Name = "rtb_msg";
            this.rtb_msg.Size = new System.Drawing.Size(1399, 426);
            this.rtb_msg.TabIndex = 2;
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
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click_1);
            // 
            // Timer_Send
            // 
            this.Timer_Send.Interval = 1000;
            this.Timer_Send.Tick += new System.EventHandler(this.Timer_Send_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 1245);
            this.Controls.Add(this.rtb_msg);
            this.Controls.Add(this.gb_Send);
            this.Controls.Add(this.gb_Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producer";
            this.gb_Setting.ResumeLayout(false);
            this.gb_Setting.PerformLayout();
            this.gb_Send.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Property)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Setting;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_URI;
        private System.Windows.Forms.Label lbl_URI;
        private System.Windows.Forms.RadioButton rb_Queue;
        private System.Windows.Forms.RadioButton rb_Topic;
        private System.Windows.Forms.TextBox txt_TopicName;
        private System.Windows.Forms.Label lbl_TopicName;
        private System.Windows.Forms.GroupBox gb_Send;
        private System.Windows.Forms.TextBox txt_SendData;
        private System.Windows.Forms.Label lbl_SendData;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_TimerSend;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label lbl_ms;
        private System.Windows.Forms.Label lbl_Interval;
        private System.Windows.Forms.TextBox txt_Interval;
        private System.Windows.Forms.RichTextBox rtb_msg;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.CheckBox chk_random;
        private System.Windows.Forms.Timer Timer_Send;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Property;
        private System.Windows.Forms.TextBox txt_PropertyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PropertyName;
        private System.Windows.Forms.Label label1;
    }
}

