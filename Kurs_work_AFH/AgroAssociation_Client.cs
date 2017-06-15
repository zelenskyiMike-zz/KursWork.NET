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


namespace Kurs_work_AFH
{
    public partial class AgroAssociation_Client : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ZELENSKYI\SQLEXPRESS;Initial Catalog=AgroAssociation;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        

        public AgroAssociation_Client()
        {
            InitializeComponent();
            ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void AgroAssociation_Client_Load(object sender, EventArgs e)
        {

        }

        private void All_Statistic_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataSet dSet = new DataSet();
            DataTable All_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Distinct Ferm_khoz.Khoz_num,Khoz_name,Reg_name,City_name,Adress,Name_of_type,Phone_num 
                                                              From Ferm_khoz inner join City on City.City_num = Ferm_khoz.City_num 
                                                              inner join Region on Region.Reg_number = City.Reg_number
                                                              inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Type_of_activity on Type_of_activity.Num_of_type = Product.Num_of_type 
                                                              inner join Telephone on Ferm_khoz.Khoz_num = Telephone.Khoz_num", connection);
            DataAdapter.Fill(dSet, "All_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "All_Info";
            connection.Close();

        }
        private void Product_inf_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Вы не указали назание продукта, информацию о котором хотели бы найти", ""); }
            else
            {
                connection.Open();
                DataSet dSet = new DataSet();
                DataTable Product_Info = new DataTable();
                SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product,Khoz_name,Incoming_capacity,Incoming_date,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka
                                                              Where Name_of_product like '%" + textBox1.Text + "%'", connection);
                DataAdapter.Fill(dSet, "Product_Info");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dSet;
                dataGridView1.DataMember = "Product_Info";
                connection.Close();
            }

        }

        private void All_Ferm_button_Click(object sender, EventArgs e)
        {
            int ComBox = Ferm_comboBox.SelectedIndex + 1;
            connection.Open();
            DataSet datSet = new DataSet();
            DataTable One_Ferm_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Ferm_khoz.Khoz_num,Khoz_name,Name_of_product,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              Where Ferm_khoz.Khoz_num like '" + ComBox + "'", connection);
            DataAdapter.Fill(datSet, "One_Ferm_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datSet;
            dataGridView1.DataMember = "One_Ferm_Info";
            connection.Close();
        }

        private void MaxPriceButton_Click(object sender, EventArgs e)
        {
            int ComBox = Ferm_comboBox.SelectedIndex + 1;
            connection.Open();
            DataSet datSet = new DataSet();
            DataTable MaxPrice = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product , Price_of_product
                                                              from Vurobka inner join Product on Product.Num_of_product = Vurobka.Num_of_product
                                                              Where Price_of_product in (Select max(Price_of_product) from Vurobka)", connection);
            DataAdapter.Fill(datSet, "MaxPrice");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datSet;
            dataGridView1.DataMember = "MaxPrice";
            connection.Close();
        }

        private void MinPriceButton_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            DataSet datSet = new DataSet();
            DataTable MaxPrice = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product , Price_of_product
                                                              from Vurobka inner join Product on Product.Num_of_product = Vurobka.Num_of_product
                                                              Where Price_of_product in (Select min(Price_of_product) from Vurobka)", connection);
            DataAdapter.Fill(datSet, "MaxPrice");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datSet;
            dataGridView1.DataMember = "MaxPrice";
            connection.Close();
        }

        private void MinCountButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataSet datSet = new DataSet();
            DataTable MinCount = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product , Incoming_capacity
                                                              from Vurobka inner join Product on Product.Num_of_product = Vurobka.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka
                                                              Where Incoming_capacity in (Select min(Incoming_capacity) from Result)", connection);
            DataAdapter.Fill(datSet, "MinCount");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datSet;
            dataGridView1.DataMember = "MinCount";
            connection.Close();
        }

        private void FreshProductButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataSet datSet = new DataSet();
            DataTable FreshProduct = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product , Incoming_date
                                                              from Vurobka inner join Product on Product.Num_of_product = Vurobka.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka
                                                              Where Incoming_date in (Select min(Incoming_date) from Result)", connection);
            DataAdapter.Fill(datSet, "FreshProduct");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datSet;
            dataGridView1.DataMember = "FreshProduct";
            connection.Close();
        }
    }
}
