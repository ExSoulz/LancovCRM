namespace LCService.Forms
{
    partial class ApllicationViewer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QQQ,
            this.AppNumber,
            this.AppDate,
            this.AppTime,
            this.AppName,
            this.AppPhone,
            this.TechType,
            this.AppBrand,
            this.Reason,
            this.AppStatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // QQQ
            // 
            this.QQQ.HeaderText = "qwe";
            this.QQQ.Name = "QQQ";
            this.QQQ.ReadOnly = true;
            this.QQQ.Visible = false;
            // 
            // AppNumber
            // 
            this.AppNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppNumber.HeaderText = "Номер заявки";
            this.AppNumber.Name = "AppNumber";
            this.AppNumber.ReadOnly = true;
            // 
            // AppDate
            // 
            this.AppDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppDate.HeaderText = "Дата";
            this.AppDate.Name = "AppDate";
            this.AppDate.ReadOnly = true;
            // 
            // AppTime
            // 
            this.AppTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppTime.HeaderText = "Время";
            this.AppTime.Name = "AppTime";
            this.AppTime.ReadOnly = true;
            // 
            // AppName
            // 
            this.AppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppName.HeaderText = "Имя клиента";
            this.AppName.Name = "AppName";
            this.AppName.ReadOnly = true;
            // 
            // AppPhone
            // 
            this.AppPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppPhone.HeaderText = "Номер телефона";
            this.AppPhone.Name = "AppPhone";
            this.AppPhone.ReadOnly = true;
            // 
            // TechType
            // 
            this.TechType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TechType.HeaderText = "Вид техники";
            this.TechType.Name = "TechType";
            this.TechType.ReadOnly = true;
            // 
            // AppBrand
            // 
            this.AppBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppBrand.HeaderText = "Бренд";
            this.AppBrand.Name = "AppBrand";
            this.AppBrand.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reason.HeaderText = "Причина";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // AppStatus
            // 
            this.AppStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppStatus.HeaderText = "Статус заявки";
            this.AppStatus.Name = "AppStatus";
            this.AppStatus.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1441, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // ApllicationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ApllicationViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApllicationViewer_FormClosing);
            this.Load += new System.EventHandler(this.ApllicationViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppStatus;
    }
}