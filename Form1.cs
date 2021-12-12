using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendoriausprojektas
{
    public partial class Form1 : Form
    {
        int month, year;
        public static int static_month, static_year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
            UserControlDays ucd = new UserControlDays();
            ucd.displayEvent();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String menesiopav = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdata.Text = menesiopav + " " + year;


            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(now.Year, now.Month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            for(int i=1;i<dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                formDays.Controls.Add(ucblank);
            }
            for(int i=1; i<= days;i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                formDays.Controls.Add(ucdays);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnMen1_Click(object sender, EventArgs e)
        {
            UserControlDays ucd = new UserControlDays();
            ucd.displayEvent();
            formDays.Controls.Clear();
            if (month != 1)
            {
                month--;
                static_month = month;
                static_year = year;

            }
            else
            {
                month = 12;
                year--;
            }
            String menesiopav = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdata.Text = menesiopav + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                formDays.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                formDays.Controls.Add(ucdays);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dienos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMen2_Click(object sender, EventArgs e)
        {
            formDays.Controls.Clear();
            UserControlDays ucd = new UserControlDays();
            ucd.displayEvent();
            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
                static_month = month;
                static_year = year;

            }
            String menesiopav = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdata.Text = menesiopav + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
 
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //Panaikinti+1 vėliau
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                formDays.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                formDays.Controls.Add(ucdays);
            }
        }
    }
}
