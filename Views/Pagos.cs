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

namespace ExamenSRCoppel.Views
{
    public partial class Pagos : Form
    {
        #region Variables Privadas
        private static Classes.Controllers.Empleado empleado;
        #endregion
        public Pagos()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Pagos_Load(object sender, EventArgs e)
        {
            btnPagar.Enabled = false;
            txtIDEmpleado.Enabled = false;
            cbMes.SelectedIndex = 0;
            cbMes.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RegresarMenu();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Pagos_Load(null, null);
            txtIDEmpleado.Enabled = true;
            txtIDEmpleado.Focus();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Controllers.Pagos pagos = new Classes.Controllers.Pagos();
                pagos.Empleado = empleado;
                pagos.PagoMes = cbMes.SelectedIndex;
                pagos.PagoYear = dtYear.Value.Year;
                pagos.SalarioBruto = Convert.ToDecimal(txtSueldoBruto.Text);
                pagos.TotalBonusPorEntrega = Convert.ToDecimal(txtTotalBonoPorEntrega.Text);
                pagos.TotalBonusPorHora = Convert.ToDecimal(txtTotalBonoPorHora.Text);
                pagos.Subtotal = Convert.ToDecimal(txtSubtotal.Text);
                pagos.ISR = Convert.ToDecimal(txtISR.Text);
                pagos.ISRAdicional = Convert.ToDecimal(txtISRAdicional.Text);
                pagos.IngresosNeto = Convert.ToDecimal(txtIngresoNeto.Text);
                pagos.TotalValesDespensa = Convert.ToDecimal(txtValesDespensa.Text);
                pagos.PagoNeto = Convert.ToDecimal(txtPagoNeto.Text);

                if (pagos.GuardarPago())
                    MessageBox.Show("Pago registrado correctamente.");
                else
                    MessageBox.Show("Ocurrió un error al momento de registrar el pago.");

                btnPagar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el pago:" + ex.Message);
            }
        }

        private void txtIDEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text.Trim().Length > 0)
            {
                empleado = new Classes.Controllers.Empleado(Convert.ToInt32(txtIDEmpleado.Text));
                txtNombreEmpleado.Text = empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno; ;
                txtRol.Text = empleado.Rol.Nombre;
                cbMes.Enabled = true;
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex > 0 && dtYear.Value.Year > 0)
            {
                txtSueldoHora.Text = empleado.Rol.PagoPorHora.ToString();
                txtDiasPorTurno.Text = empleado.Rol.DiasTrabajadosTurno.ToString();
                txtHorasPorTurno.Text = empleado.Rol.HorasTrabajadasTurno.ToString();
                

                decimal dSalarioBruto = (Convert.ToDecimal(empleado.Rol.PagoPorHora) * Convert.ToDecimal(empleado.Rol.HorasTrabajadasTurno) * Convert.ToDecimal(empleado.Rol.DiasTrabajadosTurno)) * 4;

                txtSueldoBruto.Text = dSalarioBruto.ToString();
                txtBonoPorEntrega.Text = empleado.Rol.BonoPorEntrega.ToString();
                txtBonoPorHora.Text = empleado.Rol.BonoPorHora.ToString();

                Classes.Controllers.Movimientos movimientos = new Classes.Controllers.Movimientos();
                movimientos = movimientos.ObtenerMovimientoPorEmpleadoMesYear(empleado.ID, cbMes.SelectedIndex, dtYear.Value.Year);

                txtTotalEntregas.Text = movimientos.CantidadEntregas.ToString();

                decimal dTotalBonusPorEntrega = (empleado.Rol.BonoPorEntrega * Convert.ToDecimal(movimientos.CantidadEntregas));
                txtTotalBonoPorEntrega.Text = dTotalBonusPorEntrega.ToString("0.00");

                decimal dTotalBonusPorHora = (empleado.Rol.BonoPorHora * Convert.ToDecimal(empleado.Rol.HorasTrabajadasTurno) * Convert.ToDecimal(empleado.Rol.DiasTrabajadosTurno)) * 4;
                txtTotalBonoPorHora.Text = dTotalBonusPorHora.ToString("0.00");

                decimal dSubtotal = (dSalarioBruto + dTotalBonusPorEntrega + dTotalBonusPorHora);
                txtSubtotal.Text = dSubtotal.ToString("0.00");

                Classes.Controllers.Impuestos impuestos = new Classes.Controllers.Impuestos();

                decimal dTotalISR = (dSubtotal * (impuestos.ISR / 100));
                txtISR.Text = dTotalISR.ToString("0.00");

                decimal dTotalISRAdicional = 0;

                if (dSubtotal >= 10000)
                {
                    dTotalISRAdicional = (dSubtotal * (impuestos.ISRAdicional / 100));
                    txtISRAdicional.Text = dTotalISRAdicional.ToString("0.00");
                }
                else
                {
                    txtISRAdicional.Text = dTotalISRAdicional.ToString("0.00");
                }

                decimal dIngresoNeto = dSubtotal - (dTotalISR + dTotalISRAdicional);
                txtIngresoNeto.Text = dIngresoNeto.ToString("0.00");

                decimal dValesDespensa = (dIngresoNeto * (impuestos.ValesDespensa / 100));
                txtValesDespensa.Text = dValesDespensa.ToString("0.00");

                decimal dPagoNeto = dIngresoNeto + dValesDespensa;
                txtPagoNeto.Text = dPagoNeto.ToString("0.00");

                btnPagar.Enabled = true;
            }
        }
        #endregion

        #region Metodos Privados
        private void HabilitarControles(bool habilitar)
        {
            btnPagar.Enabled = habilitar;
            cbMes.Enabled = habilitar;
            dtYear.Enabled = habilitar;
            txtIDEmpleado.Enabled = habilitar;
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
