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
                MessageBox.Show("El ID Debe Ser Un Numero Positivo");
                textInsertID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Llenar El Campo Nombre");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Llenar El Campo Telefono");
                textInsertPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Llenar El Campo Correo Electronico");
                textInsertEmail.Focus();
                return;
            }

            if (db.Proveedores.Any(c => c.ProveedorID == id))
            {
                MessageBox.Show($"Ya Existe Un Proveedor Con El ID {id}");
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

                MessageBox.Show("Exito Al Insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                textInsertEmail.Clear();
                textInsertPhone.Clear();
                LoadSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Insertar");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string  IDtext = textDeleteID.Text.Trim();
            
            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID Debe Ser Un Numero Positivo");
                textDeleteID.Focus();
                return;
            }

            try 
            {
                var supplier = db.Proveedores.Find(id);

                if (supplier == null)
                {
                    MessageBox.Show($"Ya No Existe Proveedor Con El ID {id}");
                    return;
                }

                db.Proveedores.Remove(supplier);
                db.SaveChanges();

                MessageBox.Show("Exito Al Eliminar");

                textDeleteID.Clear();
                LoadSupplier();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Eliminar");
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
                MessageBox.Show("El ID Debe Ser Un Numero Positivo");
                textUpdateID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Llenar El Campo Nombre");
                textUpdateName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Llennar EL Campo Telefono");
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
                    MessageBox.Show($"No Existe Un Proveedor Con El ID {id}");
                    return;
                }

                supplier.CorreoElectronico = email;
                supplier.ProveedorNombre = name;
                supplier.Telefono = phone;

                db.SaveChanges();

                MessageBox.Show("Exito Al Actualizar");

                textUpdateID.Clear();
                textUpdateName.Clear();
                textUpdatePhone.Clear();
                textUpdateEmail.Clear();
                LoadSupplier();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Al Actualizada");
            }

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }
    }
}
