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
    public partial class ApllicationViewer : Form
    {

        private MySQLWork msql;
        public ApllicationViewer()
        {
            InitializeComponent();
            msql = MySQLWork.GetInstance();
        }

        private void ApllicationViewer_Load(object sender, EventArgs e)
        {
            SetRecords();
        }

        private void SetRecords()
        {
            
            dataGridView1.Rows.Clear();
            foreach (CallRecord record in msql.GetAllRecords())
            {
                int lastRow = dataGridView1.Rows.Add("" , record.ID,record.Date, record.Time, record.Name, record.Phone, record.Type, record.Brand, record.Reason, CallRecord.StatusToString(record.Status));
                if (record.Status == ApplicationStatus.WrongCall)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.White;

                }
                if (record.Status == ApplicationStatus.Accepted)
                {
                    dataGridView1.Rows[lastRow].DefaultCellStyle.BackColor = Color.LightBlue;
                    dataGridView1.Rows[lastRow].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void ApllicationViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            msql = null;
            this.Dispose();
        }
    }



}
