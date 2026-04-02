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
namespace EXAM_APP
{
    public partial class Updatestudent : Form
    {
        String constr = @"Data Source=.\SQLEXPRESS; Initial Catalog=stude; Integrated Security=true";
        public Updatestudent()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                string query = @"select ernollno,email,mobile,dob from Student where ernollno=@ernollno";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ernollno", Convert.ToInt32(textBox1.Text));
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr["ernollno"].ToString();
                    textBox2.Text = dr["email"].ToString();
                    textBox3.Text = dr["mobile"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr["dob"].ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Updatestudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           using(SqlConnection con=new SqlConnection(constr))
            {
                string query = @"update Student SET email=@email,
                              mobile=@mobile,
                              dob=@dob  where ernollno=@ernollno";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("ernollno", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@email", textBox2.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("email,mobile,dob updated sucessfully");
                }
                else
                {
                    MessageBox.Show("error while update the data");
                }
            }
        }
    }
}
