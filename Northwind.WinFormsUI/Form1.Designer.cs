
namespace Northwind.WinFormsUI
{
    partial class Form1
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
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.groupBox_Category = new System.Windows.Forms.GroupBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.groupBox_Product = new System.Windows.Forms.GroupBox();
            this.textBox_Product = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Add_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UnitsInStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_QuantityPerUnit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Update_QuantityPerUnit = new System.Windows.Forms.TextBox();
            this.textBox_Update_UnitsInStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Update_UnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Update_Category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Update_ProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.groupBox_Category.SuspendLayout();
            this.groupBox_Product.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Location = new System.Drawing.Point(12, 190);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.Size = new System.Drawing.Size(776, 248);
            this.dataGridView_Products.TabIndex = 0;
            this.dataGridView_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_CellClick);
            // 
            // groupBox_Category
            // 
            this.groupBox_Category.Controls.Add(this.comboBox_Category);
            this.groupBox_Category.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Category.Name = "groupBox_Category";
            this.groupBox_Category.Size = new System.Drawing.Size(776, 73);
            this.groupBox_Category.TabIndex = 1;
            this.groupBox_Category.TabStop = false;
            this.groupBox_Category.Text = "Kategoriye göre ara";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(87, 19);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(269, 21);
            this.comboBox_Category.TabIndex = 0;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // groupBox_Product
            // 
            this.groupBox_Product.Controls.Add(this.button_Delete);
            this.groupBox_Product.Controls.Add(this.textBox_Product);
            this.groupBox_Product.Location = new System.Drawing.Point(12, 91);
            this.groupBox_Product.Name = "groupBox_Product";
            this.groupBox_Product.Size = new System.Drawing.Size(776, 93);
            this.groupBox_Product.TabIndex = 2;
            this.groupBox_Product.TabStop = false;
            this.groupBox_Product.Text = "Ürün adına göre ara";
            // 
            // textBox_Product
            // 
            this.textBox_Product.Location = new System.Drawing.Point(87, 33);
            this.textBox_Product.Name = "textBox_Product";
            this.textBox_Product.Size = new System.Drawing.Size(269, 20);
            this.textBox_Product.TabIndex = 0;
            this.textBox_Product.TextChanged += new System.EventHandler(this.textBox_Product_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_QuantityPerUnit);
            this.groupBox1.Controls.Add(this.textBox_UnitsInStock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_UnitPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_Add_Category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(75, 22);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(182, 20);
            this.textBox_ProductName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori";
            // 
            // comboBox_Add_Category
            // 
            this.comboBox_Add_Category.FormattingEnabled = true;
            this.comboBox_Add_Category.Location = new System.Drawing.Point(75, 60);
            this.comboBox_Add_Category.Name = "comboBox_Add_Category";
            this.comboBox_Add_Category.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Add_Category.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fiyat";
            // 
            // textBox_UnitPrice
            // 
            this.textBox_UnitPrice.Location = new System.Drawing.Point(75, 102);
            this.textBox_UnitPrice.Name = "textBox_UnitPrice";
            this.textBox_UnitPrice.Size = new System.Drawing.Size(182, 20);
            this.textBox_UnitPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stok Adedi";
            // 
            // textBox_UnitsInStock
            // 
            this.textBox_UnitsInStock.Location = new System.Drawing.Point(424, 22);
            this.textBox_UnitsInStock.Name = "textBox_UnitsInStock";
            this.textBox_UnitsInStock.Size = new System.Drawing.Size(197, 20);
            this.textBox_UnitsInStock.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "BirimAdedi";
            // 
            // textBox_QuantityPerUnit
            // 
            this.textBox_QuantityPerUnit.Location = new System.Drawing.Point(424, 60);
            this.textBox_QuantityPerUnit.Name = "textBox_QuantityPerUnit";
            this.textBox_QuantityPerUnit.Size = new System.Drawing.Size(197, 20);
            this.textBox_QuantityPerUnit.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Update);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Update_QuantityPerUnit);
            this.groupBox2.Controls.Add(this.textBox_Update_UnitsInStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Update_UnitPrice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox_Update_Category);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_Update_ProductName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 606);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün ekle";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(489, 105);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(132, 23);
            this.button_Update.TabIndex = 13;
            this.button_Update.Text = "Güncelle";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "BirimAdedi";
            // 
            // textBox_Update_QuantityPerUnit
            // 
            this.textBox_Update_QuantityPerUnit.Location = new System.Drawing.Point(424, 60);
            this.textBox_Update_QuantityPerUnit.Name = "textBox_Update_QuantityPerUnit";
            this.textBox_Update_QuantityPerUnit.Size = new System.Drawing.Size(197, 20);
            this.textBox_Update_QuantityPerUnit.TabIndex = 11;
            // 
            // textBox_Update_UnitsInStock
            // 
            this.textBox_Update_UnitsInStock.Location = new System.Drawing.Point(424, 22);
            this.textBox_Update_UnitsInStock.Name = "textBox_Update_UnitsInStock";
            this.textBox_Update_UnitsInStock.Size = new System.Drawing.Size(197, 20);
            this.textBox_Update_UnitsInStock.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stok Adedi";
            // 
            // textBox_Update_UnitPrice
            // 
            this.textBox_Update_UnitPrice.Location = new System.Drawing.Point(75, 102);
            this.textBox_Update_UnitPrice.Name = "textBox_Update_UnitPrice";
            this.textBox_Update_UnitPrice.Size = new System.Drawing.Size(182, 20);
            this.textBox_Update_UnitPrice.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fiyat";
            // 
            // comboBox_Update_Category
            // 
            this.comboBox_Update_Category.FormattingEnabled = true;
            this.comboBox_Update_Category.Location = new System.Drawing.Point(75, 60);
            this.comboBox_Update_Category.Name = "comboBox_Update_Category";
            this.comboBox_Update_Category.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Update_Category.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kategori";
            // 
            // textBox_Update_ProductName
            // 
            this.textBox_Update_ProductName.Location = new System.Drawing.Point(75, 22);
            this.textBox_Update_ProductName.Name = "textBox_Update_ProductName";
            this.textBox_Update_ProductName.Size = new System.Drawing.Size(182, 20);
            this.textBox_Update_ProductName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ürün Adı";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(695, 64);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Sil";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 808);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Product);
            this.Controls.Add(this.groupBox_Category);
            this.Controls.Add(this.dataGridView_Products);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.groupBox_Category.ResumeLayout(false);
            this.groupBox_Product.ResumeLayout(false);
            this.groupBox_Product.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.GroupBox groupBox_Category;
        private System.Windows.Forms.GroupBox groupBox_Product;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.TextBox textBox_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Add_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_QuantityPerUnit;
        private System.Windows.Forms.TextBox textBox_UnitsInStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Update_QuantityPerUnit;
        private System.Windows.Forms.TextBox textBox_Update_UnitsInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Update_UnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Update_Category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Update_ProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Delete;
    }
}

