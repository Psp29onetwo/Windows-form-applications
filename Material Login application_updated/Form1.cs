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

namespace Material_Login_application
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            materialLabel1.Parent = pictureBox1;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.ForeColor = Color.White;
            materialLabel1.Font = new Font(FontFamily.GenericSansSerif, 24.0F, FontStyle.Bold);

           
            materialLabel4.BackColor = Color.Transparent;
            materialLabel4.ForeColor = Color.FromArgb(18, 69, 156);
            materialLabel4.Font = new Font(FontFamily.GenericSansSerif, 24.0F, FontStyle.Bold);

            materialLabel5.BackColor = Color.Transparent;
            materialLabel6.BackColor = Color.Transparent;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void materialFlatButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\all about learning\computer science\codes\visual studio codes\Material Login application\login_db.mdf; Integrated Security = True; ";
            con.Open();
            string userid = materialSingleLineTextField1.Text;
            
            string password = materialSingleLineTextField2.Text;
            SqlCommand cmd = new SqlCommand("select username,password from login where username='" + materialSingleLineTextField1.Text + "'and password='" + materialSingleLineTextField2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Welcome psp = new Welcome();
                psp.Show();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        
            
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1920, 1440);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
