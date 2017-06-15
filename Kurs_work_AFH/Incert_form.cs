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
    public partial class Insert_form : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ZELENSKYI\SQLEXPRESS;Initial Catalog=AgroAssociation;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        
        public Insert_form()
        {
            InitializeComponent();
           
        }

        private void Add_row_button_Click(object sender, EventArgs e)
        {

            Add_Product_row();
            Add_Vurobka_row();
            Add_Result_row();

            Name_textBox.Clear();
            Type_of_activ_comboBox.SelectedIndex = -1;
            Maker_comboBox.SelectedIndex = -1;
            Product_maskedTextBox.Clear();
            Quantity_maskedTextBox.Clear();
            Price_maskedTextBox.Clear();
            Enter_dateTimePicker.Value = DateTime.Now;


            
        }

        private void Add_Product_row()
        {
            int Type_of_activity = Type_of_activ_comboBox.SelectedIndex + 1;

            try
            {
                SqlCommand command = new SqlCommand(@"insert into Product 
                                        values (" + Product_maskedTextBox.Text + "," + Type_of_activity + ",'" + Name_textBox.Text + "')", connection);

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Продукт был успешно добавлен в базу данных", "AgroAssociationPro 1.0");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Продукт с таким номером уже существует, пожалуйста, введите другой номер.", "AgroAssociationPro 1.0");
                Product_maskedTextBox.Clear();
            }
            finally
            {
                connection.Close();

            }
        }

        private void Add_Vurobka_row()
        {
            int Khoze_num = Maker_comboBox.SelectedIndex + 1;

            try
            {
                SqlCommand command = new SqlCommand(@"insert into Vurobka 
                                     values (" + Product_maskedTextBox.Text + "," + Product_maskedTextBox.Text + "," + Price_maskedTextBox.Text + "," + Khoze_num + ")", connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "AgroAssociationPro 1.0");
            }
            finally
            {
                connection.Close();
            }
        }
        private void Add_Result_row()
        {
            try
            {
                SqlCommand command = new SqlCommand(@"insert into Result 
                                     values (" + Product_maskedTextBox.Text + "," + Quantity_maskedTextBox.Text + ",'" + Enter_dateTimePicker.Value + "')", connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "AgroAssociationPro 1.0");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
