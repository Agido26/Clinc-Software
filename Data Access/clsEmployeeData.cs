using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access
{
    public class clsEmployeeData
    {
        public static DataTable GetAllEmployee()
        {
            DataTable Employees=new DataTable();
            SqlConnection ConnectionString = new SqlConnection(clsConnection.Connectionstring);

            string Query = @" select E.EmployeeID , P.FirstName,P.LastName from Persons P
                              join Employees E
                              on E.PersonID=P.PersonID";

            SqlCommand Command = new SqlCommand(Query, ConnectionString);
            

            try
            {
                ConnectionString.Open();

                SqlDataReader Reader = Command.ExecuteReader();
               
                if (Reader.HasRows)
                {
                   Employees.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex); Employees = null; }
            finally { ConnectionString.Close(); }
            return Employees;
        }


      




    }
}
