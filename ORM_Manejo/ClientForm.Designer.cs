namespace ORM_Manejo
{
    partial class ClientForm
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
            this.gropuBox = new System.Windows.Forms.GroupBox();
            this.textInsertAddress = new System.Windows.Forms.TextBox();
            this.textInsertPhone = new System.Windows.Forms.TextBox();
            this.textInsertEmail = new System.Windows.Forms.TextBox();
            this.textInsertName = new System.Windows.Forms.TextBox();
            this.textInsertID = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDeleteID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textUpdateAddress = new System.Windows.Forms.TextBox();
            this.textUpdatePhone = new System.Windows.Forms.TextBox();
            this.textUpdateEmail = new System.Windows.Forms.TextBox();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.textUpdateID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gropuBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gropuBox
            // 
            this.gropuBox.Controls.Add(this.textInsertAddress);
            this.gropuBox.Controls.Add(this.textInsertPhone);
            this.gropuBox.Controls.Add(this.textInsertEmail);
            this.gropuBox.Controls.Add(this.textInsertName);
            this.gropuBox.Controls.Add(this.textInsertID);
            this.gropuBox.Controls.Add(this.buttonInsert);
            this.gropuBox.Controls.Add(this.label5);
            this.gropuBox.Controls.Add(this.label4);
            this.gropuBox.Controls.Add(this.label3);
            this.gropuBox.Controls.Add(this.label2);
            this.gropuBox.Controls.Add(this.label1);
            this.gropuBox.Location = new System.Drawing.Point(3, 3);
            this.gropuBox.Name = "gropuBox";
            this.gropuBox.Size = new System.Drawing.Size(353, 242);
            this.gropuBox.TabIndex = 0;
            this.gropuBox.TabStop = false;
            this.gropuBox.Text = "Insertar";
            // 
            // textInsertAddress
            // 
            this.textInsertAddress.Location = new System.Drawing.Point(6, 144);
            this.textInsertAddress.Name = "textInsertAddress";
            this.textInsertAddress.Size = new System.Drawing.Size(338, 22);
            this.textInsertAddress.TabIndex = 10;
            // 
            // textInsertPhone
            // 
            this.textInsertPhone.Location = new System.Drawing.Point(184, 99);
            this.textInsertPhone.Name = "textInsertPhone";
            this.textInsertPhone.Size = new System.Drawing.Size(160, 22);
            this.textInsertPhone.TabIndex = 9;
            // 
            // textInsertEmail
            // 
            this.textInsertEmail.Location = new System.Drawing.Point(184, 46);
            this.textInsertEmail.Name = "textInsertEmail";
            this.textInsertEmail.Size = new System.Drawing.Size(160, 22);
            this.textInsertEmail.TabIndex = 8;
            // 
            // textInsertName
            // 
            this.textInsertName.Location = new System.Drawing.Point(6, 96);
            this.textInsertName.Name = "textInsertName";
            this.textInsertName.Size = new System.Drawing.Size(160, 22);
            this.textInsertName.TabIndex = 7;
            // 
            // textInsertID
            // 
            this.textInsertID.Location = new System.Drawing.Point(6, 46);
            this.textInsertID.Name = "textInsertID";
            this.textInsertID.Size = new System.Drawing.Size(160, 22);
            this.textInsertID.TabIndex = 6;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(6, 172);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(338, 53);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDeleteID);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(362, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // textDeleteID
            // 
            this.textDeleteID.Location = new System.Drawing.Point(6, 46);
            this.textDeleteID.Name = "textDeleteID";
            this.textDeleteID.Size = new System.Drawing.Size(187, 22);
            this.textDeleteID.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 74);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(187, 53);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonShow);
            this.groupBox4.Controls.Add(this.Screen);
            this.groupBox4.Location = new System.Drawing.Point(3, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(920, 249);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(365, 21);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(187, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Mostrar";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Screen
            // 
            this.Screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen.Location = new System.Drawing.Point(9, 50);
            this.Screen.Name = "Screen";
            this.Screen.RowHeadersWidth = 51;
            this.Screen.RowTemplate.Height = 24;
            this.Screen.Size = new System.Drawing.Size(905, 187);
            this.Screen.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textUpdateAddress);
            this.groupBox1.Controls.Add(this.textUpdatePhone);
            this.groupBox1.Controls.Add(this.textUpdateEmail);
            this.groupBox1.Controls.Add(this.textUpdateName);
            this.groupBox1.Controls.Add(this.textUpdateID);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(570, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // textUpdateAddress
            // 
            this.textUpdateAddress.Location = new System.Drawing.Point(6, 144);
            this.textUpdateAddress.Name = "textUpdateAddress";
            this.textUpdateAddress.Size = new System.Drawing.Size(338, 22);
            this.textUpdateAddress.TabIndex = 10;
            // 
            // textUpdatePhone
            // 
            this.textUpdatePhone.Location = new System.Drawing.Point(184, 99);
            this.textUpdatePhone.Name = "textUpdatePhone";
            this.textUpdatePhone.Size = new System.Drawing.Size(160, 22);
            this.textUpdatePhone.TabIndex = 9;
            // 
            // textUpdateEmail
            // 
            this.textUpdateEmail.Location = new System.Drawing.Point(184, 46);
            this.textUpdateEmail.Name = "textUpdateEmail";
            this.textUpdateEmail.Size = new System.Drawing.Size(160, 22);
            this.textUpdateEmail.TabIndex = 8;
            // 
            // textUpdateName
            // 
            this.textUpdateName.Location = new System.Drawing.Point(6, 96);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(160, 22);
            this.textUpdateName.TabIndex = 7;
            // 
            // textUpdateID
            // 
            this.textUpdateID.Location = new System.Drawing.Point(6, 46);
            this.textUpdateID.Name = "textUpdateID";
            this.textUpdateID.Size = new System.Drawing.Size(160, 22);
            this.textUpdateID.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 172);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(338, 53);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Direccion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Telefono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Correo Electronico";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nombre Completo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "ID";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gropuBox);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.gropuBox.ResumeLayout(false);
            this.gropuBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gropuBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView Screen;
        private System.Windows.Forms.TextBox textInsertAddress;
        private System.Windows.Forms.TextBox textInsertPhone;
        private System.Windows.Forms.TextBox textInsertEmail;
        private System.Windows.Forms.TextBox textInsertName;
        private System.Windows.Forms.TextBox textInsertID;
        private System.Windows.Forms.TextBox textDeleteID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textUpdateAddress;
        private System.Windows.Forms.TextBox textUpdatePhone;
        private System.Windows.Forms.TextBox textUpdateEmail;
        private System.Windows.Forms.TextBox textUpdateName;
        private System.Windows.Forms.TextBox textUpdateID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}