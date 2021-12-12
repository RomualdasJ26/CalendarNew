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
    public partial class UserControlDays : UserControl
    {
        public static String static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            Event eventform = new Event();
            eventform.Show();
        }
        public void displayEvent()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\romua\source\repos\Kalendoriausprojektas\Kalendoriausprojektas\Database1.mdf;Integrated Security=True");
            conn.Open();
            String sql = "SELECT * FROM Event where date = @date";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@date", Form1.static_year + "/" + Form1.static_month + "/"+lbdays.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                lbevent.Text = reader["name"].ToString();
            }
           /* reader.Dispose();
            cmd.Dispose();*/
            conn.Close();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void labeldate_Click(object sender, EventArgs e)
        {

        }
    }
}
