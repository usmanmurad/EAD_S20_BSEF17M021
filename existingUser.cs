using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm
{
    public partial class existingUser : Form
    {
        public existingUser()
        {
            InitializeComponent();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm f1 = new mainForm();
            f1.Show();
        }

        private void btnLogin3_Click(object sender, EventArgs e)
        {
            string login = login3.Text;
            string password = password3.Text;
            string connString = @"Data Source=USMANBHATTI\SQLSERVEREXPRESS;Initial Catalog = Assignment4;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sqlQuery = "Select Password,name from users where login='" + login + "'";
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {

                string password1 = (string)reader.GetValue(0);
                //MessageBox.Show(password1);
                
                if (password1 == password)
                {
                    this.Hide();
                    userHome u1 = new userHome();
                    u1.Show();
                    u1.label1.Text="Welcome "+ (string)reader.GetValue(1);
                }
            }
            conn.Close();

        }
    }
}
