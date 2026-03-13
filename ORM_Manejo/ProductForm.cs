using ORM_Manejo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM_Manejo
{
    
    public partial class ProductForm : Form
    {
        private LP2Entities1 db;
        public ProductForm()
        {
            InitializeComponent();
            db = new LP2Entities1();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            var productos = db.Productos.OrderBy( p => p.ProductoID)
                .Select( p => new {
                    
                    ID = p.ProductoID,
                    Nombre = p.NombreProducto,
                    Precio = p.Precio,
                    Stock = p.Stock,
                    Categoria = p.Categoria.NombreCategoria,
                    Descripcion = p.Descripcion
                
                }).ToList();

            Screen.DataSource = productos;

            Screen.Columns["ID"].Width = 50;
            Screen.Columns["Nombre"].Width = 150;
            Screen.Columns["Precio"].Width = 75;
            Screen.Columns["Stock"].Width = 75;
            Screen.Columns["Categoria"].Width = 175;
            Screen.Columns["Descripcion"].Width = 175;
        }

        private void LoadCategories()
        {
            var categorias = db.Categorias.Select(c => new {
                ID = c.CategoriaID,
                Nombre = c.NombreCategoria
            }).ToList();

            comboInsertCategory.DataSource = categorias;
            comboInsertCategory.DisplayMember = "Nombre";
            comboInsertCategory.ValueMember = "ID";

            comboUpdateCategory.DataSource = categorias;
            comboUpdateCategory.DisplayMember = "Nombre";
            comboUpdateCategory.ValueMember = "ID";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string IDtext = textInsertID.Text.Trim();
            string name = textInsertName.Text.Trim();
            string price = textInsertPrice.Text.Trim(); 
            string stock = textInsertStock.Text.Trim();
            string categoryValue = comboInsertCategory.SelectedValue.ToString();
            string description = textInsertDescription.Text.Trim(); 

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID Debe Ser Un Numero Positivo");
                textInsertID.Clear();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Llenar Campo Nombre");
                textInsertID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(price) || !decimal.TryParse(price, out decimal prc) || prc < 1)
            {
                MessageBox.Show("El Precio Debe Ser Un Numero Positivo");
                textInsertPrice.Clear();
                return;
            }

            if (string.IsNullOrEmpty(stock) || !int.TryParse(stock, out int stk) || stk < 0)
            {
                MessageBox.Show("El Stock Debe Ser Igual o Mayor a 0");
                textInsertStock.Clear();
                return;
            }

            if (string.IsNullOrWhiteSpace(categoryValue)) 
            {
                MessageBox.Show("Debe Selecionar Una Categoria");
                comboInsertCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Llenar El Campo Descripcion");
                textInsertDescription.Focus();
                return;
            }

            if (db.Productos.Any(p => p.ProductoID == id))
            {
                MessageBox.Show($"Ya Existe Una Categoría Con El ID {id}");
                textInsertID.Focus();
                return;
            }


            try 
            {

                var product = new Producto
                {
                    ProductoID = id,
                    NombreProducto = name,
                    Descripcion = description,
                    CategoriaID = Convert.ToInt32(categoryValue),
                    Precio = prc,
                    Stock = stk

                };

                db.Productos.Add(product);
                db.SaveChanges();

                MessageBox.Show("Exito Al Insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                textInsertDescription.Clear();
                textInsertPrice.Clear();
                textInsertStock.Clear();
                LoadProduct();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Insertar");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string IDtext = textDeleteID.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("Debe Introducir Un ID Valido");
                textDeleteID.Focus();
                return;
            }

            try 
            {
                var product = db.Productos.Find(id);

                if (product == null)
                {
                    MessageBox.Show($"No Existe Producto Con El ID {id}");
                    return;
                }

                db.Productos.Remove(product);
                db.SaveChanges();

                MessageBox.Show("Exito Al Eliminar");

                textDeleteID.Clear();
                LoadProduct();

            }
            catch  (Exception ex) 
            {
                MessageBox.Show("Error Al Eliminar");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string IDtext = textUpdateID.Text.Trim();
            string name = textUpdateName.Text.Trim();
            string price = textUpdatePrice.Text.Trim();
            string stock = textUpdateStock.Text.Trim();
            string categoryValue = comboUpdateCategory.SelectedValue.ToString();
            string description = textUpdateDescription.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID Debe Ser Un Numero Positivo");
                textUpdateID.Clear();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Llenar Campo Nombre");
                textUpdateName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(price) || !decimal.TryParse(price, out decimal prc) || prc < 1)
            {
                MessageBox.Show("El Precio Debe Ser Un Numero Positivo");
                textUpdatePrice.Clear();
                return;
            }

            if (string.IsNullOrEmpty(stock) || !int.TryParse(stock, out int stk) || stk < 0)
            {
                MessageBox.Show("El Stock Debe Ser Igual o Mayor a 0");
                textUpdateStock.Clear();
                return;
            }

            if (string.IsNullOrWhiteSpace(categoryValue))
            {
                MessageBox.Show("Debe Selecionar una Categoria");
                comboUpdateCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Llenar El campo Descripcion");
                textUpdateDescription.Focus();
                return;
            }

       
            try
            {
                var product = db.Productos.Find(id);

                if (product == null)
                {
                    MessageBox.Show($"No Existe Un Producto Con El ID {id}");
                    return;
                }

                product.NombreProducto = name;
                product.Descripcion = description;
                product.Precio = prc;
                product.Stock = stk;
                product.CategoriaID = Convert.ToInt32(categoryValue);

                db.SaveChanges();

                MessageBox.Show("Exito Al Insertar");

                textUpdateID.Clear();
                textUpdateName.Clear();
                textUpdateDescription.Clear();
                textUpdatePrice.Clear();
                textUpdateStock.Clear();
                LoadProduct();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Insertar");
            }


        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProduct();
        }
    }
}
