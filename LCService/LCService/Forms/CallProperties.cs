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
    public partial class CallsProperties : Form
    {
        FormController fc;
        public CallsProperties()
        {
            InitializeComponent();
            fc = FormController.GetInstance();
        }

        private void CallProperties_Load(object sender, EventArgs e)
        {
            Time.Text = "Время звонка: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            foreach (string brand in SettingsReader.Brands)
            {
                Brand.Items.Add(brand);
            }

            foreach (string type in SettingsReader.TechTypes)
            {
                TechType.Items.Add(type);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fc.SwitchForm(fc.mainForm);
            this.Close();
        }

        private void UntargetedCall_Click(object sender, EventArgs e)
        {
            CallRecord rec = new CallRecord(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), UserName.Text, Phone.Text, TechType.Text, Brand.Text, "NONE", Reason.Text, ApplicationStatus.WrongCall);
            rec.SetInDatabase();
            //fc.SwitchForm(fc.mainForm);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Записать на диагностику?", "Диагностика", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                SendToDiagnostic sd = new SendToDiagnostic();
                sd.rec = new CallRecord(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), UserName.Text, Phone.Text, TechType.Text, Brand.Text, "NONE", Reason.Text, ApplicationStatus.RecordedAtDiagnostic);
                sd.Show();
                this.Close();
            }
            if(res== DialogResult.No)
            {
                DialogResult res2 = MessageBox.Show("Записать на прозвон?", "Прозвон", MessageBoxButtons.YesNoCancel);
                if (res2 == DialogResult.Yes)
                {
                    CallRegistrationForm CRF = new CallRegistrationForm();
                    CRF.Show();
                    CRF.rec = new CallRecord(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), UserName.Text, Phone.Text, TechType.Text, Brand.Text, "NONE", Reason.Text, ApplicationStatus.OnReCall);
                    this.Close();
                }
                if (res2 == DialogResult.No)
                {
                    CallRecord rec = new CallRecord(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), UserName.Text, Phone.Text, TechType.Text, Brand.Text, "NONE", Reason.Text, ApplicationStatus.Accepted);
                    rec.SetInDatabase();
                    this.Close();
                }
            }
            
           
        }

        private void Phone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
