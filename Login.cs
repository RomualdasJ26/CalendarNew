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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool IsValid()
        {
            if (txtUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid Username please!");
                return false;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a valid Password please!");
                return false;
            }
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (IsValid())
                {
                    using (SqlConnection conn = new SqlConnection(@""))
                    {
                        SqlDataAdapter sdadapter = new SqlDataAdapter("SELECT Username, Password  FROM Login WHERE Username ='" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'", conn);
                    DataTable datatable = new DataTable();
                    sdadapter.Fill(datatable);
                    if (datatable.Rows.Count == 1)
                    {
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Show();
                    }
                    }
                }
        }
    }
}
