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

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Llenar El Campo Correo Electronico");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Llenar El Campo Telefono");
                textInsertName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Llenar El Campo Direccion");
                textInsertName.Focus();
                return;
            }

            if (db.Clientes.Any( c => c.ClienteID == id))
            {
                MessageBox.Show($"Ya Existe Un Cliente Con El ID {id}");
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

                MessageBox.Show("Exito Al Insertar");

                textInsertID.Clear();
                textInsertName.Clear();
                textInsertPhone.Clear();
                textInsertEmail.Clear();
                textInsertAddress.Clear();
                LoadClients();
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
                MessageBox.Show("El ID Debe Ser Un Numero Positivo");
                textDeleteID.Focus();
                return;
            }

            try
            {
                var client = db.Clientes.Find(id);

                if (client == null)
                {
                    MessageBox.Show($"No Existe Cliente Con El ID {id}");
                    return;
                }

                db.Clientes.Remove(client);
                db.SaveChanges();

                MessageBox.Show("Exito Al Eliminar");

                textDeleteID.Clear();
                LoadClients();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Al Eliminar");
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
                MessageBox.Show("El ID Debe Ser Un numero Positivo");
                textUpdateID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Llenar El Campo Nombre");
                textUpdateName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Llenar El Campo Correo Electronico");
                textUpdateEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Llenar El Campo Telefono");
                textUpdatePhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newAddress))
            {
                MessageBox.Show("Llenar El Campo Direccion");
                textUpdateAddress.Focus();
                return;
            }

            try
            {
                var client = db.Clientes.Find(id);

                if (client == null) 
                {
                    MessageBox.Show($"No Existe Un Cliente Con El ID {id}");
                    return;
                }

                client.NombreCompleto = newName;
                client.CorreoElectronico = newEmail;
                client.Direccion = newAddress;
                client.Telefono = newPhone;

                db.SaveChanges();

                MessageBox.Show("Exito Al Actualizar");

                textUpdateID.Clear();
                textUpdateName.Clear();
                textUpdateEmail.Clear();
                textUpdatePhone.Clear();
                textUpdateAddress.Clear();
                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Actualizar");
            }

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}
