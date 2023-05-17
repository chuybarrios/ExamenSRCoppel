using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenSRCoppel.Classes.Connection;
using static System.Windows.Forms.AxHost;

namespace ExamenSRCoppel.Classes.Controllers
{
    internal class Movimientos
    {
        #region Variables Privadas
        private int _id;
        private Empleado _empleado;
        private int _mes;
        private int _year;
        private int _cantidadEntregas;
        private DateTime _fechaRegistro;
        private bool _cargado;
        private dbConnection conDB = new dbConnection();
        #endregion

        #region Constructor
        public Movimientos()
        {

        }

        public Movimientos(int id)
        {
            _id = id;
            Cargar();
        }
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public int Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int CantidadEntregas
        {
            get { return _cantidadEntregas; }
            set { _cantidadEntregas = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }
        public bool Cargado
        {
            get { return _cargado; }
        }
        #endregion

        #region Metodos Privados
        private void Cargar()
        {
            conDB = new dbConnection();
            this._cargado = false;

            try
            {
                conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_MOVIMIENTO_POR_ID", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", this._id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this._empleado = new Empleado(Convert.ToInt32(reader["ID_EMPLEADO"].ToString()));
                    this._mes = Convert.ToInt32(reader["MES_MOVIMIENTO"].ToString());
                    this._year = Convert.ToInt32(reader["YEAR_MOVIMIENTO"].ToString());
                    this._cantidadEntregas = Convert.ToInt32(reader["CANTIDAD_ENTREGAS"].ToString());
                    this._fechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"].ToString());
                    this._cargado = true;
                }

                cmd.Dispose();

                conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar el movimiento: " + ex.Message);
            }
        }
        #endregion

        #region Metodos Publicos
        public bool GuardarMovimiento(bool bEdita)
        {
            conDB = new dbConnection();
            bool registrado = true;

            try
            {
                conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_GUARDAR_MOVIMIENTOS", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_EMPLEADO", this._empleado.ID);
                cmd.Parameters.AddWithValue("@ID_ROL", this._empleado.Rol.ID);
                cmd.Parameters.AddWithValue("@MES", this._mes);
                cmd.Parameters.AddWithValue("@YEAR", this._year);
                cmd.Parameters.AddWithValue("@CANTIDAD_ENTREGAS", this._cantidadEntregas);
                cmd.Parameters.AddWithValue("@FECHA_REGISTRO", this._fechaRegistro);

                if (bEdita)
                    cmd.Parameters.AddWithValue("@ID_MOVIMIENTO", this._id);
                else
                    cmd.Parameters.AddWithValue("@ID_MOVIMIENTO", 0);

                var returnParameter = cmd.Parameters.Add("@RESULT", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                if (Convert.ToInt32(returnParameter.Value) == 0)
                    throw new Exception("Error al registrar el movimiento");

                conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                registrado = false;
                conDB.CerrarConexion();
            }

            return registrado;
        }

        public Movimientos ObtenerMovimientoPorEmpleadoMesYear(int ID_Empleado, int Mes, int Year)
        {
            conDB = new dbConnection();
            int iID = 0;

            try
            {
                conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_MOVIMIENTO_POR_EMPLEADO_MES_ANIO", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_EMPLEADO", ID_Empleado);
                cmd.Parameters.AddWithValue("@MES", Mes);
                cmd.Parameters.AddWithValue("@YEAR", Year);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    iID = Convert.ToInt32(reader["ID"].ToString());

                cmd.Dispose();

                conDB.CerrarConexion();

                return new Movimientos(iID);
            }
            catch (Exception ex)
            {
                return new Movimientos();
            }
        }
        #endregion
    }
}
