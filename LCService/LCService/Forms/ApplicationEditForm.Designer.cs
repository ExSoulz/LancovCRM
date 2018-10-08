namespace LCService.Forms
{
    partial class ApplicationEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReasonBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DiagnosticBox = new System.Windows.Forms.TextBox();
            this.RecallBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.RecallBox);
            this.groupBox1.Controls.Add(this.DiagnosticBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.StatusBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ReasonBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TimeBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры заявки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Статус заявки";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(5, 232);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(175, 21);
            this.StatusBox.TabIndex = 9;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            this.StatusBox.TextChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Причина обращения";
            // 
            // ReasonBox
            // 
            this.ReasonBox.Location = new System.Drawing.Point(186, 47);
            this.ReasonBox.Name = "ReasonBox";
            this.ReasonBox.Size = new System.Drawing.Size(325, 206);
            this.ReasonBox.TabIndex = 1;
            this.ReasonBox.Text = "";
            this.ReasonBox.TextChanged += new System.EventHandler(this.ReasonBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя клиента";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(5, 145);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(174, 20);
            this.NameBox.TabIndex = 4;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время звонка";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(6, 93);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(174, 20);
            this.TimeBox.TabIndex = 2;
            this.TimeBox.TextChanged += new System.EventHandler(this.TimeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата звонка";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(6, 47);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(174, 20);
            this.DateBox.TabIndex = 0;
            this.DateBox.TextChanged += new System.EventHandler(this.DateBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(5, 190);
            this.PhoneBox.Mask = "+7(999) 000-00-00";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneBox.TabIndex = 11;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата Диагностики";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дата перезвона";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DiagnosticBox
            // 
            this.DiagnosticBox.Enabled = false;
            this.DiagnosticBox.Location = new System.Drawing.Point(518, 92);
            this.DiagnosticBox.Name = "DiagnosticBox";
            this.DiagnosticBox.Size = new System.Drawing.Size(144, 20);
            this.DiagnosticBox.TabIndex = 16;
            this.DiagnosticBox.TextChanged += new System.EventHandler(this.DiagnosticBox_TextChanged);
            // 
            // RecallBox
            // 
            this.RecallBox.Enabled = false;
            this.RecallBox.Location = new System.Drawing.Point(520, 182);
            this.RecallBox.Name = "RecallBox";
            this.RecallBox.Size = new System.Drawing.Size(144, 20);
            this.RecallBox.TabIndex = 17;
            this.RecallBox.TextChanged += new System.EventHandler(this.RecallBox_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(520, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ApplicationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 333);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ApplicationEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заявки";
            this.Load += new System.EventHandler(this.ApplicationEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ReasonBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox PhoneBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox RecallBox;
        private System.Windows.Forms.TextBox DiagnosticBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}