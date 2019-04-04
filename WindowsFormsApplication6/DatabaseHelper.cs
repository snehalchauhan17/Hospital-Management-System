using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication6
{
    class DatabaseHelper
    {

           public static  string connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vipul-Home\Documents\Visual Studio 2013\Projects\Hospital Management System\Hospital-Management-System\sql\hmsdb.mdf;Integrated Security=True;Connect Timeout=30";  
           public static  SqlConnection connection;
            public static void initializeConnection(){
                connection = new SqlConnection(connetionString);
                connection.Open();                  
            }

            public static DataTable LoadPatientData()
            {
            SqlDataAdapter sqa = new SqlDataAdapter("select * from patientInfo", connection);
            DataTable dbt = new DataTable();
            sqa.Fill(dbt);
            return dbt; 
        }

            public static void addPatient(PatientInformation patient)
            {
                // insert patient to database patient info table. 
                string query = "insert into patientInfo values(@PID,@Date,@Name,@Gender,@Age,@Address,@Disease)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PID", patient.pid);
                cmd.Parameters.AddWithValue("@Date", patient.date);
                cmd.Parameters.AddWithValue("@Name", patient.name);
                cmd.Parameters.AddWithValue("@Gender", patient.gender);
                cmd.Parameters.AddWithValue("@Age", patient.age);
                cmd.Parameters.AddWithValue("@Address", patient.address);
                cmd.Parameters.AddWithValue("@Disease", patient.disease);
                cmd.ExecuteNonQuery();
            }
            public static void closeConnection()
            {
            connection.Close();
        }
           
            

    }
}
