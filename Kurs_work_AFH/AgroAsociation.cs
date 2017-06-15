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
    public partial class AgroAsociation : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ZELENSKYI\SQLEXPRESS;Initial Catalog=AgroAssociation;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

        public AgroAsociation()
        {
            InitializeComponent();

            ActiveControl = textBox1;
            textBox1.Focus();

        }

        private void AgroAsociation_Load(object sender, EventArgs e)
        {
        }

        private void Incert_button_Click(object sender, EventArgs e)
        {
            Insert_form In_Form = new Insert_form();
            In_Form.Show();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

            delete_Result();
            delete_Vurobka();
            Delete_Product();

            textBox1.Clear();
            MessageBox.Show("Результат операции можно увидеть в таблице ниже", "AgroAssociationPro 1.0");

            connection.Open();
            DataSet dSet = new DataSet();
            DataTable Product_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product,Khoz_name,Incoming_capacity,Incoming_date,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka", connection);
            DataAdapter.Fill(dSet, "Product_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "Product_Info";
            connection.Close();
        }
        /// ////////////////////////////////////////////////////////////////
        private void delete_Result()
        {

            SqlCommand command = new SqlCommand(@"delete Result
                                                  Where Num_vurobka in (Select Num_of_product 
                                                                       from Product 
                                                                       where Name_of_product like '" + textBox1.Text + "') ", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// ////////////////////////////////////////////////////////////////
        private void delete_Vurobka()
        {

            SqlCommand command = new SqlCommand(@"delete Vurobka
                                                      where Num_vurobka in (Select Num_of_product 
                                                                                from Product 
                                                                                where Name_of_product like '" + textBox1.Text + "')", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }



        /// ////////////////////////////////////////////////////////////////

        private void Delete_Product()
        {

            SqlCommand command = new SqlCommand(@"delete Product
                                                      Where Name_of_product like '" + textBox1.Text + "'", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }



        private void Price_up_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Вы не указали имя продукта, цену которого хотите изменить.", "AgroAssociationPro 1.0"); }
            if (Price_maskedTextBox.Text == "")
            { MessageBox.Show("Вы не указали значение, на которое будет изменена цена продукта.", "AgroAssociationPro 1.0"); }
            else
            {
                int param = Int32.Parse(Price_maskedTextBox.Text);
                try
                {

                    SqlCommand command = new SqlCommand(@"Update Vurobka
                                                      set Price_of_product = Price_of_product+@param
                                                      Where Num_of_product in (Select Num_of_product 
                                                                                from Product
                                                                                where Name_of_product like '" + textBox1.Text + "')", connection);
                    command.Parameters.Add("@param", param);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Цена была успешно изменена!", "AgroAssociationPro 1.0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            connection.Open();
            DataSet dSet = new DataSet();
            DataTable Product_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product,Khoz_name,Incoming_capacity,Incoming_date,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka", connection);
            DataAdapter.Fill(dSet, "Product_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "Product_Info";
            connection.Close();
        }

        private void Price_down_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Вы не указали имя продукта, цену которого хотите изменить.", "AgroAssociationPro 1.0"); }
            if (Price_maskedTextBox.Text == "")
            { MessageBox.Show("Вы не указали значение, на которое будет изменена цена продукта.", "AgroAssociationPro 1.0"); }
            else
            {
                int param = Int32.Parse(Price_maskedTextBox.Text);
                try
                {

                    SqlCommand command = new SqlCommand(@"Update Vurobka
                                                      set Price_of_product = Price_of_product-@param
                                                      Where Num_of_product in (Select Num_of_product 
                                                                                from Product
                                                                                where Name_of_product like '" + textBox1.Text + "')", connection);
                    command.Parameters.Add("@param", param);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Цена была успешно изменена!", "AgroAssociationPro 1.0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Цена продукта не может быть меньше нуля!", "AgroAssociationPro 1.0");
                }
                finally
                {
                    connection.Close();
                }
            }
            connection.Open();
            DataSet dSet = new DataSet();
            DataTable Product_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product,Khoz_name,Incoming_capacity,Incoming_date,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka", connection);
            DataAdapter.Fill(dSet, "Product_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "Product_Info";
            connection.Close();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataSet dSet = new DataSet();
            DataTable Product_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product,Khoz_name,Incoming_capacity,Incoming_date,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka", connection);
            DataAdapter.Fill(dSet, "Product_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "Product_Info";
            connection.Close();
        }

        private void Quantity_update_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Вы не указали имя продукта, который пришёл на склад.", "AgroAssociationPro 1.0"); }
            if (Quantity_update_maskedTextBox.Text == "")
            { MessageBox.Show("Вы не указали значение, на которое будет изменено количество продукта на складе.", "AgroAssociationPro 1.0"); }
            else
            {
                int paramUp = Int32.Parse(Quantity_update_maskedTextBox.Text);
                try
                {

                    SqlCommand command = new SqlCommand(@"Update Result
                                                          set Incoming_capacity = Incoming_capacity+@paramUp
                                                          Where Num_vurobka in (Select Num_of_product 
                                                                                from Product
                                                                                where Name_of_product like '" + textBox1.Text + "')", connection);
                    command.Parameters.Add("@paramUp", paramUp);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар был успешно доставлен на склад!", "AgroAssociationPro 1.0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Цена продукта не может быть меньше нуля!", "AgroAssociationPro 1.0");
                }
                finally
                {
                    connection.Close();
                }
            }
            connection.Open();
            DataSet dSet = new DataSet();
            DataTable Product_Info = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(@"Select Name_of_product,Khoz_name,Incoming_capacity,Incoming_date,Price_of_product
                                                              From Ferm_khoz inner join Vurobka on Ferm_khoz.Khoz_num = Vurobka.Khoz_num 
                                                              inner join Product on Vurobka.Num_of_product = Product.Num_of_product
                                                              inner join Result on Vurobka.Num_vurobka = Result.Num_vurobka", connection);
            DataAdapter.Fill(dSet, "Product_Info");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "Product_Info";
            connection.Close();
        }


    }
}

