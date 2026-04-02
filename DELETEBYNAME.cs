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
    public partial class DELETEBYNAME : Form
    {
        String constr = @"Data Source=.\SQLEXPRESS; Initial Catalog=stude; Integrated Security=true";
        public DELETEBYNAME()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            label2.Visible = false;
        }

        private void DELETEBYNAME_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @"select count(*) from Student where name=@name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name",name);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count== 0)
                {
                    MessageBox.Show("student not found");
                }
                else if(count==1)
                {
                    string deletequery = @"DELETE FROM Student where name=@name";
                    SqlCommand delcmd = new SqlCommand(deletequery, con);
                    delcmd.Parameters.AddWithValue("@name",name);
                    delcmd.ExecuteNonQuery();
                    MessageBox.Show("student data deleted sucessfully");
                }
                else
                {
                    MessageBox.Show("multiple record found");
                    string distquery =@"select DISTINCT COURSE FROM Student where name=@name";
                    if (count > 1)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(distquery, con);
                        da.SelectCommand.Parameters.AddWithValue("@name", name);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "course";
                        comboBox1.ValueMember = "course";
                        comboBox1.Visible = true;
                        label2.Visible = true;
                    }
                }
            }
        }
    }
}
