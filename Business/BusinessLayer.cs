using System;
using Data_Access;

namespace Business
{
    public class clsBusinessLayer
    {

    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gendor { get; set; }
        public string Address { get; set; }
        public string Emaill { get; set; }
        public string Phone { get; set; }


        enum enMode { AddNew=0, Update=1}
       enMode Mode=enMode.AddNew;

        public clsBusinessLayer() 
        {
        this.Id = -1;
            this.FirstName = "";
            this.LastName = "";
            this.DateOfBirth=DateTime.Now.ToString();
            this.Address = "";
            this.Phone = "";
            this.Emaill = "";
            this.Gendor = "";

            Mode =enMode.AddNew;
        }



        private clsBusinessLayer(string FirtsName, string LastName,
            string Birth,string Gender,string Emaill,string Address,string Phone)
        {
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

            this.Id = clsDataAccess.AddNewPatient(this.FirstName, this.LastName, this.DateOfBirth,this.Gendor,this.Phone,this.Address,this.Emaill);
       
             return (Id!=-1);

        }

        
        //private bool _UpdatePatient()
        //{
        //   ref string FirstName, LastName , DateOfBirth , Email , Address , Phone , Gendor ;

        //    clsDataAccess.updatePatientByID()

        //}


        public static clsBusinessLayer Find(int ID)
        {
             string FirstName="";
             string LastName="";
             string DateOfBirth="", Email="", Address="", Phone="", Gendor="";
           if( clsDataAccess.FindPaitentByID(ID,ref FirstName,ref LastName,ref DateOfBirth,ref Gendor,ref Phone,ref Address,ref Email))
           { return new clsBusinessLayer(FirstName,LastName,DateOfBirth,Gendor,Email,Address,Phone); }


           return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    return _ADDNewPatient();

               // case enMode.Update:

            
            }

            return false;
        }
    }
}
