using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


namespace Data_Access
{
    public class clsCommonData
    {
        // in the apointment feature i should add patient information
        // and exsisting employee info and not add new one remember this//
       public static int AddApointment (int PatientID ,int DoctorID,DateTime Schedule,string Note)
        {
            int AppointmaentID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.Connectionstring);

            string Query = @"Insert into Appointments(PatientID,EmployeeID,AppointmentDate,Note)
                             VALUES
                             (@PatientID,@DoctorID,@Schedule,@Note);
                             Declare @ID int = SCOPE_IDENTITY()
                             insert into AppointmentStatus(AppointmentID,StatusID)
                             VALUES
                             (@ID,@Status);
                                 SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(Query,Connection);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            cmd.Parameters.AddWithValue("@Schedule", Schedule);
            cmd.Parameters.AddWithValue("@Status", 1);

            if (Note != "")
            {
                cmd.Parameters.AddWithValue("@Note", Note);
            }
            else cmd.Parameters.AddWithValue("@Note", DBNull.Value);


            try
            {
                    Connection.Open();
                    object Result = cmd.ExecuteScalar();
                    if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int newID))
                    {
                        AppointmaentID = newID;
                    }
                }

                catch (Exception ex) { Console.WriteLine(ex); }
                finally { Connection.Close(); }

            return AppointmaentID;


        }


        public static DataTable GetAppointmentsInfos()
        {

            DataTable Table = new DataTable();

            SqlConnection connection= new SqlConnection(clsConnection.Connectionstring);

            string Query = @"Select * from ListAppointmentInfo";

            SqlCommand Command= new SqlCommand(Query,connection);


            try 
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                Table.Load(Reader);
                
                }
            
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally{ connection.Close(); }
            return Table;

        }




    }


}
