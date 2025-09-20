using System;
using System.Data;
using System.Data.SqlClient;


namespace Data_Access
{
    public class clsDataAccess
    {

        public static int AddNewPatient(string FirstName,
            string LastName,string DateOfBirth,string Gendor,string Phone,string Address,string Email
            )

        {
            int ID = -1;
            SqlConnection ConnectionString=new SqlConnection(clsConnection.Connectionstring);

            string Query = @"INSERT INTO Persons (FirstName,LastName,DateOfBirth,Gendor,Phone,Address,Email)
                             VALUES (@FirstName,@LastName,@DateOfBirth,@Gendor,@Phone,@Address,@Email);

                              DECLARE @NewPatientID INT = SCOPE_IDENTITY();
                              
                              INSERT INTO Patients (PersonID)
                              VALUES (@NewPatientID);
                              
                              SELECT SCOPE_IDENTITY() ;
                              ";
            SqlCommand command = new SqlCommand(Query,ConnectionString);

            command.Parameters.AddWithValue("@FirstName",FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);


            try
            {
                ConnectionString.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                {
                    ID = NewID;
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            finally
            { ConnectionString.Close(); }

                return ID;

             }


        public static bool updatePatientByID(int ID,ref string FirstName, ref string LastName, ref string DateOfBirth,
            ref string Gendor, ref string Phone, ref string Address, ref string Email)
        {
            bool isUpdated = false;
            SqlConnection ConnectionString = new SqlConnection(clsConnection.Connectionstring);
            string query = @"UPDATE Persons
                            SET
                            FirstName=@FirstName,LastName=@LastName,DateOfBirth=@DateOfBirth,Gendor=@Gendor,Phone=@Phone,Address=@Address,Email=@Email
                            from Persons
                            JOIN Patients ON Persons.PersonID=Patients.PersonID
                            where Patients.PatientID=@PatientID;
                            ";

            SqlCommand Command = new SqlCommand(query,ConnectionString);
            Command.Parameters.AddWithValue("@PatientID", ID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);

            try 
            {
                ConnectionString.Open();
                int Reader = Command.ExecuteNonQuery();

                if (Reader > 0)
                {
                    isUpdated = true;

                }


            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex);
                isUpdated = false;
            }

            finally { ConnectionString.Close(); }

            return isUpdated;


        }



        public static bool FindPaitentByID(int ID, ref string FirstName, ref string LastName, ref string DateOfBirth,
            ref string Gendor, ref string Phone, ref string Address, ref string Email)
        {
            bool isFind= false;
            SqlConnection ConnectionString = new SqlConnection(clsConnection.Connectionstring);

            string Query = @"Select Persons.FirstName,Persons.LastName,Persons.DateOfBirth,
                              Persons.Gendor,Persons.Phone,Persons.Address,Persons.Email
                              from Persons join Patients on Patients.PersonID=Persons.PersonID 
                              where PatientID=@PatientID;                    
                                    ";

            SqlCommand Command= new SqlCommand(Query,ConnectionString);
            Command.Parameters.AddWithValue("@PatientID", ID);

            try
            {
                ConnectionString.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    FirstName =(string) Reader["FirstName"];
                    LastName = (string)Reader["LastName"];

                    if (Reader["DateOfBirth"] != DBNull.Value)
                    {
                        DateOfBirth = Reader["DateOfBirth"].ToString();
                    }
                    else DateOfBirth = "";

                    if (Reader["Address"] != DBNull.Value)
                    { Address = (string)Reader["Address"]; }
                    else Address = "";

                    if (Reader["Email"] != DBNull.Value)

                    { Email = (string)Reader["Email"]; }
                    else Email = "";

                    if (Reader["Phone"] != DBNull.Value)

                    {
                        Phone = (string)Reader["Phone"];
                    }
                    else Phone = "";

                    if (Reader["Gendor"] != DBNull.Value)

                    { Gendor = (string)Reader["Gendor"]; }
                    else Gendor = "";

                    isFind = true;

                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex); isFind = false; }
            finally { ConnectionString.Close(); }
            return isFind;
        }



    }











}
