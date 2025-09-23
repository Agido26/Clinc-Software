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


      
        public static bool FindUserByNameAndPasswoord(string username, string password)
        {
            bool isFind =false;
            SqlConnection Connection= new SqlConnection(clsConnection.Connectionstring);
            string Query = @"Select UserID,UserName, Password from LoginUsers
                             where UserName=@User and Password=@Password";
            SqlCommand com=new SqlCommand(Query, Connection);
            com.Parameters.AddWithValue("@User", username);
            com.Parameters.AddWithValue("@Password", password);
            try 
            {
                Connection.Open();
                SqlDataReader result= com.ExecuteReader();
                if (result.Read())
                {
                    isFind =true;
                   
                }
             result.Close();
            
            }
            catch (Exception ex){ Console.WriteLine(ex);isFind = false; }
            finally { Connection.Close(); }


            return isFind;
        }



        public static string GetEmployeeNameByUserName(string username, string password)
        {
            string isFind = "";
            SqlConnection Connection = new SqlConnection(clsConnection.Connectionstring);
            string Query = @"Select Employee= P.FirstName+' '+P.LastName,
                             UserName,
                             Password from LoginUsers
                             join
                             Employees E on E.EmployeeID=LoginUsers.EmployeeID 
                             join
                             Persons P on E.PersonID=P.PersonID
                             where UserName=@User and Password=@Password";

            SqlCommand com = new SqlCommand(Query, Connection);
            com.Parameters.AddWithValue("@User", username);
            com.Parameters.AddWithValue("@Password", password);
            try
            {
                Connection.Open();
                SqlDataReader result = com.ExecuteReader();
                if (result.Read())
                {
                    isFind = (string)result["Employee"];

                }
                result.Close();


            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { Connection.Close(); }


            return isFind;
        }





    }
}
