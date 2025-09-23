using System;
using Data_Access;
using System.Data;

namespace Business
{
    public class clsEmplyees
    {

        public static DataTable GetAllEmployees()
        {         
                return clsEmployeeData.GetAllEmployee();
        }



        public static bool IsEmployeeExist(string Name, string Password)
        {
            return clsEmployeeData.FindUserByNameAndPasswoord(Name, Password); 
        }
        public static string GetNameifEmployeeExist(string Name, string Password)
        {
            return clsEmployeeData.GetEmployeeNameByUserName(Name, Password);
        }


    }



}
