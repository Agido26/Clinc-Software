using System;
using System.Data;
using Data_Access;

namespace Business
{
    public class clsCommon
    {

        public int PatientID { get; set; }
        public int EmployeeID { get; set; }
        public int AppointmentID { get; set; }
        public string AppointmentNote { get; set; }
        public DateTime ApointmentDate { get; set; }

        enum enMode { Addnew, Update }
        enMode Mode = enMode.Addnew;

       public clsCommon()
        {
            this.PatientID = -1;
            this.EmployeeID = -1;
            this.AppointmentID = -1;
            this.AppointmentNote = "";
            this.ApointmentDate = DateTime.Now;

        }

        private bool _AddNewAppointment()
        {
            return (clsCommonData.AddApointment(this.PatientID, this.EmployeeID,
                this.ApointmentDate, this.AppointmentNote) != -1);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Addnew:
                    return _AddNewAppointment();


            }

            return false;
        }
    }
}