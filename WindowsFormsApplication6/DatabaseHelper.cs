﻿using System;
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

            public static DataTable getPatients()
            {
            SqlDataAdapter sqa = new SqlDataAdapter("select * from patientInfo", connection);
            DataTable dbt = new DataTable();
            sqa.Fill(dbt);
            return dbt; 
        }
            public static PatientInformation getPatient(int pid)
            {
                PatientInformation pi = new PatientInformation();
                SqlCommand command;
                SqlDataReader dataReader;
                string query="select * from patientInfo where pid=" + pid;
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    pi.pid = pid;
                    pi.date = (string) dataReader["date"];
                    pi.name = (string)dataReader["name"];
                    pi.gender = (string)dataReader["gender"];
                    pi.age = (int)dataReader["age"];
                    pi.address = (string)dataReader["address"];
                    pi.disease = (string)dataReader["disease"]; 
                }
                dataReader.Close();
                command.Dispose();
                return pi;
            }


            public static void addPatient(PatientInformation patient)
            {
                // insert patient to database patient info table. 
                string query = "insert into patientInfo values(@PID,@Date,@Name,@Gender,@Age,@Address,@Disease)";
                modifyPatient(patient, query);
            }



            public static void updatePatient(PatientInformation patient)
            {
                string query = "update PatientInfo set  date=@Date,name=@Name,gender=@Gender,age=@Age,address=@Address,disease=@Disease where pid=@PID";
                modifyPatient(patient, query);              
                
            }
        public static void deletePatient(int pid)
            {       

                 string query = "delete from PatientInfo where pid=@PID";
                 SqlCommand command = new SqlCommand(query, connection);
                 command.Parameters.AddWithValue("@PID", pid);
                 command.ExecuteNonQuery();
                 command.Dispose();
            }

            private static void modifyPatient(PatientInformation patient, string query)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PID", patient.pid);
                command.Parameters.AddWithValue("@Date", patient.date);
                command.Parameters.AddWithValue("@Name", patient.name);
                command.Parameters.AddWithValue("@Gender", patient.gender);
                command.Parameters.AddWithValue("@Age", patient.age);
                command.Parameters.AddWithValue("@Address", patient.address);
                command.Parameters.AddWithValue("@Disease", patient.disease);
                command.ExecuteNonQuery();
                command.Dispose();
            }
//roominformation
         
            public static DataTable getRooms()
            {
                SqlDataAdapter sqa = new SqlDataAdapter("select * from roombooking", connection);
                DataTable dbt = new DataTable();
                sqa.Fill(dbt);
                return dbt; 
            }
            public static roomInformation getRoom(int pid)
            {
                roomInformation r = new roomInformation();
                SqlCommand command;
                SqlDataReader dataReader;
                string query = "select * from roombooking where pid=" + pid;
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    r.pid = pid;
                    r.Roomtype = (string)dataReader["roomtype"];
                    r.Status = (string)dataReader["Status"];
                    r.Startdate = (string)dataReader["Startdate"];
                    r.Enddate = (string)dataReader["Enddate"];
                    r.Roomno = (int)dataReader["Roomno"];
                    r.Price = (int)dataReader["Price"];
                }
                dataReader.Close();
                command.Dispose();
                return r;
            }
            public static void addRoom(roomInformation room)
            {
                // insert patient to database patient info table. 
                string query = "insert into roombooking values(@PID,@Roomtype,@Status,@Startdate,@Enddate,@Roomno,@Price)";
                modifyRoom(room, query);
            }
            public static void updateRoom(roomInformation room)
            {
                string query = "update roombooking set Roomtype=@Roomtype,Status=@Status,Startdate=@Startdate,Enddate=@Enddate,Roomno=@Roomno,Price=@Price where pid=@PID";
                modifyRoom(room, query);

            }
            private static void modifyRoom(roomInformation room, string query)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pid", room.pid);
                command.Parameters.AddWithValue("@Roomtype", room.Roomtype);
                command.Parameters.AddWithValue("@Status", room.Status);
                command.Parameters.AddWithValue("@Startdate", room.Startdate);
                command.Parameters.AddWithValue("@Enddate", room.Enddate);
                command.Parameters.AddWithValue("@Roomno", room.Roomno);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.ExecuteNonQuery();
                command.Dispose();
            }
          
            public static void deleteRoom(int pid)
            {

                string query = "delete from roombooking where pid=@PID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PID", pid);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            public static void closeConnection()
            {
            connection.Close();
        }
           
            

    }
}
