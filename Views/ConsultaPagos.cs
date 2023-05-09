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
    public partial class ConsultaPagos : Form
    {
        #region Variables Privadas
        private static Classes.Controllers.Empleado empleado;
        #endregion
        public ConsultaPagos()
        {
            InitializeComponent();
        }

        #region Eventos
        private void ConsultaPagos_Load(object sender, EventArgs e)
        {
            cbMes.SelectedIndex = 0;
            cbMes.Enabled = false;
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
                txtNombreEmpleado.Text = empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno;
                txtRol.Text = empleado.Rol.Nombre;
                cbMes.Enabled = true;
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex > 0 && dtYear.Value.Year > 0)
            {
                Classes.Controllers.Pagos pagos = new Classes.Controllers.Pagos();
                pagos = pagos.ObtenerPagoPorEmpleadoRolMesYear(empleado.ID, empleado.Rol.ID, cbMes.SelectedIndex, dtYear.Value.Year);

                txtSueldoHora.Text = empleado.Rol.PagoPorHora.ToString();
                txtDiasPorTurno.Text = empleado.Rol.DiasTrabajadosTurno.ToString();
                txtHorasPorTurno.Text = empleado.Rol.HorasTrabajadasTurno.ToString();


                decimal dSalarioBruto = pagos.SalarioBruto; 

                txtSueldoBruto.Text = dSalarioBruto.ToString();
                txtBonoPorEntrega.Text = empleado.Rol.BonoPorEntrega.ToString();
                txtBonoPorHora.Text = empleado.Rol.BonoPorHora.ToString();

                Classes.Controllers.Movimientos movimientos = new Classes.Controllers.Movimientos();
                movimientos = movimientos.ObtenerMovimientoPorEmpleadoMesYear(empleado.ID, cbMes.SelectedIndex, dtYear.Value.Year);

                txtTotalEntregas.Text = movimientos.CantidadEntregas.ToString();

                decimal dTotalBonusPorEntrega = pagos.TotalBonusPorEntrega;
                txtTotalBonoPorEntrega.Text = dTotalBonusPorEntrega.ToString("0.00");

                decimal dTotalBonusPorHora = pagos.TotalBonusPorHora;
                txtTotalBonoPorHora.Text = dTotalBonusPorHora.ToString("0.00");

                decimal dSubtotal = pagos.Subtotal;
                txtSubtotal.Text = dSubtotal.ToString("0.00");

                Classes.Controllers.Impuestos impuestos = new Classes.Controllers.Impuestos();

                decimal dTotalISR = pagos.ISR;
                txtISR.Text = dTotalISR.ToString("0.00");

                decimal dTotalISRAdicional = 0;

                dTotalISRAdicional = pagos.ISRAdicional;
                txtISRAdicional.Text = dTotalISRAdicional.ToString("0.00");

                decimal dIngresoNeto = pagos.IngresosNeto;
                txtIngresoNeto.Text = dIngresoNeto.ToString("0.00");

                decimal dValesDespensa = pagos.TotalValesDespensa;
                txtValesDespensa.Text = dValesDespensa.ToString("0.00");

                decimal dPagoNeto = pagos.PagoNeto;
                txtPagoNeto.Text = dPagoNeto.ToString("0.00");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RegresarMenu();
        }
        #endregion

        #region Metodos Privados
        private void RegresarMenu()
        {
            Menu oMenu = new Menu();
            this.Hide();
            oMenu.ShowDialog();
            this.Close();
        }
        #endregion


    }
}
