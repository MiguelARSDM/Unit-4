namespace ORM_Manejo
{
    partial class SupplierForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textInsertEmail = new System.Windows.Forms.TextBox();
            this.textInsertPhone = new System.Windows.Forms.TextBox();
            this.textInsertID = new System.Windows.Forms.TextBox();
            this.textInsertName = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDeleteID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Screen = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textUpdateEmail = new System.Windows.Forms.TextBox();
            this.textUpdatePhone = new System.Windows.Forms.TextBox();
            this.textUpdateIID = new System.Windows.Forms.TextBox();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textInsertEmail);
            this.groupBox1.Controls.Add(this.textInsertPhone);
            this.groupBox1.Controls.Add(this.textInsertID);
            this.groupBox1.Controls.Add(this.textInsertName);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Del Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // textInsertEmail
            // 
            this.textInsertEmail.Location = new System.Drawing.Point(196, 84);
            this.textInsertEmail.Name = "textInsertEmail";
            this.textInsertEmail.Size = new System.Drawing.Size(178, 22);
            this.textInsertEmail.TabIndex = 4;
            // 
            // textInsertPhone
            // 
            this.textInsertPhone.Location = new System.Drawing.Point(196, 40);
            this.textInsertPhone.Name = "textInsertPhone";
            this.textInsertPhone.Size = new System.Drawing.Size(178, 22);
            this.textInsertPhone.TabIndex = 3;
            // 
            // textInsertID
            // 
            this.textInsertID.Location = new System.Drawing.Point(12, 40);
            this.textInsertID.Name = "textInsertID";
            this.textInsertID.Size = new System.Drawing.Size(178, 22);
            this.textInsertID.TabIndex = 2;
            // 
            // textInsertName
            // 
            this.textInsertName.Location = new System.Drawing.Point(12, 84);
            this.textInsertName.Name = "textInsertName";
            this.textInsertName.Size = new System.Drawing.Size(178, 22);
            this.textInsertName.TabIndex = 1;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(12, 115);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(362, 51);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textDeleteID);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(389, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            // 
            // textDeleteID
            // 
            this.textDeleteID.Location = new System.Drawing.Point(6, 40);
            this.textDeleteID.Name = "textDeleteID";
            this.textDeleteID.Size = new System.Drawing.Size(188, 22);
            this.textDeleteID.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Screen);
            this.groupBox3.Controls.Add(this.buttonShow);
            this.groupBox3.Location = new System.Drawing.Point(0, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 282);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar";
            // 
            // Screen
            // 
            this.Screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen.Location = new System.Drawing.Point(15, 66);
            this.Screen.Name = "Screen";
            this.Screen.RowHeadersWidth = 51;
            this.Screen.RowTemplate.Height = 24;
            this.Screen.Size = new System.Drawing.Size(954, 210);
            this.Screen.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(398, 21);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(185, 29);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Mostrar";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textUpdateEmail);
            this.groupBox4.Controls.Add(this.textUpdatePhone);
            this.groupBox4.Controls.Add(this.textUpdateIID);
            this.groupBox4.Controls.Add(this.textUpdateName);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(595, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 189);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actualizar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Correo Electronico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre Del Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID";
            // 
            // textUpdateEmail
            // 
            this.textUpdateEmail.Location = new System.Drawing.Point(196, 84);
            this.textUpdateEmail.Name = "textUpdateEmail";
            this.textUpdateEmail.Size = new System.Drawing.Size(178, 22);
            this.textUpdateEmail.TabIndex = 4;
            // 
            // textUpdatePhone
            // 
            this.textUpdatePhone.Location = new System.Drawing.Point(196, 40);
            this.textUpdatePhone.Name = "textUpdatePhone";
            this.textUpdatePhone.Size = new System.Drawing.Size(178, 22);
            this.textUpdatePhone.TabIndex = 3;
            // 
            // textUpdateIID
            // 
            this.textUpdateIID.Location = new System.Drawing.Point(12, 40);
            this.textUpdateIID.Name = "textUpdateIID";
            this.textUpdateIID.Size = new System.Drawing.Size(178, 22);
            this.textUpdateIID.TabIndex = 2;
            // 
            // textUpdateName
            // 
            this.textUpdateName.Location = new System.Drawing.Point(12, 84);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(178, 22);
            this.textUpdateName.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(362, 51);
            this.button3.TabIndex = 0;
            this.button3.Text = "Insertar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 555);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInsertEmail;
        private System.Windows.Forms.TextBox textInsertPhone;
        private System.Windows.Forms.TextBox textInsertID;
        private System.Windows.Forms.TextBox textInsertName;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDeleteID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Screen;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textUpdateEmail;
        private System.Windows.Forms.TextBox textUpdatePhone;
        private System.Windows.Forms.TextBox textUpdateIID;
        private System.Windows.Forms.TextBox textUpdateName;
        private System.Windows.Forms.Button button3;
    }
}