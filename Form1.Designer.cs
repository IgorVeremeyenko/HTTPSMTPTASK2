namespace HTTPSMTPTASK2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTheme);
            this.groupBox1.Controls.Add(this.textBoxRecipient);
            this.groupBox1.Controls.Add(this.textBoxSender);
            this.groupBox1.Controls.Add(this.Send);
            this.groupBox1.Controls.Add(this.textBoxMessage);
            this.groupBox1.Location = new System.Drawing.Point(55, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отправить сообщение";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(17, 162);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(671, 83);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.Text = "Введите текст";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(585, 268);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(103, 23);
            this.Send.TabIndex = 1;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(17, 60);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(402, 20);
            this.textBoxSender.TabIndex = 2;
            this.textBoxSender.Text = "Почтовый адрес отправителя";
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Location = new System.Drawing.Point(17, 86);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(402, 20);
            this.textBoxRecipient.TabIndex = 3;
            this.textBoxRecipient.Text = "Почтовый адрес получателя";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(17, 126);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(402, 20);
            this.textBoxTheme.TabIndex = 4;
            this.textBoxTheme.Text = "Тема письма";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.TextBox textBoxTheme;
    }
}

