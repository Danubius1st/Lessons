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
using Login.Properties;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string cmd = "Select Count(*) From Login where Username=='" + textBox_Username + "' and Password='" +
                         textBox_Password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                Main mw = new Main();
                mw.Show();
            }
            else
            {
                MessageBox.Show(Resources.Form1_button_Login_Click_Please_Check_your_Username_ans_Password);
            }
            
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }
    }
}
