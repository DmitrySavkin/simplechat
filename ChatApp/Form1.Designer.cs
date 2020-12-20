namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portOwnTextBox = new System.Windows.Forms.TextBox();
            this.ipOwnTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.portBoxRemote = new System.Windows.Forms.TextBox();
            this.ipBoxRemote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.outgoingMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portOwnTextBox);
            this.groupBox1.Controls.Add(this.ipOwnTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "me";
            // 
            // portOwnTextBox
            // 
            this.portOwnTextBox.Location = new System.Drawing.Point(96, 76);
            this.portOwnTextBox.Name = "portOwnTextBox";
            this.portOwnTextBox.Size = new System.Drawing.Size(125, 27);
            this.portOwnTextBox.TabIndex = 3;
            // 
            // ipOwnTextBox
            // 
            this.ipOwnTextBox.Location = new System.Drawing.Point(96, 27);
            this.ipOwnTextBox.Name = "ipOwnTextBox";
            this.ipOwnTextBox.Size = new System.Drawing.Size(125, 27);
            this.ipOwnTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.portBoxRemote);
            this.groupBox2.Controls.Add(this.ipBoxRemote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(341, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "remote";
            // 
            // portBoxRemote
            // 
            this.portBoxRemote.Location = new System.Drawing.Point(75, 68);
            this.portBoxRemote.Name = "portBoxRemote";
            this.portBoxRemote.Size = new System.Drawing.Size(133, 27);
            this.portBoxRemote.TabIndex = 3;
            // 
            // ipBoxRemote
            // 
            this.ipBoxRemote.Location = new System.Drawing.Point(75, 26);
            this.ipBoxRemote.Name = "ipBoxRemote";
            this.ipBoxRemote.Size = new System.Drawing.Size(133, 27);
            this.ipBoxRemote.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(674, 84);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(94, 29);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 20;
            this.listMessages.Location = new System.Drawing.Point(41, 193);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(727, 204);
            this.listMessages.TabIndex = 2;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(673, 409);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(94, 29);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // outgoingMessage
            // 
            this.outgoingMessage.Location = new System.Drawing.Point(41, 411);
            this.outgoingMessage.Name = "outgoingMessage";
            this.outgoingMessage.Size = new System.Drawing.Size(602, 27);
            this.outgoingMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outgoingMessage);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox portOwnTextBox;
        private System.Windows.Forms.TextBox ipOwnTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox portBoxRemote;
        private System.Windows.Forms.TextBox ipBoxRemote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox outgoingMessage;
    }
}

