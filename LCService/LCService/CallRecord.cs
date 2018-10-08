using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCService
{

    public enum ApplicationStatus
    {
        Accepted, AtDiagnostic, DiagnosticFinished, InProcess, Delivering, Finished, Declained, WrongCall, RecordedAtDiagnostic, OnReCall
    }

    public class CallRecord
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Reason { get; set; }
        public ApplicationStatus Status { get; set; }
        public string DiagnosticDate { get; set; }
        public string RecallDate { get; set; }

        public CallRecord(string date, string time, string name, string phone, string type, string brand, string model, string reason,string dd, ApplicationStatus status)
        {
            Date = date;
            Time = time;
            Name = name;
            Phone = phone;
            Type = type;
            Brand = brand;
            Model = model;
            Reason = reason;
            Status = status;
            DiagnosticDate = dd;
        }
        public CallRecord(int id, string date, string time, string name, string phone, string type, string brand, string reason, ApplicationStatus status)
        {
            ID = id;
            Date = date;
            Time = time;
            Name = name;
            Phone = phone;
            Type = type;
            Brand = brand;
            Reason = reason;
            Status = status;
        }
        public CallRecord(string date, string time, string name, string phone,string type, string brand, string model, string reason, ApplicationStatus status)
        {
            Date = date;
            Time = time;
            Name = name;
            Phone = phone;
            Type = type;
            Brand = brand;
            Model = model;
            Reason = reason;
            Status = status;
        }
        public CallRecord(string date, string time, ApplicationStatus status)
        {
            Date = date;
            Time = time;
            Status = status;
        }
        public CallRecord()
        { }

        public string SetInDatabase(bool Diagnostic)
        {
            MySQLWork wrk = MySQLWork.GetInstance();
            if (Diagnostic)
            {
                return wrk.WriteRecord(this, Diagnostic);
            }
            else
            {
                return wrk.WriteRecord(this, Diagnostic);
            }
        }
        public string SetInDatabase()
        {
            MySQLWork wrk = MySQLWork.GetInstance();
            return wrk.WriteRecord(this);
        }

        public static string StatusToString(ApplicationStatus status)
        {
            switch (status)
            {
                case ApplicationStatus.WrongCall:
                    {
                        return "Нецелевой звонок";
                    }

                case ApplicationStatus.Accepted:
                    {
                        return "Звонок принят";
                    }

                case ApplicationStatus.AtDiagnostic:
                    {
                        return "Передано на диагностику";
                    }

                case ApplicationStatus.Declained:
                    {
                        return "Заявка отменена";
                    }

                case ApplicationStatus.DiagnosticFinished:
                    {
                        return "Диагностика завершена";
                    }
                case ApplicationStatus.RecordedAtDiagnostic:
                    {
                        return "Записан на диагностику";
                    }
                case ApplicationStatus.OnReCall:
                    {
                        return "Ждет обработки";
                    }

            }

            return "Статус не определен";

        }

        public static ApplicationStatus StringToStatus(string status)
        {
            switch (status)
            {
                case "Нецелевой звонок":
                    {
                        return ApplicationStatus.WrongCall;
                    }
                case "Звонок принят":
                    {
                        return ApplicationStatus.Accepted;
                    }
                case "Записан на диагностику":
                    {
                        return ApplicationStatus.RecordedAtDiagnostic;
                    }
                case "Ждет обработки":
                    {
                        return ApplicationStatus.OnReCall;
                    }
                case "Передано на диагностику":
                    {
                        return ApplicationStatus.AtDiagnostic;
                    }
            }
            return ApplicationStatus.Declained;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("ID {0} Date {1} Time {2} Name {3} Phone {4} Type {5} Brand {6} Reason {7} Status {8}", ID, Date, Time, Name, Phone, Type, Brand, Reason, StatusToString(Status)).ToString();
        }
    }
}
