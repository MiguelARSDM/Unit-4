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
            var listaCategorias = db.Categorias.OrderBy(c => c.CategoriaID)
                .Select(c => new
                {
                    ID = c.CategoriaID,
                    Nombre = c.NombreCategoria,
                    
                }).ToList();

            Screen.DataSource = listaCategorias;

            Screen.Columns["ID"].Width = 185;
            Screen.Columns["Nombre"].Width = 330;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string IDText = textInsertID.Text.Trim();
            string name = textInsertName.Text.Trim();

            
            if (string.IsNullOrEmpty(IDText) || !int.TryParse(IDText, out int ID) || ID < 1) 
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textInsertID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Debe ingresar el nombre de la categoria");
                textInsertName.Focus();
                return;
            }

            if (db.Categorias.Any( c => c.CategoriaID == ID)) 
            {
                MessageBox.Show($"Ya existe una categoría con el ID {ID}.");
                textInsertID.Focus();
                return;
            }

            try
            {

                var newCategoria = new Categoria
                {
                    CategoriaID = Convert.ToInt32(textInsertID.Text.Trim()),
                    NombreCategoria = textInsertName.Text.Trim()
                };


                db.Categorias.Add(newCategoria);
                db.SaveChanges();

                MessageBox.Show("Exito al insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                LoadCategories();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al insertar");
            }

            }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
         
            string IDText = textDeleteID.Text.Trim();

            if (string.IsNullOrEmpty(IDText) || !int.TryParse(IDText, out int ID) || ID < 1) 
            {
                MessageBox.Show("Debe ingresar una ID Valida");
                textDeleteID.Focus();
                return;
            }

            try
            {
                var categoria = db.Categorias.Find(ID);

                if (categoria == null)
                {
                    MessageBox.Show($"No Existe la Categoria con la ID {ID}");
                    return;
                }

                db.Categorias.Remove(categoria);
                db.SaveChanges();

                MessageBox.Show("Exito al Eliminar");

                textDeleteID.Clear();
                LoadCategories();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al Eliminar");
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string IDText = textUpdateID.Text.Trim();
            string newName = textUpdateName.Text.Trim();

            if (string.IsNullOrEmpty(IDText) || !int.TryParse(IDText, out int ID) || ID < 1)
            {
                MessageBox.Show("Ingrese un ID valido");
                textUpdateID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newName)) 
            {
                MessageBox.Show("Ingrese un nuevo nombre");
                textUpdateName.Focus();
                return;
            }

            try
            {
                var categoria = db.Categorias.Find(ID);

                if (categoria == null)
                {
                    MessageBox.Show($"No existe una categoria con el ID {ID}");
                    return;
                }

                categoria.NombreCategoria = newName; ;
                db.SaveChanges();

                MessageBox.Show("Exito al Actualizar Categoria");

                textUpdateID.Clear();
                textUpdateName.Clear();
                LoadCategories();

            }catch (Exception ex) 
            {
                MessageBox.Show("Error al Actualizar Categoria");
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
