using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCService.Forms
{
    public partial class SendToDiagnostic : Form
    {
        public MySQLWork sql;
        public CallRecord rec;

        public SendToDiagnostic()
        {
            InitializeComponent();
        }

        private void SendToDiagnostic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rec.DiagnosticDate = dateTimePicker1.Value.ToShortDateString();
            rec.SetInDatabase(true);
            this.Close();
        }
    }
}
