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
    public partial class ADDSTUDENT : Form
    {
        String constr = @"Data Source=.\SQLEXPRESS; Initial Catalog=stude; Integrated Security=true";
        public ADDSTUDENT()
        {
            InitializeComponent();
            loadcourse();
        }
        private void loadcourse()
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                String query = @"select * from Course";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.ValueMember = "cours_id";
                comboBox2.DisplayMember = "course_name";
            }
        }
        private void loadclass(int course_id)
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                string query = @"select * from Class where course_id=@course_id";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@course_id", course_id);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "class_name";
                comboBox1.ValueMember = "class_id";
            }
        }
        private void ADDSTUDENT_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                string query = @"insert into Student(ernollno,rollno,name,class_id,course,email,mobile,dob)values(@ernollno,@rollno,@name,@class_id,@course,@email,@mobile,@dob)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ernollno", Convert.ToInt32(txtenroll.Text));
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtrollno.Text));
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@class_id",comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@course", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("student register sucessfully");
                }
                else
                {
                    MessageBox.Show("error while inserting student records");
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null && comboBox2.SelectedValue is int)
            {
                loadclass((int)comboBox2.SelectedValue);
            }
        }
    }
}
