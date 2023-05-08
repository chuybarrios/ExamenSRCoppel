using ExamenSRCoppel.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSRCoppel
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            this.Hide();
            empleados.ShowDialog();
            this.Close();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos();
            this.Hide();
            pagos.ShowDialog();
            this.Close();
        }

        private void consultarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPagos consultaPagos = new ConsultaPagos();
            this.Hide();
            consultaPagos.ShowDialog();
            this.Close();
        }

        private void administrarMovimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Movimientos movimientos= new Movimientos();
            this.Hide();
            movimientos.ShowDialog();
            this.Close();
        }
    }
}
