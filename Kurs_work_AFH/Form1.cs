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
using System.Data;
using System.Windows;

namespace Kurs_work_AFH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ZELENSKYI\SQLEXPRESS;Initial Catalog=Login_DB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("Select Role from Login where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'  ", connection);
                DataTable LoginTable = new DataTable();

                DataAdapter.Fill(LoginTable);

                if (LoginTable.Rows[0][0].ToString() == "Admin")
                {
                    AgroAsociation AA_Form = new AgroAsociation();
                    this.Hide();
                    AA_Form.ShowDialog();
                    this.Show();
                }
                else
                {
                    AgroAssociation_Client AA_Form_Client = new AgroAssociation_Client();
                    this.Hide();
                    AA_Form_Client.ShowDialog();
                    this.Show();
                }


                textBox1.Clear();
                textBox2.Clear();
                
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные. Пожалyйста, проверьте правильность ввода и попробуйте войти ещё раз","AgroAssociationPro 1.0");
                
            }

        }
    }
}
