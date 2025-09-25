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

            string Query = @"Select AppointmentID, Patient, Doctor,Status from ListAppointmentInfo
                                Order by AppointmentID Desc";

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


        public static DataTable GetApppointmentByID(int ID)
        {

            DataTable Find=new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.Connectionstring);

            string Query = @"Select * from ListAppointmentInfo
                               WHERE AppointmentId=@ID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Find.Columns.Add("Patient",typeof(string));
                    Find.Columns.Add("Doctor", typeof(string));
                    Find.Columns.Add("Gendor", typeof(string));
                    Find.Columns.Add("AppointmentDate", typeof(DateTime));
                    Find.Columns.Add("Birth", typeof(DateTime));
                    Find.Columns.Add("Status", typeof(string));
                    Find.Columns.Add("Note", typeof(string));
                    Find.Columns.Add("Phone", typeof(string));
                    Find.Columns.Add("AppointmentID", typeof(int));

                    DataRow row=Find.NewRow();
                    row["Patient"] = Reader["Patient"];
                    row["Doctor"] = Reader["Doctor"];
                    row["Gendor"] = Reader["Gendor"];
                    row["AppointmentDate"] = Reader["AppointmentDate"];
                    row["Birth"] = Reader["DateOfBirth"];
                    row["Status"] = Reader["Status"];
                    row["Note"] = Reader["Note"];
                    row["Phone"] = Reader["Phone"];
                    row["AppointmentID"] = Reader["AppointmentID"];
                    Find.Rows.Add(row);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { connection.Close(); }
            return Find;

        }


    }


}
