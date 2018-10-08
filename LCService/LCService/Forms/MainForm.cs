using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LCService.Forms;

namespace LCService.Forms
{
    public partial class MainForm : Form
    {

        FormController fc;
        private MySQLWork msql;
        int totalcalls = 0;

        public MainForm()
        {
            InitializeComponent();
            fc = FormController.GetInstance();
            fc.mainForm = this;
            SettingsReader.Load();
            msql = MySQLWork.GetInstance();
            msql.RecordReceived += SetRecords;
            msql.RecordReceived += SetUntergeted;
            msql.RecordReceived += SetDiagnostics;
            msql.RecordReceived += SetAllRecieved;
            msql.RecordReceived += SetRecallsToday;
            msql.RowsAffected += ShowRowsAffected;
            msql.RecordReceived += UpdateLabels;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.Text = "Сервисный центр 2";
            label4.Text = "Переведено с диагностики  на перезвон сегодня: " + msql.TransferMissedDiagnostic();
            SetRecords();
            SetUntergeted();
            SetDiagnostics();
            SetAllRecieved();
            SetRecallsToday();
            UpdateLabels();
            MessageBox.Show(GetSC());
            
        }

        private string GetSC()
        {
            string code = SettingsReader.SCCode;
            if (code == "143861FAE8930E0841AFD6C19DDCA2389C91530C8839044AE1A3694AC49FBF1F") return "SC1";
            if (code == "E5547E6C4B47B3ED741C29B0B7800C13ACC8257EFCD6B8DB796BFFFFA5293B53") return "SC2";
            else return "kek";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var call = new CallsProperties();
            call.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateLabels()
        {
            label1.Text = "Записанных на диагностику на сегодня: " + dataGridView3.Rows.Count;
            label2.Text = "Количество звонков сегодня: " + msql.GetTotalCallsToday()[0];
            label3.Text = "Количество нецелевых звонков сегодня: " + msql.GetTotalCallsToday()[1];
        }

        private void SetRecords()
        {
            dataGridView1.Rows.Clear();
            foreach (CallRecord record in msql.GetAllRecords())
            {
                int lastRow = dataGridView1.Rows.Add("", record.ID, record.Date, record.Time, record.Name, record.Phone, record.Type, record.Brand, record.Reason, CallRecord.StatusToString(record.Status));
                dataGridView1[dataGridView1.ColumnCount - 1, lastRow].Value = "X";
                dataGridView1[dataGridView1.ColumnCount - 2, lastRow].Value = " ";
                if (record.Status == ApplicationStatus.WrongCall)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.White;
                }
                if (record.Status == ApplicationStatus.Accepted)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (record.Status == ApplicationStatus.RecordedAtDiagnostic)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (record.Status == ApplicationStatus.OnReCall)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.Wheat;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (record.Status == ApplicationStatus.AtDiagnostic)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }
        private void SetUntergeted()
        {
            dataGridView2.Rows.Clear();
            foreach (CallRecord record in msql.GetAllUntargeted())
            {
                int lastRow = dataGridView2.Rows.Add(record.ID,record.Date, record.Time, record.Phone);
                if (record.Status == ApplicationStatus.WrongCall)
                {
                    dataGridView2.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView2.Rows[lastRow].DefaultCellStyle.ForeColor = Color.White;
                }
                dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Descending);
            }
        }
        private void SetDiagnostics()
        {
            dataGridView3.Rows.Clear();
            foreach (CallRecord record in msql.GetAllAtDiagnostic())
            {
                int lastRow = dataGridView3.Rows.Add(record.Name, record.Phone,record.Reason);
                if (record.Status == ApplicationStatus.RecordedAtDiagnostic)
                {
                    dataGridView3.Rows[lastRow].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView3.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void SetAllRecieved()
        {
            dataGridView5.Rows.Clear();
            foreach (CallRecord record in msql.GetAllRecievedRecords())
            {
                int lastRow = dataGridView5.Rows.Add("", record.ID, record.Date, record.Time, record.Name, record.Phone, record.Type, record.Brand, record.Reason, CallRecord.StatusToString(record.Status));
                if (record.Status == ApplicationStatus.RecordedAtDiagnostic)
                {
                    dataGridView5.Rows[lastRow].DefaultCellStyle.BackColor = Color.White;
                    dataGridView5.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            dataGridView5.Sort(dataGridView5.Columns[1], ListSortDirection.Descending);
        }
        private void SetRecallsToday()
        {
            dataGridView4.Rows.Clear();
            foreach (CallRecord record in msql.GetAllReCalls())
            {
                int lastRow = dataGridView4.Rows.Add(record.ID,record.Name, record.Phone, record.Reason);
                if (record.Status == ApplicationStatus.OnReCall)
                {
                    dataGridView4.Rows[lastRow].DefaultCellStyle.BackColor = Color.Wheat;
                    dataGridView4.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
                dataGridView4.Sort(dataGridView4.Columns[0], ListSortDirection.Descending);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == senderGrid.ColumnCount-1)
            {
                DialogResult res = MessageBox.Show("Ты уверен?", "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) msql.DeleteRecord(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == senderGrid.ColumnCount - 2)
            {
                DataGridViewCellCollection col = dataGridView1.Rows[e.RowIndex].Cells;
                int ID = Convert.ToInt32(col[1].Value);
                ApplicationEditForm apef = new ApplicationEditForm();
                apef.ID = ID;
                apef.Show();
            }

           

        }

        private void ShowRowsAffected(int rowsCount)
        {
            //MessageBox.Show("Строк найдено: " + rowsCount.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}




//
//
//  Смотри
//
//
//
//
//
