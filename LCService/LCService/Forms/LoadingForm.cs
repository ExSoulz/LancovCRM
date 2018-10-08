using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCService
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            this.Size = this.BackgroundImage.Size;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("Старт");
            System.Threading.Thread.Sleep(100);
            MessageBox.Show("Инстанс");
            FormController.GetInstance();
            MessageBox.Show("Стоп");
            backgroundWorker1.CancelAsync();
        }
    }
}
