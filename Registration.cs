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

namespace Kalendoriausprojektas
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                MessageBox.Show("Please fill all of the fields");
            }
            else if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                using (SqlConnection sqlCnnct = new SqlConnection(@""))
                {
                    sqlCnnct.Open();
                    SqlCommand sqlCmmnd = new SqlCommand("PridetiVartotoja", sqlCnnct);
                    sqlCmmnd.CommandType = CommandType.StoredProcedure;
                    sqlCmmnd.Parameters.AddWithValue("@vartotojoVardas", txtUsername.Text);
                    sqlCmmnd.Parameters.AddWithValue("@slaptazodis", txtPassword.Text);
                    sqlCmmnd.Parameters.AddWithValue("@slaptazodisPakartot", txtComPassword.Text);
                    MessageBox.Show("Registration completed!");
                    sqlCmmnd.ExecuteNonQuery();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";

                }
            }
        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }
    }
}
