using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shop_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\database2.mdf;Integrated Security=True;Connect Timeout=30");
            // SqlConnection cn = new SqlConnection();
            // cn.ConnectionString = "Data Source=.\SQLEXPRESS;" + "Initial Catalog=DataBaseName;" + "User id=UserName;" + "Password=Secret;";
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into stu values ('" + id.Text + "', '" + name.Text + "', '" + intake.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            SqlCommand cmd1 = new SqlCommand("select * from stu", cn);
    
            string query = "select * from stu";
            SqlCommand oCmd = new SqlCommand(query, cn);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
     
                while (oReader.Read())
                {
                    string a = oReader["id"].ToString();
                    string b = oReader["name"].ToString();
                    string c = oReader["intake"].ToString();
                    MessageBox.Show(a);
                    MessageBox.Show(b);
                    MessageBox.Show(c);

                }

                cn.Close();
            }

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
