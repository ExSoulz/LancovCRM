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
    public partial class CallRegistrationForm : Form
    {

         public MySQLWork sql;
        public CallRecord rec;

        public CallRegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rec.RecallDate = dateTimePicker1.Value.ToShortDateString();
            rec.SetInDatabase(false);
            this.Close();
        }

        private void CallRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
