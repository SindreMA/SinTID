using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace SinTID
{
    public partial class SinTid : Form
    {
        public SinTid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loa1d();
        }
        public void Loa1d()
        {
            lables();
            string connectionString;
            connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=#########;password=################";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlWeek = "SELECT Week from palogging";
                var cmd = new MySqlCommand(sqlWeek, connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!comboBox1.Items.Contains(reader.GetString("week")))
                    {
                        comboBox1.Items.Add(reader.GetString("week"));
                    }
                    else { }
                }
            }
            catch { MessageBox.Show("Error"); }

            var culture = CultureInfo.GetCultureInfo("cs-CZ");
            var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

            var dateTime = DateTime.Today;

            int weekNumber = culture.Calendar.GetWeekOfYear(dateTime, dateTimeInfo.CalendarWeekRule, dateTimeInfo.FirstDayOfWeek);

            comboBox1.Text = weekNumber.ToString();
            try { inn(); } catch { }
            try { ut(); } catch { }
        }
        private void button_LoggInn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=##########;password=################";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand mcd;
                string s;
                string time1 = DateTime.Now.ToShortTimeString().Replace(".", ",");
                Decimal timedec = Decimal.Parse(time1);
                Decimal femmin = Decimal.Parse("00,03");
                Decimal sumdec = timedec - femmin;
                string time = sumdec.ToString().Replace(",", ".");
                string date = DateTime.Now.ToShortDateString();
                string day = DateTime.Now.DayOfWeek.ToString();

                var culture = CultureInfo.GetCultureInfo("cs-CZ");
                var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

                var dateTime = DateTime.Today;

                int weekNumber = culture.Calendar.GetWeekOfYear(dateTime, dateTimeInfo.CalendarWeekRule, dateTimeInfo.FirstDayOfWeek);

                string inorout = "In";
                s = "INSERT INTO `palogging` (`Time`, `Date`, `Day`, `Week`, `Status`) VALUES('" + time + "', '" + date + "', '" + day + "', '" + weekNumber + "', '" + inorout + "');";
                connection.Open();
                cmd = new MySqlCommand(s, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                connection.CloseAsync();

                list();
                inn();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void button_LoggUt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=########;password=##########";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand mcd;
                string s;
                string time = DateTime.Now.ToShortTimeString();
                string date = DateTime.Now.ToShortDateString();
                string day = DateTime.Now.DayOfWeek.ToString();

                var culture = CultureInfo.GetCultureInfo("cs-CZ");
                var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

                var dateTime = DateTime.Today;

                int weekNumber = culture.Calendar.GetWeekOfYear(dateTime, dateTimeInfo.CalendarWeekRule, dateTimeInfo.FirstDayOfWeek);

                //string week = WeeksInYear1. .ToString();
                string inorout = "Out";
                s = "INSERT INTO `palogging` (`Time`, `Date`, `Day`, `Week`, `Status`) VALUES('" + time + "', '" + date + "', '" + day + "', '" + weekNumber + "', '" + inorout + "');";
                connection.Open();
                cmd = new MySqlCommand(s, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                connection.CloseAsync();

                list();
                ut();
            }
            catch { MessageBox.Show("Error"); }
        }

        public void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            list();
        }

        private void button_NesteUke_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(comboBox1.Text);
            int s = c + 1;
            comboBox1.Text = s.ToString();
        }

        private void button_Forje_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(comboBox1.Text);
            int s = c - 1;
            comboBox1.Text = s.ToString();
        }
        public void list()
        {
            string connectionString;
            connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=##############;password=################";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string command = "SELECT time,date,day,Status FROM palogging WHERE week = '" + comboBox1.Text + "' ;";

            try
            {

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(command, connection);
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridView1.DataSource = bSource;
            }
            catch { }

        }
        public void inn()
        {
            string connectionString;
            connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=#############;password=################";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                string status = "In";
                connection.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlWeek = "SELECT date,time from palogging where status = '" + status + "';";
                var cmd = new MySqlCommand(sqlWeek, connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader.GetString("date")) == DateTime.Now.ToShortDateString())
                    {
                        label_innidag_value.Text = (reader.GetString("time"));
                    }
                    else { }
                }
            }
            catch { }
        }
        public void ut()
        {
            string connectionString;
            connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=############;password=#######";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                string status = "Out";
                connection.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlWeek = "SELECT date,time from palogging where status = '" + status + "';";
                var cmd = new MySqlCommand(sqlWeek, connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader.GetString("date")) == DateTime.Now.ToShortDateString())
                    {
                        label_utidag_value.Text = (reader.GetString("time"));
                    }
                    else { }
                }
            }
            catch { }
        }
        public TimeSpan ts;

        public void ptid()
        {
            try
            {
                string intime = label_innidag_value.Text.ToString().Replace(".", ":");
                DateTime when = DateTime.Parse(intime);
                TimeSpan ts = DateTime.Now.Subtract(when);
                label_PåloggetTid_value.Text = ts.Hours.ToString() + " Timer &" + ts.Minutes.ToString() + " Minuter";
            }
            catch { }
        }

        public void otid()
        {
            try
            {
                string hei = label_PåloggetTid_value.Text.Remove(1);
                int heiint = int.Parse(hei);
                if (heiint > 8)
                {
                    string intime = label_innidag_value.Text.ToString().Replace(".", ":");
                    DateTime when = DateTime.Parse(intime);
                    TimeSpan ts1 = DateTime.Now.Subtract(when);

                    //if (ts.Hours > TimeSpan.Parse())
                    //{
                    string hpr = ts1.Hours.ToString();
                    Int32 cx = Int32.Parse(hpr);
                    int c = 8;
                    int ts2 = c - cx;
                    string ts2s = ts2.ToString().Replace("-", "");

                    string hprm = ts1.Minutes.ToString();
                    //Int32 ccx = Int32.Parse(hprm);
                    //int cc = 8;
                    //int tsc2 = cc - ccx;
                    string tot = label_OverTId_value.Text = ts2s + " Timer " + hprm + " Minuter".Replace("-", "");
                    label_OverTId_value.Text = tot;

                }
                else { }

                //}
                //else { label_OverTId_value.Text = "0"; }

                //label_OverTId_value.Text = ts.Hours.ToString() + " Timer &" + ts.Minutes.ToString() + " Minuter";

                if (DateTime.Now.ToShortTimeString() == "00.00  ")
                {
                    label_innidag_value.ResetText(); label_OverTId_value.ResetText(); label_utidag_value.ResetText(); label_PåloggetTid_value.ResetText();
                }
            }
            catch { }
        }
        public void lables()
        {
            if (label_innidag_value.Text == "")
            {
                string connectionString;
                connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=############;password=#######";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    MySqlDataAdapter MyDA = new MySqlDataAdapter();
                    string sqlWeek = "SELECT time from palogging WHERE date='" + DateTime.Now.ToShortDateString() + "' and status='in'";
                    var cmd = new MySqlCommand(sqlWeek, connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        label_innidag_value.Text = (reader.GetString("time"));
                    }


                }
                catch { }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ptid();
            otid();
            lables();
            
      
                }

    }


}
