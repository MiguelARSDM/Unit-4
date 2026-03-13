namespace ORM_Manejo
{
    partial class ProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textInsertID = new System.Windows.Forms.TextBox();
            this.textInsertStock = new System.Windows.Forms.TextBox();
            this.textInsertDescription = new System.Windows.Forms.TextBox();
            this.textInsertPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDeleteID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Screen = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textUpdateID = new System.Windows.Forms.TextBox();
            this.textUpdateStock = new System.Windows.Forms.TextBox();
            this.textUpdateDescription = new System.Windows.Forms.TextBox();
            this.textUpdatePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.textInsertName = new System.Windows.Forms.TextBox();
            this.comboInsertCategory = new System.Windows.Forms.ComboBox();
            this.comboUpdateCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboInsertCategory);
            this.groupBox1.Controls.Add(this.textInsertName);
            this.groupBox1.Controls.Add(this.textInsertID);
            this.groupBox1.Controls.Add(this.textInsertStock);
            this.groupBox1.Controls.Add(this.textInsertDescription);
            this.groupBox1.Controls.Add(this.textInsertPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // textInsertID
            // 
            this.textInsertID.Location = new System.Drawing.Point(9, 37);
            this.textInsertID.Name = "textInsertID";
            this.textInsertID.Size = new System.Drawing.Size(119, 22);
            this.textInsertID.TabIndex = 10;
            // 
            // textInsertStock
            // 
            this.textInsertStock.Location = new System.Drawing.Point(9, 129);
            this.textInsertStock.Name = "textInsertStock";
            this.textInsertStock.Size = new System.Drawing.Size(119, 22);
            this.textInsertStock.TabIndex = 9;
            // 
            // textInsertDescription
            // 
            this.textInsertDescription.Location = new System.Drawing.Point(134, 129);
            this.textInsertDescription.Name = "textInsertDescription";
            this.textInsertDescription.Size = new System.Drawing.Size(253, 22);
            this.textInsertDescription.TabIndex = 8;
            // 
            // textInsertPrice
            // 
            this.textInsertPrice.Location = new System.Drawing.Point(9, 85);
            this.textInsertPrice.Name = "textInsertPrice";
            this.textInsertPrice.Size = new System.Drawing.Size(119, 22);
            this.textInsertPrice.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(9, 167);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(378, 56);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDeleteID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Location = new System.Drawing.Point(399, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // textDeleteID
            // 
            this.textDeleteID.Location = new System.Drawing.Point(6, 37);
            this.textDeleteID.Name = "textDeleteID";
            this.textDeleteID.Size = new System.Drawing.Size(235, 22);
            this.textDeleteID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 70);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(235, 56);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Screen);
            this.groupBox3.Controls.Add(this.buttonShow);
            this.groupBox3.Location = new System.Drawing.Point(0, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1045, 302);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar";
            // 
            // Screen
            // 
            this.Screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen.Location = new System.Drawing.Point(9, 57);
            this.Screen.Name = "Screen";
            this.Screen.RowHeadersWidth = 51;
            this.Screen.Size = new System.Drawing.Size(1030, 234);
            this.Screen.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(408, 21);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(232, 30);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Mostrar";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboUpdateCategory);
            this.groupBox4.Controls.Add(this.textUpdateName);
            this.groupBox4.Controls.Add(this.textUpdateID);
            this.groupBox4.Controls.Add(this.textUpdateStock);
            this.groupBox4.Controls.Add(this.textUpdateDescription);
            this.groupBox4.Controls.Add(this.textUpdatePrice);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.buttonUpdate);
            this.groupBox4.Location = new System.Drawing.Point(652, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 239);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insertar";
            // 
            // textUpdateID
            // 
            this.textUpdateID.Location = new System.Drawing.Point(9, 37);
            this.textUpdateID.Name = "textUpdateID";
            this.textUpdateID.Size = new System.Drawing.Size(119, 22);
            this.textUpdateID.TabIndex = 10;
            // 
            // textUpdateStock
            // 
            this.textUpdateStock.Location = new System.Drawing.Point(9, 129);
            this.textUpdateStock.Name = "textUpdateStock";
            this.textUpdateStock.Size = new System.Drawing.Size(119, 22);
            this.textUpdateStock.TabIndex = 9;
            // 
            // textUpdateDescription
            // 
            this.textUpdateDescription.Location = new System.Drawing.Point(134, 129);
            this.textUpdateDescription.Name = "textUpdateDescription";
            this.textUpdateDescription.Size = new System.Drawing.Size(253, 22);
            this.textUpdateDescription.TabIndex = 8;
            // 
            // textUpdatePrice
            // 
            this.textUpdatePrice.Location = new System.Drawing.Point(9, 85);
            this.textUpdatePrice.Name = "textUpdatePrice";
            this.textUpdatePrice.Size = new System.Drawing.Size(119, 22);
            this.textUpdatePrice.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre Del Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Precio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(9, 167);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(378, 56);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textUpdateName
            // 
            this.textUpdateName.Location = new System.Drawing.Point(134, 37);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(253, 22);
            this.textUpdateName.TabIndex = 11;
            // 
            // textInsertName
            // 
            this.textInsertName.Location = new System.Drawing.Point(134, 37);
            this.textInsertName.Name = "textInsertName";
            this.textInsertName.Size = new System.Drawing.Size(253, 22);
            this.textInsertName.TabIndex = 11;
            // 
            // comboInsertCategory
            // 
            this.comboInsertCategory.FormattingEnabled = true;
            this.comboInsertCategory.Location = new System.Drawing.Point(134, 83);
            this.comboInsertCategory.Name = "comboInsertCategory";
            this.comboInsertCategory.Size = new System.Drawing.Size(253, 24);
            this.comboInsertCategory.TabIndex = 12;
            // 
            // comboUpdateCategory
            // 
            this.comboUpdateCategory.FormattingEnabled = true;
            this.comboUpdateCategory.Location = new System.Drawing.Point(134, 83);
            this.comboUpdateCategory.Name = "comboUpdateCategory";
            this.comboUpdateCategory.Size = new System.Drawing.Size(253, 24);
            this.comboUpdateCategory.TabIndex = 13;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 548);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textInsertID;
        private System.Windows.Forms.TextBox textInsertStock;
        private System.Windows.Forms.TextBox textInsertDescription;
        private System.Windows.Forms.TextBox textInsertPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textDeleteID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Screen;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textUpdateID;
        private System.Windows.Forms.TextBox textUpdateStock;
        private System.Windows.Forms.TextBox textUpdateDescription;
        private System.Windows.Forms.TextBox textUpdatePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboInsertCategory;
        private System.Windows.Forms.TextBox textInsertName;
        private System.Windows.Forms.TextBox textUpdateName;
        private System.Windows.Forms.ComboBox comboUpdateCategory;
    }
}