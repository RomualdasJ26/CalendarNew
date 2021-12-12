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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCnnct = new SqlConnection(@""))
            {
                sqlCnnct.Open();
                SqlCommand sqlCmmnd = new SqlCommand("PridetiEvent", sqlCnnct);
                sqlCmmnd.CommandType = CommandType.StoredProcedure;
                sqlCmmnd.Parameters.AddWithValue("@date", txdate.Text);
                sqlCmmnd.Parameters.AddWithValue("@name", txevent.Text);
                MessageBox.Show("Event created:");
                sqlCmmnd.ExecuteNonQuery();
                this.Hide();
                txdate.Text = "";
                txevent.Text = "";
            }
        }

        private void Event_Load(object sender, EventArgs e)
        {
            txdate.Text = Form1.static_year + "/" + Form1.static_month+ "/"+ UserControlDays.static_day;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
