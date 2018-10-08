using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql;
using System.Windows.Forms;

namespace LCService
{
    public delegate void Record();
    public delegate void AffectedRowsInt(int rows);
   

    public class MySQLWork
    {
        private static MySQLWork instance;

        private MySqlConnection con;

        public event Record RecordReceived;
        public event AffectedRowsInt RowsAffected;

        public static MySQLWork GetInstance()
        {
            if (instance == null) instance = new MySQLWork();

            return instance;
        }

        private MySQLWork()
        {
            string connectionString = "server=35.204.144.43;user=Naglfar;database=ServiceDB;Password=Qsza1234;";
            con = new MySqlConnection(connectionString);
            con.Open();
        }

        public string WriteRecord(CallRecord record)
        {
            string com = (new StringBuilder()).AppendFormat("INSERT INTO IncomingCalls (Date,Time,Name,PhoneNumber,TechType,Brand,Reason,State) VALUES ('{0}','{1}','{2}','+7{3}','{4}','{5}','{6}','{7}')", record.Date,record.Time,record.Name,record.Phone,record.Type,record.Brand, record.Reason, CallRecord.StatusToString(record.Status)).ToString();
            MySqlCommand comm = new MySqlCommand(com, con);
            comm.ExecuteNonQuery();
            RecordReceived();
            return com;
        }

        public string WriteRecord(CallRecord record, bool diagnostic)
        {
            string com = "";
            if (diagnostic)
            {
                 com = (new StringBuilder()).AppendFormat("INSERT INTO IncomingCalls (Date,Time,Name,PhoneNumber,TechType,Brand,Reason,DiagnosticDate,State) VALUES ('{0}','{1}','{2}','+7{3}','{4}','{5}','{6}', '{7}' ,'{8}')", record.Date, record.Time, record.Name, record.Phone, record.Type, record.Brand, record.Reason, record.DiagnosticDate, CallRecord.StatusToString(record.Status)).ToString();
            }
            if (!diagnostic)
            {
                
                 com = (new StringBuilder()).AppendFormat("INSERT INTO IncomingCalls (Date,Time,Name,PhoneNumber,TechType,Brand,Reason,RecallDate,State) VALUES ('{0}','{1}','{2}','+7{3}','{4}','{5}','{6}', '{7}' ,'{8}')", record.Date, record.Time, record.Name, record.Phone, record.Type, record.Brand, record.Reason, record.RecallDate, CallRecord.StatusToString(record.Status)).ToString();
            }
            MySqlCommand comm = new MySqlCommand(com, con);
            comm.ExecuteNonQuery();
            RecordReceived();
            return com;
        }

        public List<CallRecord> GetAllRecords()
        {
            List<CallRecord> records = new List<CallRecord>();

            string com = "SELECT ID, Date, Time, Name, PhoneNumber, TechType, Brand, Reason, State FROM IncomingCalls";
            MySqlCommand command = new MySqlCommand(com, con);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                records.Add(new CallRecord( Convert.ToInt32(reader["ID"].ToString()), reader["Date"].ToString(), reader["Time"].ToString(), reader["Name"].ToString(), reader["PhoneNumber"].ToString(), reader["TechType"].ToString(), reader["Brand"].ToString(), reader["Reason"].ToString(), CallRecord.StringToStatus(reader["State"].ToString())));
            }

            reader.Close();
            return records;
        }

        public List<CallRecord> GetAllRecievedRecords()
        {
            List<CallRecord> records = new List<CallRecord>();

            string com = "SELECT ID, Date, Time, Name, PhoneNumber, TechType, Brand, Reason, State FROM IncomingCalls WHERE State = 'Звонок принят'";
            MySqlCommand command = new MySqlCommand(com, con);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                records.Add(new CallRecord(Convert.ToInt32(reader["ID"].ToString()), reader["Date"].ToString(), reader["Time"].ToString(), reader["Name"].ToString(), reader["PhoneNumber"].ToString(), reader["TechType"].ToString(), reader["Brand"].ToString(), reader["Reason"].ToString(), CallRecord.StringToStatus(reader["State"].ToString())));
            }

