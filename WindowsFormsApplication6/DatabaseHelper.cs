﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication6
   {
    class DatabaseHelper
        {

        //mysql-local        
        //  public static string connetionString = @"server=localhost;userid=snehalchauhan;password=snehalchauhan;database=snehalhospital";

        //mysql - aws
        public static string connetionString = @"server=snehal-hms-instance.cyrl03dxdpkn.us-east-1.rds.amazonaws.com;userid=snehalchauhan;password=snehalchauhan;database=snehalhospital";

        public static MySqlConnection connection = new MySqlConnection(connetionString);

        public static User getUser(string uid)
           {

            User user = new User();
            //SqlCommand command;
            MySqlCommand command;
            MySqlDataReader dataReader;
            string query = "select * from login where userid=@userid";
            connection.Open();
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userid", uid);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                {
                user.userId = uid;

                user.password = (string)dataReader["password"];
                user.firstName = (string)dataReader["firstname"];
                user.lastName = (string)dataReader["lastname"];
                }
            dataReader.Close();
            command.Dispose();
            connection.Close();
            return user;

            }


        public static DataTable getPatients()
            {
            connection.Open();
            MySqlDataAdapter sqa = new MySqlDataAdapter("select * from patientinfo", connection);
            DataTable dbt = new DataTable();
            sqa.Fill(dbt);
            connection.Close();
            return dbt;
            }
        public static PatientInformation getPatient(int pid)
            {
            PatientInformation pi = new PatientInformation();
            MySqlCommand command;
            MySqlDataReader dataReader;

            string query = "select * from patientinfo where pid=@pid";
            connection.Open();
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pid", pid);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                {
                pi.pid = pid;
                pi.date = (string)dataReader["date"];
                pi.name = (string)dataReader["name"];
                pi.gender = (string)dataReader["gender"];
                pi.age = (int)dataReader["age"];
                pi.address = (string)dataReader["address"];
                pi.disease = (string)dataReader["disease"];
                }
            dataReader.Close();
            command.Dispose();
            connection.Close();
            return pi;

            }



        public static void addPatient(PatientInformation patient)
            {
            // insert patient to database patient info table.
            string query = "insert into patientinfo(pid,date,name,gender,age,address,disease) values(@PID,@Date,@Name,@Gender,@Age,@Address,@Disease)";
            modifyPatient(patient, query);
            }



        public static void updatePatient(PatientInformation patient)
            {
            string query = "update patientinfo set  date=@Date,name=@Name,gender=@Gender,age=@Age,address=@Address,disease=@Disease where pid=@PID";
            modifyPatient(patient, query);

            }
        public static void deletePatient(int pid)
            {
            connection.Open();
            string query = "delete from patientinfo where pid=@PID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@PID", pid);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            }

        private static void modifyPatient(PatientInformation patient, string query)
            {
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@PID", patient.pid);
            command.Parameters.AddWithValue("@Date", patient.date);
            command.Parameters.AddWithValue("@Name", patient.name);
            command.Parameters.AddWithValue("@Gender", patient.gender);
            command.Parameters.AddWithValue("@Age", patient.age);
            command.Parameters.AddWithValue("@Address", patient.address);
            command.Parameters.AddWithValue("@Disease", patient.disease);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            }
        //roominformation

        public static DataTable getRooms()
            {
            connection.Open();
            MySqlDataAdapter sqa = new MySqlDataAdapter("select * from roombooking", connection);
            DataTable dbt = new DataTable();
            sqa.Fill(dbt);
            connection.Close();
            return dbt;

            }
        public static roomInformation getRoom(int pid)
            {
            roomInformation r = new roomInformation();
            MySqlCommand command;
            MySqlDataReader dataReader;
            string query = "select * from roombooking where pid=@pid";
            connection.Open();
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pid", pid);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                {
                r.pid = pid;
                r.Roomtype = (string)dataReader["roomtype"];
                r.Status = (string)dataReader["status"];
                r.Roomno = (int)dataReader["roomno"];
                r.Price = (int)dataReader["price"];
                r.Startdate = (string)dataReader["startdate"];
                r.Enddate = (string)dataReader["enddate"];
                }
            dataReader.Close();
            command.Dispose();
            connection.Close();
            return r;

            }
        public static void addRoom(roomInformation room)
            {
            // insert patient to database patient info table.
                string query2 = "insert into roombooking(pid,roomtype,roomno,price,startdate,enddate,status) values(@PID,@Roomtype,@Roomno,@Price,@Startdate,@Enddate,@Status)";
            modifyRoom(room, query2);
            }
        public static void updateRoom(roomInformation room)
            {
            string query2 = "update roombooking set roomtype=@Roomtype,@status=status,startdate=@Startdate,enddate=@Enddate,roomno=@Roomno,price=@Price where pid=@PID";
            modifyRoom(room, query2);

            }
        private static void modifyRoom(roomInformation room, string query2)
            {
            connection.Open();

            MySqlCommand command = new MySqlCommand(query2, connection);
            Console.WriteLine("QUERY:= " + query2);
            
            command.Parameters.AddWithValue("@PID", room.pid);
            command.Parameters.AddWithValue("@Roomtype", room.Roomtype);
            command.Parameters.AddWithValue("@Roomno", room.Roomno);
            command.Parameters.AddWithValue("@Price", room.Price);
            command.Parameters.AddWithValue("@Startdate", room.Startdate);
            command.Parameters.AddWithValue("@Enddate", room.Enddate);
            command.Parameters.AddWithValue("@Status", room.Status);

            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            }

        public static void deleteRoom(int pid)
            {
            connection.Open();
            string query = "delete from roombooking where pid=@PID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@PID", pid);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            }

        public static DataTable getBills()
            {
            connection.Open();
            MySqlDataAdapter sqa = new MySqlDataAdapter("select * from billpayment", connection);
            DataTable dbt = new DataTable();
            sqa.Fill(dbt);
            connection.Close();
            return dbt;

            }

        public static void addBill(Bill bill)
            {
            // insert patient to database patient info table.
                string query = "insert into billpayment(bid,pid,roomrent,medicinecharges,doctorcharges,reportcharges,othercharges,total) values(@BID,@PID,@RoomRent,@medicineCharges,@doctorCharges,@reportCharges,@otherCharges,@total)";
            modifybill(bill, query);
            }
        private static void modifybill(Bill bill, string query)
            {
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@BID", bill.bid);
            command.Parameters.AddWithValue("@PID", bill.pid);
            command.Parameters.AddWithValue("@RoomRent", bill.RoomRent);
            command.Parameters.AddWithValue("@medicineCharges", bill.medicineCharges);
            command.Parameters.AddWithValue("@doctorCharges", bill.doctorCharges);
            command.Parameters.AddWithValue("@reportCharges", bill.reportCharges);
            command.Parameters.AddWithValue("@otherCharges", bill.otherCharges);
            command.Parameters.AddWithValue("@total", bill.total);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            }


        }
    }
