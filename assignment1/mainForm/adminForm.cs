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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm f1 = new mainForm();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = adminLogin.Text;
            string password = adminPasswd.Text;
            if (login != "" || password != "")
            {
                string connString = @"Data Source=USMANBHATTI\SQLSERVEREXPRESS;Initial Catalog = Assignment4;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string sqlQuery = "Select Password from Admin where Login='"+login+"'";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {

                    string password1 = (string)reader.GetValue(0);
                   // MessageBox.Show(password1);
                    conn.Close();
                    if (password1 == password)
                    {
                        this.Hide();
                        adminHome h1 = new adminHome();
                        h1.Show();
                    }
                }
            }
        }
    }
}
