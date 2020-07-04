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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm f1 = new mainForm();
            f1.Show();
        }

        private void submit1_Click(object sender, EventArgs e)
        {
            string name = name1.Text;
            string logIn = logIn1.Text;
            string password = passwd1.Text;
            string email = email1.Text;
            char gender;
            string address = address1.Text;
            int age = Convert.ToInt32(age1.Value);
            string NIC = NIC1.Text;
            int football ;
            if(football1.Checked==true)
            {
                football = 1;
            }
            else
            {
                football = 0;
            }
            int cricket;
            if (cricket1.Checked == true)
            {
                cricket = 1;
            }
            else
            {
                cricket = 0;
            }
            int hockey;
            if (hockey1.Checked == true)
            {
                hockey = 1;
            }
            else
            {
                hockey = 0;
            }
            if (name == "" || logIn == "" || password == "" || email == "" || gender1.Text == "" || age == 0)
            {
                MessageBox.Show("Some Field is empty.");
            }
            if (gender1.Text == "Male")
            {
                gender = 'm';
            }
            else if (gender1.Text == "Female")
            {
                gender = 'f';
            }
            else
            {
                gender = 'o';
            }
            string connString = @"Data Source=USMANBHATTI\SQLSERVEREXPRESS;Initial Catalog = Assignment4;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            
            string sqlQuery = "Insert into dbo.Users(name,login,password,gender,address,age,nic,football,cricket,hocky) values('"+name+ "','" + logIn + "','" + password + "','" + gender + "','" + address + "'," + age + ",'" + NIC + "'," + football + "," + cricket + "," + hockey + ");";
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            int recAff = command.ExecuteNonQuery();
            MessageBox.Show("Records affected are:"+recAff);
            this.Hide();
            userHome u1 = new userHome();
            u1.Show();
            u1.label1.Text = "Welcome " + name;   
        }

        private void upload1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK )
            {
                string file = openFileDialog1.FileName;
                pictureBox1.Load(file);
            }
        }
    }
}
