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
    public partial class ApplicationEditForm : Form
    {
        public int ID;
        CallRecord Record;


        private bool IsChanged = true;
        private bool RecallSet = true;
        private bool DiagnosticSet = true;

        public ApplicationEditForm()
        {
            InitializeComponent();
        }

        private void ApplicationEditForm_Load(object sender, EventArgs e)
        {
            SetStatuses();
            SetRecord();
            ResetBools();
        }

        private void ResetBools()
        {
            IsChanged = false;
            RecallSet = false;
            DiagnosticSet = false;
        }

        private void SetRecord()
        {
            this.Text = this.Text + " №" + ID.ToString();
            Record = MySQLWork.GetInstance().GetRecord(ID);
            DateBox.Text = Record.Date;
            TimeBox.Text = Record.Time;
            NameBox.Text = Record.Name;
            PhoneBox.Text = Record.Phone;
            ReasonBox.Text = Record.Reason;
            StatusBox.Text = CallRecord.StatusToString(Record.Status);
            RecallBox.Text = Record.RecallDate;
            DiagnosticBox.Text = Record.DiagnosticDate;
        }

        private void SetStatuses()
        {
            StatusBox.Items.Add("Звонок принят");
            StatusBox.Items.Add("Нецелевой звонок");
            StatusBox.Items.Add("Записан на диагностику");
            StatusBox.Items.Add("Ждет обработки");
            StatusBox.Items.Add("Передано на диагностику");
        }

        private void ParametersChanged(object sender, EventArgs e)
        {
            IsChanged = true;
        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text != Record.Date)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void TimeBox_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text != Record.Time)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text != Record.Name)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text != Record.Phone)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void PhoneBox_TextChanged_1(object sender, EventArgs e)
        {
            MaskedTextBox obj = (MaskedTextBox)sender;
            if (obj.Text != Record.Phone)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox obj = (ComboBox)sender;
            if (obj.Text != CallRecord.StatusToString(Record.Status))
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                Record = new CallRecord();
                Record.ID = ID;
                Record.Date = DateBox.Text;
                Record.Time = TimeBox.Text;
                Record.Name = NameBox.Text;
                Record.Phone = PhoneBox.Text;
                Record.Type = "None";
                Record.Brand = "None";
                Record.Reason = ReasonBox.Text;
                Record.Status = CallRecord.StringToStatus(StatusBox.Text);
                Record.RecallDate = RecallBox.Text;
                Record.DiagnosticDate = DiagnosticBox.Text;
                if (MySQLWork.GetInstance().UpdateRecord(Record))
                {
                    MessageBox.Show("Запись обновлена");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения, сделай скрин ошибки и пришли (в следующий раз)");
                }
            }
            else
            {
                MessageBox.Show("Изменений нет");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatePickerForm dpf = new DatePickerForm();
            dpf.Date = this.DiagnosticBox;
            dpf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatePickerForm dpf = new DatePickerForm();
            dpf.Date = this.RecallBox;
            dpf.Show();
        }

        private void DiagnosticBox_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text != Record.DiagnosticDate)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void RecallBox_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text != Record.RecallDate)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void ReasonBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox obj = (RichTextBox)sender;
            if (obj.Text != Record.Reason)
            {
                obj.ForeColor = Color.Red;
                IsChanged = true;
            }
            else
            {
                obj.ForeColor = Color.Black;
                IsChanged = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
