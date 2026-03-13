using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM_Manejo.Modelo;

namespace ORM_Manejo
{
    public partial class ClientForm : Form
    {
        private LP2Entities1 db;
        public ClientForm()
        {
            InitializeComponent();
            db = new LP2Entities1();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            var Clientes = db.Clientes.OrderBy(c => c.ClienteID)
                .Select(c => new
                {
                    ID = c.ClienteID,
                    Nombre = c.NombreCompleto,
                    Email = c.CorreoElectronico,
                    Telefono = c.Telefono,
                    Direccion = c.Direccion

                }).ToList();

            Screen.DataSource = Clientes;

            Screen.Columns["ID"].Width = 50;
            Screen.Columns["Nombre"].Width = 140;
            Screen.Columns["Email"].Width = 140;
            Screen.Columns["Telefono"].Width = 140;
            Screen.Columns["Direccion"].Width = 140;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string IDtext = textInsertID.Text.Trim();
            string name = textInsertName.Text.Trim();
            string email = textInsertEmail.Text.Trim();
            string phone = textInsertPhone.Text.Trim();
            string address = textInsertAddress.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textInsertID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Introduzca Datos en el Campo Nombre");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Introduzca Datos en el Campo Correo Electronico");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Introduzca Datos en el Campo Telefono");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Introduzca Datos en el Campo Direccion");
                textInsertName.Focus();
                return;
            }

            if (db.Clientes.Any( c => c.ClienteID == id))
            {
                MessageBox.Show($"Ya Existe Un cliente con el ID {id}");
                textInsertID.Focus();
                return;
            }

            try
            {
                var newClient = new Cliente
                {             
                    ClienteID = id,
                    NombreCompleto = name,
                    Telefono = phone,
                    Direccion = address,
                    CorreoElectronico = email,                   
                };

                db.Clientes.Add(newClient);
                db.SaveChanges();

                MessageBox.Show("Exito al Insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                textInsertPhone.Clear();
                textInsertEmail.Clear();
                textInsertAddress.Clear();
                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Insertar");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string IDtext = textDeleteID.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textDeleteID.Focus();
                return;
            }

            try
            {
                var client = db.Clientes.Find(id);

                if (client == null)
                {
                    MessageBox.Show($"No existe cliente con el ID {id}");
                    return;
                }

                db.Clientes.Remove(client);
                db.SaveChanges();

                MessageBox.Show("Exito al Eliminar");

                textDeleteID.Clear();
                LoadClients();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Eliminar");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string IDtext = textUpdateID.Text.Trim();
            string newName = textUpdateName.Text.Trim();
            string newEmail = textUpdateEmail.Text.Trim();
            string newPhone = textUpdatePhone.Text.Trim();
            string newAddress = textUpdateAddress.Text.Trim();

            if (string.IsNullOrEmpty(IDtext) || !int.TryParse(IDtext, out int id) || id < 1)
            {
                MessageBox.Show("El ID debe ser un numero positivo");
                textUpdateID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Introduzca Datos en el Campo Nombre");
                textUpdateName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Introduzca Datos en el Campo Correo Electronico");
                textUpdateEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Introduzca Datos en el Campo Telefono");
                textUpdatePhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newAddress))
            {
                MessageBox.Show("Introduzca Datos en el Campo Direccion");
                textUpdateAddress.Focus();
                return;
            }

            try
            {
                var client = db.Clientes.Find(id);

                if (client == null) 
                {
                    MessageBox.Show($"No existe un cliente con el ID {id}");
                    return;
                }

                client.NombreCompleto = newName;
                client.CorreoElectronico = newEmail;
                client.Direccion = newAddress;
                client.Telefono = newPhone;

                db.SaveChanges();

                MessageBox.Show("Exito al Actualizar");

                textUpdateID.Clear();
                textUpdateName.Clear();
                textUpdateEmail.Clear();
                textUpdatePhone.Clear();
                textUpdateAddress.Clear();
                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar");
            }

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}
