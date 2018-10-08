using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LCService.Forms;

namespace LCService
{
    class FormController
    {
        private static FormController instance;
        private List<Form> Forms = new List<Form>();


        public MainForm mainForm;

        private FormController()
        {
        }

        public static FormController GetInstance()
        {
            if (instance == null) instance = new FormController();
            return instance;
        }

        public void CloseApp()
        {
            foreach (Form form in Forms)
            {
                form.Close();
            }

            Application.Exit();
        }
        public void ShowForm(Form form)
        {
            form.Show();
        }
        public void HideForm(Form form)
        {
            form.Hide();
        }
        public void SwitchForm(Form form)
        {
            foreach (Form frm in Forms)
            {
                HideForm(frm);
            }
            form.Show();
        }
    }
}
