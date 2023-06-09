﻿namespace ChatClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">Значение true, если управляемые активы должны быть выведены из эксплуатации; False в противном случае.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
				/// Метод, необходимый для поддержки дизайнера - не изменять
				/// его содержимое в редакторе кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.radioButtonNa = new System.Windows.Forms.RadioButton();
			this.radioButtonAn = new System.Windows.Forms.RadioButton();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.labelPort = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
			this.textBoxSend = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.buttonConnect);
			this.groupBox1.Controls.Add(this.textBoxPort);
			this.groupBox1.Controls.Add(this.textBoxIP);
			this.groupBox1.Controls.Add(this.labelPort);
			this.groupBox1.Controls.Add(this.labelIP);
			this.groupBox1.Location = new System.Drawing.Point(283, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(180, 337);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Подключение к серверу";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupBox2.Controls.Add(this.textBoxName);
			this.groupBox2.Controls.Add(this.radioButtonNa);
			this.groupBox2.Controls.Add(this.radioButtonAn);
			this.groupBox2.Location = new System.Drawing.Point(10, 84);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(164, 107);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Имя";
			// 
			// textBoxName
			// 
			this.textBoxName.Enabled = false;
			this.textBoxName.Location = new System.Drawing.Point(72, 54);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(86, 20);
			this.textBoxName.TabIndex = 2;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			// 
			// radioButtonNa
			// 
			this.radioButtonNa.AutoSize = true;
			this.radioButtonNa.Location = new System.Drawing.Point(7, 54);
			this.radioButtonNa.Name = "radioButtonNa";
			this.radioButtonNa.Size = new System.Drawing.Size(53, 17);
			this.radioButtonNa.TabIndex = 1;
			this.radioButtonNa.Text = "Имя :";
			this.radioButtonNa.UseVisualStyleBackColor = true;
			this.radioButtonNa.CheckedChanged += new System.EventHandler(this.radioButtonNa_CheckedChanged);
			// 
			// radioButtonAn
			// 
			this.radioButtonAn.AutoSize = true;
			this.radioButtonAn.Checked = true;
			this.radioButtonAn.Location = new System.Drawing.Point(7, 30);
			this.radioButtonAn.Name = "radioButtonAn";
			this.radioButtonAn.Size = new System.Drawing.Size(80, 17);
			this.radioButtonAn.TabIndex = 0;
			this.radioButtonAn.TabStop = true;
			this.radioButtonAn.Text = "Anonymous";
			this.radioButtonAn.UseVisualStyleBackColor = true;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(10, 206);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(164, 23);
			this.buttonConnect.TabIndex = 4;
			this.buttonConnect.Text = "Подключиться";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(68, 58);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(100, 20);
			this.textBoxPort.TabIndex = 3;
			// 
			// textBoxIP
			// 
			this.textBoxIP.Location = new System.Drawing.Point(68, 30);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(100, 20);
			this.textBoxIP.TabIndex = 2;
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(7, 58);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(38, 13);
			this.labelPort.TabIndex = 1;
			this.labelPort.Text = "Порт :";
			// 
			// labelIP
			// 
			this.labelIP.AutoSize = true;
			this.labelIP.Location = new System.Drawing.Point(7, 30);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(56, 13);
			this.labelIP.TabIndex = 0;
			this.labelIP.Text = "IP-адрес :";
			// 
			// richTextBoxChat
			// 
			this.richTextBoxChat.BackColor = System.Drawing.Color.LightSteelBlue;
			this.richTextBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBoxChat.Location = new System.Drawing.Point(13, 13);
			this.richTextBoxChat.Name = "richTextBoxChat";
			this.richTextBoxChat.ReadOnly = true;
			this.richTextBoxChat.Size = new System.Drawing.Size(264, 337);
			this.richTextBoxChat.TabIndex = 1;
			this.richTextBoxChat.Text = "";
			// 
			// textBoxSend
			// 
			this.textBoxSend.Enabled = false;
			this.textBoxSend.Location = new System.Drawing.Point(13, 357);
			this.textBoxSend.Name = "textBoxSend";
			this.textBoxSend.Size = new System.Drawing.Size(264, 20);
			this.textBoxSend.TabIndex = 2;
			this.textBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyDown);
			// 
			// buttonSend
			// 
			this.buttonSend.Enabled = false;
			this.buttonSend.Location = new System.Drawing.Point(293, 357);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(164, 23);
			this.buttonSend.TabIndex = 3;
			this.buttonSend.Text = "Отправить";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(475, 407);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.textBoxSend);
			this.Controls.Add(this.richTextBoxChat);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonNa;
        private System.Windows.Forms.RadioButton radioButtonAn;
    }
}

