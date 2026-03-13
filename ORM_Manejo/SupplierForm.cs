using ORM_Manejo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM_Manejo
{
    public partial class SupplierForm : Form
    {
        private LP2Entities1 db;
        public SupplierForm()
        {
            InitializeComponent();
            db = new LP2Entities1();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            var proveedores = db.Proveedores.OrderBy(p => p.ProveedorID)
                .Select(p => new {

                    ID = p.ProveedorID,
                    Nombre = p.ProveedorNombre,
                    Email = p.CorreoElectronico,
                    Telefono = p.Telefono

                }).ToList();

            Screen.DataSource = proveedores;

            Screen.Columns["ID"].Width = 120;
            Screen.Columns["Nombre"].Width = 180;
            Screen.Columns["Email"].Width = 185;
            Screen.Columns["Telefono"].Width = 180;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string IDtext = textInsertID.Text.Trim();
            string name = textInsertName.Text.Trim();
            string phone = textInsertPhone.Text.Trim();
            string email = textInsertEmail.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textInsertID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Debe Introducir valor en el Campo Nombre");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Debe Introducir valor en el campo Telefono");
                textInsertPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Debe introducir valor en el Campo Correo Electronico");
                textInsertEmail.Focus();
                return;
            }

            if (db.Proveedores.Any(c => c.ProveedorID == id))
            {
                MessageBox.Show($"Ya existe un proveedor con el ID {id}");
                textInsertID.Focus();
                return;
            }

            try
            {
                var newSupplier = new Proveedore
                {
                    ProveedorID = id,
                    ProveedorNombre = name,
                    CorreoElectronico = email,
                    Telefono = phone

                };

                db.Proveedores.Add(newSupplier);
                db.SaveChanges();

                MessageBox.Show("Exito al Insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                textInsertEmail.Clear();
                textInsertPhone.Clear();
                LoadSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Insertar");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string  IDtext = textDeleteID.Text.Trim();
            
            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textDeleteID.Focus();
                return;
            }

            try 
            {
                var supplier = db.Proveedores.Find(id);

                if (supplier == null)
                {
                    MessageBox.Show($"Ya no existe proveedor con el ID {id}");
                    return;
                }

                db.Proveedores.Remove(supplier);
                db.SaveChanges();

                MessageBox.Show("Exito al Eliminar");

                textDeleteID.Clear();
                LoadSupplier();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a Eliminar");
            }



        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string IDtext = textUpdateID.Text.Trim();
            string name = textUpdateName.Text.Trim();
            string phone = textUpdatePhone.Text.Trim(); 
            string email = textUpdateEmail.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textUpdateID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("LLenar El Campo Nombre");
                textUpdateName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("LLennar EL Campo Telefono");
                textUpdatePhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Llenar el Campo Correo Electronico");
                textUpdateEmail.Focus();
                return;
            }

            try 
            {
                var supplier = db.Proveedores.Find(id);

                if (supplier == null) 
                {
                    MessageBox.Show($"No existe un Proveedor con el ID {id}");
                    return;
                }

                supplier.CorreoElectronico = email;
                supplier.ProveedorNombre = name;
                supplier.Telefono = phone;

                db.SaveChanges();

                MessageBox.Show("Exito al Actualizar");

                textUpdateID.Clear();
                textUpdateName.Clear();
                textUpdatePhone.Clear();
                textUpdateEmail.Clear();
                LoadSupplier();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al Actualizada");
            }

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }
    }
}
