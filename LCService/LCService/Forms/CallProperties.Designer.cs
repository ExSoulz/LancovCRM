namespace LCService.Forms
{
    partial class CallsProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UntargetedCall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.TechType = new System.Windows.Forms.ComboBox();
            this.Brand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Reason = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UntargetedCall
            // 
            this.UntargetedCall.Location = new System.Drawing.Point(12, 12);
            this.UntargetedCall.Name = "UntargetedCall";
            this.UntargetedCall.Size = new System.Drawing.Size(114, 53);
            this.UntargetedCall.TabIndex = 8;
            this.UntargetedCall.Text = "Нецелевой звонок";
            this.UntargetedCall.UseVisualStyleBackColor = true;
            this.UntargetedCall.Click += new System.EventHandler(this.UntargetedCall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(132, 39);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(154, 26);
            this.Time.TabIndex = 2;
            this.Time.Text = "Время звонка";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(12, 98);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(126, 20);
            this.UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Телефон";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(163, 98);
            this.Phone.Mask = "(999) 000-00-00";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(145, 20);
            this.Phone.TabIndex = 2;
            this.Phone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Phone_MaskInputRejected);
            // 
            // TechType
            // 
            this.TechType.FormattingEnabled = true;
            this.TechType.Location = new System.Drawing.Point(317, 98);
            this.TechType.Name = "TechType";
            this.TechType.Size = new System.Drawing.Size(145, 21);
            this.TechType.TabIndex = 3;
            this.TechType.Visible = false;
            // 
            // Brand
            // 
            this.Brand.FormattingEnabled = true;
            this.Brand.Location = new System.Drawing.Point(475, 97);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(145, 21);
            this.Brand.TabIndex = 4;
            this.Brand.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Бренд";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Тип техники";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Причина обращения";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reason
            // 
            this.Reason.Location = new System.Drawing.Point(15, 152);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(605, 105);
            this.Reason.TabIndex = 5;
            this.Reason.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "+7";
            // 
            // CallsProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 293);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.TechType);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UntargetedCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CallsProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Входящий звонок";
            this.Load += new System.EventHandler(this.CallProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UntargetedCall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.ComboBox TechType;
        private System.Windows.Forms.ComboBox Brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Reason;
        private System.Windows.Forms.Label label6;
    }
}