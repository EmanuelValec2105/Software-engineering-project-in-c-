using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleaningSolutions.Models

{
    public class WorkerRepository
    {
        public static Worker GetWorker(int id)
        {
            Worker worker = null;

            string sql = $"SELECT * FROM Workers WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                worker = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return worker;
        }

        public static List<Worker> GetWorkers()
        {
            var workers = new List<Worker>();
            
            string sql = "SELECT * FROM Workers";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Worker worker = CreateObject(reader);
                workers.Add(worker);
            }

            reader.Close();
            DB.CloseConnection();

            return workers;
        }

        private static Worker CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string phoneNumber = reader["PhoneNumber"].ToString();

            var worker = new Worker
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };

            return worker;
        }
    }
}
