using ExamenSRCoppel.Classes.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSRCoppel.Views
{
    public partial class Empleados : Form
    {
        #region Variables Privadas
        private bool bEdita = false;
        #endregion

        public Empleados()
        {
            InitializeComponent();
        }

        #region Eventos

        private void Empleados_Load(object sender, EventArgs e)
        {
            
            CargarRoles();
            LimpiarControles();
            HabilitarControles(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RegresarMenu();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bEdita = false;
            LimpiarControles();
            HabilitarControles(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length > 0)
            {
                HabilitarControles(true);
                txtID.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            txtID.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Count() > 0)
            {
                try
                {
                    Classes.Controllers.Empleado empleado = new Classes.Controllers.Empleado(Convert.ToInt32(txtID.Text));

                    if (empleado.Cargado)
                    {
                        txtNombre.Text = empleado.Nombre;
                        txtApellidoPaterno.Text = empleado.ApellidoPaterno;
                        txtApellidoMaterno.Text = empleado.ApellidoMaterno;
                        txtEmail.Text = empleado.Email;
                        txtTelefono.Text = empleado.Telefono;
                        cbRol.SelectedIndex = empleado.Rol.ID;
                        cbEstatus.SelectedIndex = (empleado.Estatus) ? 1 : 2;
                        dtFechaNacimiento.Value = empleado.FechaNacimiento;

                        switch (empleado.Sexo)
                        {
                            case 'M':
                                cbSexo.SelectedIndex = 1;
                                break;
                            case 'F':
                                cbSexo.SelectedIndex = 2;
                                break;
                            default:
                                cbSexo.SelectedIndex = 0;
                                break;
                        }

                        bEdita = true;
                    }
                    else
                        MessageBox.Show("No se encontró información del empleado ingresado.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al consultar al empleado: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    bool estatus = (cbEstatus.SelectedIndex == 1) ? true : false;
                    Roles roles = new Roles();
                    List<Roles> lstRoles = roles.ConsultaRoles();

                    foreach (Roles rol in lstRoles)
                    {
                        if (cbRol.SelectedItem.ToString() == rol.Nombre)
                            roles = rol;
                    }

                    Classes.Controllers.Empleado empleado;

                    if (bEdita)
                    {
                        empleado = new Classes.Controllers.Empleado(Convert.ToInt32(txtID.Text));
                        empleado.Nombre = txtNombre.Text;
                        empleado.ApellidoPaterno = txtApellidoPaterno.Text;
                        empleado.ApellidoMaterno = txtApellidoMaterno.Text;
                        empleado.Email = txtEmail.Text;
                        empleado.Telefono = txtTelefono.Text;
                        empleado.Sexo = Convert.ToChar(cbSexo.Text.Substring(0, 1));
                        empleado.FechaNacimiento = dtFechaNacimiento.Value;
                        empleado.Estatus = estatus;
                        empleado.Rol = roles;
                    }
                    else
                    {
                        empleado = new Classes.Controllers.Empleado(
                            txtNombre.Text,
                            txtApellidoPaterno.Text,
                            txtApellidoMaterno.Text,
                            txtEmail.Text,
                            txtTelefono.Text,
                            Convert.ToChar(cbSexo.Text.Substring(0, 1)),
                            dtFechaNacimiento.Value,
                            estatus,
                            roles
                            );
                    }

                    if (empleado.GuardarEmpleado(bEdita))
                    {
                        txtID.Text = empleado.ID.ToString();
                        MessageBox.Show("Empleado registrado correctamente.");
                    }
                    else
                        MessageBox.Show("Ocurrió un error al momento de registrar al empleado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar al empleado: " + ex.Message);
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #region METODODS PRIVADOS
        private void CargarRoles()
        {
            try
            {
                Roles roles = new Roles();
                List<Roles> lstRoles = roles.ConsultaRoles();

                cbRol.Items.Clear();
                cbRol.Items.Add("Seleccione un rol");

                foreach (Roles rol in lstRoles)
                    cbRol.Items.Add(rol.Nombre);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar los roles. " + ex.Message);
            }
        }
        private void LimpiarControles()
        {
            txtNombre.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbSexo.SelectedIndex = 0;
            cbRol.SelectedIndex = 0;
            cbEstatus.SelectedIndex = 0;
            dtFechaNacimiento.Value = DateTime.Now;
        }

        private void HabilitarControles(bool habilitar)
        {
            txtID.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtApellidoPaterno.Enabled= habilitar;
            txtApellidoMaterno.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            cbSexo.Enabled = habilitar;
            cbRol.Enabled = habilitar;
            cbEstatus.Enabled = habilitar;
            dtFechaNacimiento.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
        }

        private void RegresarMenu()
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private bool ValidarCampos()
        {
            bool regresaValor = true;

            if (txtNombre.Text == string.Empty ||
                txtApellidoPaterno.Text == string.Empty ||
                txtApellidoMaterno.Text == string.Empty ||
                txtEmail.Text == string.Empty ||
                cbEstatus.SelectedIndex == 0 ||
                cbRol.SelectedIndex == 0)
                regresaValor = false;

            return regresaValor;

        }





        #endregion


    }
}
