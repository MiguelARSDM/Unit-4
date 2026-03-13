namespace ORM_Manejo
{
    partial class CategoryForm
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
            this.textInsertName = new System.Windows.Forms.TextBox();
            this.textInsertID = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDeleteID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Screen = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.textUpdateID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textInsertName);
            this.groupBox1.Controls.Add(this.textInsertID);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // textInsertName
            // 
            this.textInsertName.Location = new System.Drawing.Point(9, 88);
            this.textInsertName.Name = "textInsertName";
            this.textInsertName.Size = new System.Drawing.Size(265, 22);
            this.textInsertName.TabIndex = 4;
            // 
            // textInsertID
            // 
            this.textInsertID.Location = new System.Drawing.Point(9, 44);
            this.textInsertID.Name = "textInsertID";
            this.textInsertID.Size = new System.Drawing.Size(265, 22);
            this.textInsertID.TabIndex = 3;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(9, 125);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(265, 50);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDeleteID);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(286, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // textDeleteID
            // 
            this.textDeleteID.Location = new System.Drawing.Point(9, 44);
            this.textDeleteID.Name = "textDeleteID";
            this.textDeleteID.Size = new System.Drawing.Size(185, 22);
            this.textDeleteID.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(9, 74);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(185, 50);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Screen);
            this.groupBox3.Controls.Add(this.buttonShow);
            this.groupBox3.Location = new System.Drawing.Point(0, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 248);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar";
            // 
            // Screen
            // 
            this.Screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Screen.Location = new System.Drawing.Point(9, 50);
            this.Screen.Name = "Screen";
            this.Screen.RowHeadersWidth = 51;
            this.Screen.RowTemplate.Height = 24;
            this.Screen.Size = new System.Drawing.Size(757, 177);
            this.Screen.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(295, 21);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(191, 23);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Mostrar";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textUpdateName);
            this.groupBox4.Controls.Add(this.textUpdateID);
            this.groupBox4.Controls.Add(this.buttonUpdate);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(492, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 195);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actualizar";
            // 
            // textUpdateName
            // 
            this.textUpdateName.Location = new System.Drawing.Point(9, 88);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(265, 22);
            this.textUpdateName.TabIndex = 4;
            // 
            // textUpdateID
            // 
            this.textUpdateID.Location = new System.Drawing.Point(9, 44);
            this.textUpdateID.Name = "textUpdateID";
            this.textUpdateID.Size = new System.Drawing.Size(265, 22);
            this.textUpdateID.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(9, 125);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(265, 50);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de la Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
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
        private System.Windows.Forms.TextBox textInsertName;
        private System.Windows.Forms.TextBox textInsertID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textDeleteID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Screen;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textUpdateName;
        private System.Windows.Forms.TextBox textUpdateID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}