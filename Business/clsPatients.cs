using System;
using Data_Access;
using System.Data;

namespace Business
{
    public class clsPatients
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gendor { get; set; }
        public string Address { get; set; }
        public string Emaill { get; set; }
        public string Phone { get; set; }


        enum enMode { AddNew=0, Update=1}
       enMode Mode=enMode.AddNew;

        public clsPatients() 
        {
        this.Id = -1;
            this.FirstName = "";
            this.LastName = "";
            this.DateOfBirth=DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Emaill = "";
            this.Gendor = "";

            Mode =enMode.AddNew;
        }



        private clsPatients(int ID,string FirtsName, string LastName,
            DateTime Birth,string Gender,string Emaill,string Address,string Phone)
        {
            this.Id = ID;
            this.FirstName = FirtsName;
            this.LastName = LastName;
            this.DateOfBirth = Birth;
            this.Address=Address;
            this.Phone=Phone;
            this.Emaill=Emaill;
            this.Gendor = Gender;

            Mode = enMode.Update;
        }

        private bool  _ADDNewPatient()
        {

            this.Id = clsPatientData.AddNewPatient(this.FirstName, this.LastName, this.DateOfBirth,this.Gendor,this.Phone,this.Address,this.Emaill);
       
             return (Id!=-1);

        }


        private bool _UpdatePatient()
        {
           return clsPatientData.updatePatientByID(this.Id,this.FirstName,this.LastName,this.DateOfBirth,this.Gendor,this.Phone,this.Address,this.Emaill);

        }


        public static clsPatients Find(int ID)
        {
             string FirstName="";
             string LastName="", Email="", Address="", Phone="", Gendor="";
            DateTime DateOfBirth = DateTime.Now;
           if ( clsPatientData.FindPaitentByID(ID,ref FirstName,ref LastName,ref DateOfBirth,ref Gendor,ref Phone,ref Address,ref Email))
           { return new clsPatients(ID,FirstName,LastName,DateOfBirth,Gendor,Email,Address,Phone); }


           return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    return _ADDNewPatient();

                case enMode.Update:
                    return _UpdatePatient();


            
            }

            return false;
        }
    }




}
