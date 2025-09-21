using System;
using System.Data;
using System.Data.SqlClient;


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
                             select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(Query,Connection);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            cmd.Parameters.AddWithValue("@Schedule", Schedule);
            cmd.Parameters.AddWithValue("@Note", Note);

            try 
            { 
                Connection.Open ();
                object Result= cmd.ExecuteScalar();
                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int newID))
                {
                    AppointmaentID = newID;
                }
            }

            catch (Exception ex){ Console.WriteLine(ex); }
            finally { Connection.Close(); }

            return AppointmaentID;


        }






    }


}
