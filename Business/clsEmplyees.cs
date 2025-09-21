using System;
using Data_Access;
using System.Data;

namespace Business
{
    public class clsEmplyees
    {
        public static DataTable GetAllEmployees()
        {
            if (clsEmployeeData.GetAllEmployee() != null)
            {
                return clsEmployeeData.GetAllEmployee();
            }
            else return null;
        
        }







    }



}