            reader.Close();
            return records;
        }

        public List<CallRecord> GetAllUntargeted()
        {
            List<CallRecord> records = new List<CallRecord>();

            string com = "SELECT ID, Date, Time, Name, PhoneNumber, TechType, Brand, Reason, State FROM IncomingCalls WHERE State = 'Нецелевой звонок' ";
            MySqlCommand command = new MySqlCommand(com, con);

            MySqlDataReader reader = command.ExecuteReader();
            int counter = 0;
            while (reader.Read())
            {
                counter++;
                records.Add(new CallRecord(Convert.ToInt32(reader["ID"].ToString()), reader["Date"].ToString(), reader["Time"].ToString(), reader["Name"].ToString(), reader["PhoneNumber"].ToString(), reader["TechType"].ToString(), reader["Brand"].ToString(), reader["Reason"].ToString(), CallRecord.StringToStatus(reader["State"].ToString())));
            }
            reader.Close();
            return records;
        }

        public List<CallRecord> GetAllAtDiagnostic()
        {

            List<CallRecord> records = new List<CallRecord>();

            string com = "SELECT * FROM IncomingCalls WHERE DiagnosticDate = '" + DateTime.Now.ToShortDateString() + "'";

            MySqlCommand command = new MySqlCommand(com, con);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CallRecord rec = new CallRecord();
                rec.Name = reader["Name"].ToString();
                rec.Phone = reader["PhoneNumber"].ToString();
                rec.Reason = reader["Reason"].ToString();
                rec.Status = CallRecord.StringToStatus(reader["State"].ToString());
                records.Add(rec);
            }

            reader.Close();
            return records;

        }

        public List<CallRecord> GetAllReCalls()
        {

            List<CallRecord> records = new List<CallRecord>();

            string com = "SELECT * FROM IncomingCalls WHERE RecallDate = '" + DateTime.Now.ToShortDateString() + "'";

            MySqlCommand command = new MySqlCommand(com, con);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CallRecord rec = new CallRecord();
                rec.ID = Convert.ToInt32(reader["ID"].ToString());
                rec.Name = reader["Name"].ToString();
                rec.Phone = reader["PhoneNumber"].ToString();
                rec.Reason = reader["Reason"].ToString();
                rec.Status = CallRecord.StringToStatus(reader["State"].ToString());
                records.Add(rec);
            }

            reader.Close();
            return records;

        }

        public int[] GetTotalCallsToday()
        {
            string com = "SELECT * FROM IncomingCalls WHERE Date = '" + DateTime.Now.ToShortDateString() + "'";
            MySqlCommand command = new MySqlCommand(com, con);
            MySqlDataReader reader = command.ExecuteReader();
            int counter = 0;
            int wrongCounter = 0;
            while (reader.Read())
            {
                counter++;
                if (reader["State"].ToString() == CallRecord.StatusToString(ApplicationStatus.WrongCall))
                {
                    wrongCounter++;
                }
            }
            reader.Close();

            int[] ar = new int[2];
            ar[0] = counter;
            ar[1] = wrongCounter;
            return ar;
        }

        public void DeleteRecord(string id)
        {
            string com = "DELETE FROM IncomingCalls WHERE ID = " + id;
            MySqlCommand command = new MySqlCommand(com, con);
            command.ExecuteNonQuery();
            RecordReceived();
        }

        public CallRecord GetRecord(int ID)
        {
            string com = "SELECT * FROM IncomingCalls WHERE ID = " + ID.ToString();
            MySqlCommand command = new MySqlCommand(com, con);
            MySqlDataReader reader = command.ExecuteReader();
            CallRecord record = new CallRecord();
            int counter = 0;
            
            while (reader.Read())
            {
                counter++;
                record.ID = ID;
                record.Date = reader["Date"].ToString();
                record.Time = reader["Time"].ToString();
                record.Name = reader["Name"].ToString();
                record.Phone = reader["PhoneNumber"].ToString();
                record.Type = reader["TechType"].ToString();
                record.Brand = reader["Brand"].ToString();
                record.Reason = reader["Reason"].ToString();
                record.Status = CallRecord.StringToStatus(reader["State"].ToString());
                record.DiagnosticDate = reader["DiagnosticDate"].ToString();
                record.RecallDate = reader["RecallDate"].ToString();
            }
            reader.Close();
            return record;

        }

        public int TransferMissedDiagnostic()
        {
            DateTime ystrd = DateTime.Today - new TimeSpan(1, 0, 0, 0);
            string com = "UPDATE IncomingCalls SET DiagnosticDate = '" + DateTime.Now.ToShortDateString() + "', State = 'Ждет обработки' WHERE DiagnosticDate = '" + ystrd.ToShortDateString() + "'" ;
            MySqlCommand command = new MySqlCommand(com, con);
            return command.ExecuteNonQuery();
        }

        public bool UpdateRecord(CallRecord record)
        {
            string com = " ";
            try
            {
                     com = new StringBuilder().AppendFormat("" +
                    "UPDATE" +
                    " IncomingCalls" +
                    " SET" +
                    " Date = '{0}'," +
                    " Time = '{1}'," +
                    " Name = '{2}'," +
                    " PhoneNumber = '{3}'," +
                    " TechType = '{4}'," +
                    " Brand = '{5}'," +
                    " Reason = '{6}'," +
                    " State =  '{7}'," +
                    " DiagnosticDate = '{8}'," +
                    " RecallDate = '{9}'" +
                    " WHERE ID= {10}"
                    , record.Date, record.Time,record.Name,record.Phone,record.Type,
                    record.Brand,record.Reason,
                    CallRecord.StatusToString(record.Status),
                    record.DiagnosticDate,record.RecallDate,record.ID.ToString()).ToString();

                MySqlCommand command = new MySqlCommand(com, con);
                command.ExecuteNonQuery();
                RecordReceived();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}
