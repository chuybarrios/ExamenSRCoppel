using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenSRCoppel.Classes.Connection;

namespace ExamenSRCoppel.Classes.Controllers
{
    internal class Pagos
    {
        #region Variables Privadas
        private int _id;
        private Empleado _empleado;
        private int _pagoMes;
        private int _pagoYear;
        private decimal _salarioBruto;
        private decimal _totalBonusPorEntrega;
        private decimal _totalBonusPorHora;
        private decimal _subtotal;
        private decimal _ISR;
        private decimal _ISRAdicional;
        private decimal _ingresosNetos;
        private decimal _totalValesDespensa;
        private decimal _pagoNeto;
        private dbConnection _conDB = new dbConnection();
        #endregion

        #region Constructor
        public Pagos() { }

        public Pagos(int id)
        {
            _id = id;
            Cargar();
        }
        #endregion

        #region Propiedades
        public int ID { get { return _id; } }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public int PagoMes
        {
            get { return _pagoMes; }
            set { _pagoMes = value; }
        }

        public int PagoYear
        {
            get { return _pagoYear; }
            set { _pagoYear = value; }
        }

        public decimal SalarioBruto
        {
            get { return _salarioBruto; }
            set { _salarioBruto = value; }
        }

        public decimal TotalBonusPorEntrega
        {
            get { return _totalBonusPorEntrega; }
            set { _totalBonusPorEntrega = value; }
        }

        public decimal TotalBonusPorHora
        {
            get { return _totalBonusPorHora; }
            set { _totalBonusPorHora = value; }
        }

        public decimal Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public decimal ISR
        {
            get { return _ISR; }
            set { _ISR = value; }
        }

        public decimal ISRAdicional
        {
            get { return _ISRAdicional; }
            set { _ISRAdicional = value; }
        }

        public decimal IngresosNeto
        {
            get { return _ingresosNetos; }
            set { _ingresosNetos = value; }
        }

        public decimal TotalValesDespensa
        {
            get { return _totalValesDespensa; }
            set { _totalValesDespensa = value; }
        }

        public decimal PagoNeto
        {
            get { return _pagoNeto; }
            set { _pagoNeto = value; }
        }
        #endregion

        #region Private Methods
        private void Cargar()
        {
            _conDB = new dbConnection();
            try
            {
                _conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_PAGO_POR_ID", _conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", this._id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this._empleado = new Empleado(Convert.ToInt32(reader["ID_EMPLEADO"].ToString()));
                    this._pagoMes = Convert.ToInt32(reader["PAGO_DEL_MES"].ToString());
                    this._pagoYear = Convert.ToInt32(reader["PAGO_DEL_YEAR"].ToString());
                    this._salarioBruto = Convert.ToDecimal(reader["SALARIO_BRUTO"].ToString());
                    this._totalBonusPorEntrega = Convert.ToDecimal(reader["TOTAL_BONUS_POR_ENTREGA"].ToString());
                    this._totalBonusPorHora = Convert.ToDecimal(reader["TOTAL_BONUS_POR_HORA"].ToString());
                    this._subtotal = Convert.ToDecimal(reader["SUBTOTAL"].ToString());
                    this._ISR = Convert.ToDecimal(reader["TOTAL_ISR"].ToString());
                    this._ISRAdicional = Convert.ToDecimal(reader["TOTAL_ISR_ADICIONAL"].ToString());
                    this._ingresosNetos = Convert.ToDecimal(reader["INGRESOS_NETOS"].ToString());
                    this._totalValesDespensa = Convert.ToDecimal(reader["TOTAL_VALES_DESPENSA"].ToString());
                    this._pagoNeto = Convert.ToDecimal(reader["PAGO_NETO"].ToString());
                }

                cmd.Dispose();

                _conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                _conDB.CerrarConexion();
            }
        }
        #endregion

        #region Public Methods
        public bool GuardarPago()
        {
            _conDB = new dbConnection();
            bool registrado = true;

            try
            {
                _conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_GUARDAR_PAGOS", _conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_EMPLEADO", this._empleado.ID);
                cmd.Parameters.AddWithValue("@ID_ROL", this._empleado.Rol.ID);
                cmd.Parameters.AddWithValue("@MES", this._pagoMes);
                cmd.Parameters.AddWithValue("@YEAR", this._pagoYear);
                cmd.Parameters.AddWithValue("@SALARIO_BRUTO", this._salarioBruto);
                cmd.Parameters.AddWithValue("@TOTAL_BONUS_POR_ENTREGA", this._totalBonusPorEntrega);
                cmd.Parameters.AddWithValue("@TOTAL_BONUS_POR_HORA", this._totalBonusPorHora);
                cmd.Parameters.AddWithValue("@SUBTOTAL", this._subtotal);
                cmd.Parameters.AddWithValue("@TOTAL_ISR", this._ISR);
                cmd.Parameters.AddWithValue("@TOTAL_ISR_ADICIONAL", this._ISRAdicional);
                cmd.Parameters.AddWithValue("@INGRESOS_NETOS", this._ingresosNetos);
                cmd.Parameters.AddWithValue("@TOTAL_VALES_DESPENSA", this._totalValesDespensa);
                cmd.Parameters.AddWithValue("@PAGO_NETO", this._pagoNeto);

                var returnParameter = cmd.Parameters.Add("@RESULT", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                if (Convert.ToInt32(returnParameter.Value) == 0)
                    throw new Exception("Error al registrar el pago");

                _conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                registrado = false;
                _conDB.CerrarConexion();
            }

            return registrado;
        }

        public Pagos ObtenerPagoPorEmpleadoRolMesYear(int ID_Empleado, int ID_ROl, int Mes, int Year)
        {
            _conDB = new dbConnection();
            int iID = 0;

            try
            {
                _conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_PAGO_POR_EMPLEADO_ROL_MES_ANIO", _conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_EMPLEADO", ID_Empleado);
                cmd.Parameters.AddWithValue("@ID_ROL", ID_ROl);
                cmd.Parameters.AddWithValue("@MES", Mes);
                cmd.Parameters.AddWithValue("@YEAR", Year);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    iID = Convert.ToInt32(reader["ID"].ToString());

                cmd.Dispose();

                _conDB.CerrarConexion();

                return new Pagos(iID);
            }
            catch (Exception ex)
            {
                return new Pagos();
            }
        }
        #endregion
    }
}
