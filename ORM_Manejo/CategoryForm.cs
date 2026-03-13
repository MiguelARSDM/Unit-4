using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM_Manejo.Modelo;

namespace ORM_Manejo
{
    public partial class CategoryForm : Form
    {
        private LP2Entities1 db;
        public CategoryForm()
        {
            InitializeComponent();
            db = new LP2Entities1();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories() 
        {
            var ListCategories = db.Categorias.OrderBy(c => c.CategoriaID)
                .Select(c => new
                {
                    ID = c.CategoriaID,
                    Nombre = c.NombreCategoria,           
                }).ToList();

            Screen.DataSource = ListCategories;

            Screen.Columns["ID"].Width = 185;
            Screen.Columns["Nombre"].Width = 330;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string IDText = textInsertID.Text.Trim();
            string name = textInsertName.Text.Trim();
    
            if (string.IsNullOrEmpty(IDText) || !int.TryParse(IDText, out int ID) || ID < 1) 
            {
                MessageBox.Show("EL ID Debe Ser Un Numero Positivo");
                textInsertID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Llenar Campo Nombre");
                textInsertName.Focus();
                return;
            }

            if (db.Categorias.Any( c => c.CategoriaID == ID)) 
            {
                MessageBox.Show($"Ya Existe Una Categoria Con El ID {ID}.");
                textInsertID.Focus();
                return;
            }

            try
            {
                var Category = new Categoria
                {
                    CategoriaID = Convert.ToInt32(IDText),
                    NombreCategoria = name
                };

                db.Categorias.Add(Category);
                db.SaveChanges();

                MessageBox.Show("Exito Al Insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                LoadCategories();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Al Insertar");
            }

            }

        private void buttonDelete_Click(object sender, EventArgs e)
        { 
            string IDText = textDeleteID.Text.Trim();

            if (string.IsNullOrEmpty(IDText) || !int.TryParse(IDText, out int ID) || ID < 1) 
            {
                MessageBox.Show("Debe Ingresar Un ID Valido");
                textDeleteID.Focus();
                return;
            }

            try
            {
                var category = db.Categorias.Find(ID);

                if (category == null)
                {
                    MessageBox.Show($"No Existe La Categoria Con La ID {ID}");
                    return;
                }

                db.Categorias.Remove(category);
                db.SaveChanges();

                MessageBox.Show("Exito Al Eliminar");

                textDeleteID.Clear();
                LoadCategories();          
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Al Eliminar");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string IDText = textUpdateID.Text.Trim();
            string newName = textUpdateName.Text.Trim();

            if (string.IsNullOrEmpty(IDText) || !int.TryParse(IDText, out int ID) || ID < 1)
            {
                MessageBox.Show("Ingrese Un ID Valido");
                textUpdateID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newName)) 
            {
                MessageBox.Show("Llene El Campo Nombre");
                textUpdateName.Focus();
                return;
            }

            try
            {
                var category = db.Categorias.Find(ID);

                if (category == null)
                {
                    MessageBox.Show($"No Existe Una Categoria Con El ID {ID}");
                    return;
                }

                category.NombreCategoria = newName; ;
                db.SaveChanges();

                MessageBox.Show("Exito Al Actualizar Categoria");

                textUpdateID.Clear();
                textUpdateName.Clear();
                LoadCategories();

            }catch (Exception ex) 
            {
                MessageBox.Show("Error Al Actualizar Categoria");
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
