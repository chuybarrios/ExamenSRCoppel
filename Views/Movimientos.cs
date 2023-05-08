using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ExamenSRCoppel.Classes.Controllers;

namespace ExamenSRCoppel.Views
{
    public partial class Movimientos : Form
    {
        #region Variables Privadas
        private static Classes.Controllers.Empleado empleado;
        #endregion
        public Movimientos()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Movimientos_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RegresarMenu();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(true);
        }

        private void txtIDEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCantidadEntregas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text.Trim().Length > 0)
            {
                empleado = new Classes.Controllers.Empleado(Convert.ToInt32(txtIDEmpleado.Text));
                txtNombreEmpleado.Text = empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno;
                txtRol.Text = empleado.Rol.Nombre;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Controllers.Movimientos movimientos = new Classes.Controllers.Movimientos();
                movimientos.Empleado = empleado;
                movimientos.FechaRegistro = DateTime.Now;
                movimientos.Mes = cbMes.SelectedIndex;
                movimientos.Year = dtYear.Value.Year;
                movimientos.CantidadEntregas = Convert.ToInt32(txtCantidadEntregas.Text);

                if (movimientos.GuardarMovimiento())
                    MessageBox.Show("Movimiento registrado correctamente.");
                else
                    MessageBox.Show("Ocurrió un error al guardar el movimiento.");

                HabilitarControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el movimiento:" + ex.Message);
            }
        }
        #endregion

        #region Metodo Privados
        private void LimpiarControles()
        {
            txtIDEmpleado.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtRol.Text = string.Empty;
            txtCantidadEntregas.Text = string.Empty;
            cbMes.SelectedIndex = 0;
        }

        private void HabilitarControles(bool habilitar)
        {
            txtIDEmpleado.Enabled = habilitar;
            txtNombreEmpleado.Enabled = habilitar;
            txtRol.Enabled = habilitar;
            txtCantidadEntregas.Enabled = habilitar;
            cbMes.Enabled = habilitar;
            dtYear.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
        }

        private void RegresarMenu()
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }





        #endregion


    }
}
