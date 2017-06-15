namespace Kurs_work_AFH
{
    partial class AgroAsociation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.agroAssociationDataSet = new Kurs_work_AFH.AgroAssociationDataSet();
            this.agroAssociationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Incert_button = new System.Windows.Forms.Button();
            this.Price_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price_down_button = new System.Windows.Forms.Button();
            this.Price_up_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantity_update_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Quantity_update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agroAssociationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agroAssociationDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(445, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,Admin";
            // 
            // agroAssociationDataSet
            // 
            this.agroAssociationDataSet.DataSetName = "AgroAssociationDataSet";
            this.agroAssociationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agroAssociationDataSetBindingSource
            // 
            this.agroAssociationDataSetBindingSource.DataSource = this.agroAssociationDataSet;
            this.agroAssociationDataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 460);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Quantity_update_button);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Quantity_update_maskedTextBox);
            this.tabPage1.Controls.Add(this.Update_button);
            this.tabPage1.Controls.Add(this.Price_up_button);
            this.tabPage1.Controls.Add(this.Price_down_button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Price_maskedTextBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Delete_button);
            this.tabPage1.Controls.Add(this.Incert_button);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Редактирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(596, 292);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите название продукта";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(13, 48);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(149, 38);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "Удалить продукт";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Incert_button
            // 
            this.Incert_button.Location = new System.Drawing.Point(13, 92);
            this.Incert_button.Name = "Incert_button";
            this.Incert_button.Size = new System.Drawing.Size(149, 38);
            this.Incert_button.TabIndex = 1;
            this.Incert_button.Text = "Добавить новый продукт";
            this.Incert_button.UseVisualStyleBackColor = true;
            this.Incert_button.Click += new System.EventHandler(this.Incert_button_Click);
            // 
            // Price_maskedTextBox
            // 
            this.Price_maskedTextBox.Location = new System.Drawing.Point(196, 21);
            this.Price_maskedTextBox.Mask = "0000";
            this.Price_maskedTextBox.Name = "Price_maskedTextBox";
            this.Price_maskedTextBox.Size = new System.Drawing.Size(213, 20);
            this.Price_maskedTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "На сколько нужно изменить цену товара";
            // 
            // Price_down_button
            // 
            this.Price_down_button.Location = new System.Drawing.Point(307, 48);
            this.Price_down_button.Name = "Price_down_button";
            this.Price_down_button.Size = new System.Drawing.Size(105, 25);
            this.Price_down_button.TabIndex = 10;
            this.Price_down_button.Text = "Уменьшить цену";
            this.Price_down_button.UseVisualStyleBackColor = true;
            this.Price_down_button.Click += new System.EventHandler(this.Price_down_button_Click);
            // 
            // Price_up_button
            // 
            this.Price_up_button.Location = new System.Drawing.Point(196, 47);
            this.Price_up_button.Name = "Price_up_button";
            this.Price_up_button.Size = new System.Drawing.Size(105, 25);
            this.Price_up_button.TabIndex = 11;
            this.Price_up_button.Text = "Увеличить цену";
            this.Price_up_button.UseVisualStyleBackColor = true;
            this.Price_up_button.Click += new System.EventHandler(this.Price_up_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(505, 93);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(110, 37);
            this.Update_button.TabIndex = 12;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сколько товара Вы хотите доставить на склад";
            // 
            // Quantity_update_maskedTextBox
            // 
            this.Quantity_update_maskedTextBox.Location = new System.Drawing.Point(196, 101);
            this.Quantity_update_maskedTextBox.Mask = "000000";
            this.Quantity_update_maskedTextBox.Name = "Quantity_update_maskedTextBox";
            this.Quantity_update_maskedTextBox.Size = new System.Drawing.Size(213, 20);
            this.Quantity_update_maskedTextBox.TabIndex = 13;
            // 
            // Quantity_update_button
            // 
            this.Quantity_update_button.Location = new System.Drawing.Point(415, 99);
            this.Quantity_update_button.Name = "Quantity_update_button";
            this.Quantity_update_button.Size = new System.Drawing.Size(84, 25);
            this.Quantity_update_button.TabIndex = 15;
            this.Quantity_update_button.Text = "Доставить";
            this.Quantity_update_button.UseVisualStyleBackColor = true;
            this.Quantity_update_button.Click += new System.EventHandler(this.Quantity_update_button_Click);
            // 
            // AgroAsociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "AgroAsociation";
            this.Text = "AgroAssociationPro 1.0";
            this.Load += new System.EventHandler(this.AgroAsociation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agroAssociationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agroAssociationDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource agroAssociationDataSetBindingSource;
        private AgroAssociationDataSet agroAssociationDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Incert_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Price_down_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Price_maskedTextBox;
        private System.Windows.Forms.Button Price_up_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Quantity_update_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Quantity_update_maskedTextBox;
    }
}