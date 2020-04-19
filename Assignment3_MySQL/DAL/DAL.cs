using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL
    {
        public static List<Folders> GetFolders(int ID)
        {
            MySqlConnectionStringBuilder bu = new MySqlConnectionStringBuilder();
            bu.Server = "localhost";
            bu.UserID = "root";
            bu.Password = "abcd";
            bu.Database = "Assignment3";
            bu.ConvertZeroDateTime = true;

            List<Folders> l1 = new List<Folders>();
            string connString = bu.ToString();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string sqlQuery = "Select * from Folders where Parent=" + ID;
            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read() == true)
            {
                Folders f1 = new Folders();
                f1.ID = (int)reader.GetValue(0);
                f1.Name = (string)reader.GetValue(1);
                f1.Parent = (int)reader.GetValue(2);
                l1.Add(f1);
            }
            conn.Close();
            return l1;
        }
        public static int CreateFolder(int ID, string Name)
        {
            //DataBase Logic
            MySqlConnectionStringBuilder bu = new MySqlConnectionStringBuilder();
            bu.Server = "localhost";
            bu.UserID = "root";
            bu.Password = "abcd";
            bu.Database = "Assignment3";
            bu.ConvertZeroDateTime = true;
            string connString = bu.ToString();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string sqlQuery = "Insert into dbo.Folders(Name,Parent) values('" + Name + "','" + ID + "');";
            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
            command.ExecuteNonQuery();
            sqlQuery = "Select ID from Folders where Name=" + "'" + Name + "'";
            command = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                int val = (int)reader.GetValue(0);
                conn.Close();
                return val;
            }
            else
            {
                conn.Close();
                return -1;
            }
            //return Redirect("~/Users/SignUp");
        }
        public static int ReturnParent(int Child)
        {
            MySqlConnectionStringBuilder bu = new MySqlConnectionStringBuilder();
            bu.Server = "localhost";
            bu.UserID = "root";
            bu.Password = "abcd";
            bu.Database = "Assignment3";
            bu.ConvertZeroDateTime = true;
            string connString = bu.ToString();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string sqlQuery = "Select Parent from Folders where ID=" + Child;
            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int parent = -1;
            if (reader.Read() == true)
            {
                parent = (int)reader.GetValue(0);
            }
            conn.Close();
            return parent;
        }
    }

}