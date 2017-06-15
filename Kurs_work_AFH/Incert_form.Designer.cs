namespace Kurs_work_AFH
{
    partial class Insert_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Type_of_activ_comboBox = new System.Windows.Forms.ComboBox();
            this.Maker_comboBox = new System.Windows.Forms.ComboBox();
            this.Enter_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Add_row_button = new System.Windows.Forms.Button();
            this.Product_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Price_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Quantity_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите информацию о продукте :";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(136, 88);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(139, 20);
            this.Name_textBox.TabIndex = 2;
            // 
            // Type_of_activ_comboBox
            // 
            this.Type_of_activ_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_of_activ_comboBox.FormattingEnabled = true;
            this.Type_of_activ_comboBox.Items.AddRange(new object[] {
            "Овощеводство",
            "Пчеловодство",
            "Животноводство",
            "Садоводство",
            "Зерновые",
            "Виноградарство"});
            this.Type_of_activ_comboBox.Location = new System.Drawing.Point(134, 127);
            this.Type_of_activ_comboBox.Name = "Type_of_activ_comboBox";
            this.Type_of_activ_comboBox.Size = new System.Drawing.Size(139, 21);
            this.Type_of_activ_comboBox.TabIndex = 3;
            // 
            // Maker_comboBox
            // 
            this.Maker_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Maker_comboBox.FormattingEnabled = true;
            this.Maker_comboBox.Items.AddRange(new object[] {
            "Агрофорт",
            "Симфо",
            "Колос",
            "Эдельвейс",
            "Байрон Агро",
            "Винофорт"});
            this.Maker_comboBox.Location = new System.Drawing.Point(135, 198);
            this.Maker_comboBox.Name = "Maker_comboBox";
            this.Maker_comboBox.Size = new System.Drawing.Size(139, 21);
            this.Maker_comboBox.TabIndex = 5;
            // 
            // Enter_dateTimePicker
            // 
            this.Enter_dateTimePicker.Location = new System.Drawing.Point(135, 271);
            this.Enter_dateTimePicker.Name = "Enter_dateTimePicker";
            this.Enter_dateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.Enter_dateTimePicker.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Название продукта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вид отрасли";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Цена продукта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Производитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Колличество продукта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = " (кг/шт)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата завоза на склад";
            // 
            // Add_row_button
            // 
            this.Add_row_button.Location = new System.Drawing.Point(18, 299);
            this.Add_row_button.Name = "Add_row_button";
            this.Add_row_button.Size = new System.Drawing.Size(255, 30);
            this.Add_row_button.TabIndex = 8;
            this.Add_row_button.Text = "Добавить";
            this.Add_row_button.UseVisualStyleBackColor = true;
            this.Add_row_button.Click += new System.EventHandler(this.Add_row_button_Click);
            // 
            // Product_maskedTextBox
            // 
            this.Product_maskedTextBox.Location = new System.Drawing.Point(134, 52);
            this.Product_maskedTextBox.Mask = "00000";
            this.Product_maskedTextBox.Name = "Product_maskedTextBox";
            this.Product_maskedTextBox.Size = new System.Drawing.Size(141, 20);
            this.Product_maskedTextBox.TabIndex = 0;
            this.Product_maskedTextBox.ValidatingType = typeof(int);
            // 
            // Price_maskedTextBox
            // 
            this.Price_maskedTextBox.Location = new System.Drawing.Point(135, 163);
            this.Price_maskedTextBox.Mask = "00000";
            this.Price_maskedTextBox.Name = "Price_maskedTextBox";
            this.Price_maskedTextBox.Size = new System.Drawing.Size(141, 20);
            this.Price_maskedTextBox.TabIndex = 4;
            this.Price_maskedTextBox.ValidatingType = typeof(int);
            // 
            // Quantity_maskedTextBox
            // 
            this.Quantity_maskedTextBox.Location = new System.Drawing.Point(134, 231);
            this.Quantity_maskedTextBox.Mask = "0000000";
            this.Quantity_maskedTextBox.Name = "Quantity_maskedTextBox";
            this.Quantity_maskedTextBox.Size = new System.Drawing.Size(141, 20);
            this.Quantity_maskedTextBox.TabIndex = 6;
            // 
            // Insert_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 334);
            this.Controls.Add(this.Quantity_maskedTextBox);
            this.Controls.Add(this.Price_maskedTextBox);
            this.Controls.Add(this.Product_maskedTextBox);
            this.Controls.Add(this.Add_row_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter_dateTimePicker);
            this.Controls.Add(this.Maker_comboBox);
            this.Controls.Add(this.Type_of_activ_comboBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Insert_form";
            this.Text = "AgroAssociationPro 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.ComboBox Type_of_activ_comboBox;
        private System.Windows.Forms.ComboBox Maker_comboBox;
        private System.Windows.Forms.DateTimePicker Enter_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Add_row_button;
        private System.Windows.Forms.MaskedTextBox Product_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox Price_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox Quantity_maskedTextBox;
    }
}