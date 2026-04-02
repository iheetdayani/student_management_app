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
    public partial class Liststudent : Form
    {
        String constr = @"Data Source=.\SQLEXPRESS; Initial Catalog=stude; Integrated Security=true";
        public Liststudent()
        {
            InitializeComponent();
        }

        private void Liststudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                string query = @"select * from Student where YEAR(dob)=@dob";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@dob",Convert.ToInt32(textBox1.Text));
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
