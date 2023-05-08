using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenSRCoppel.Classes.Connection;
using System.Data;

namespace ExamenSRCoppel.Classes.Controllers
{
    internal class Roles
    {
        #region Variables Privadas
        private int _id;
        private string _nombre;
        private bool _estatus;
        private DateTime _fechaRegistro;
        private int _diasTrabajadosTurno;
        private int _horasTrabajadasTurno;
        private decimal _pagoPorHora;
        private decimal _bonosPorEntrega;
        private decimal _bonosPorHora;
        private string _usuarioModificacion;
        private DateTime _fechaModificacion;
        private dbConnection conDB;
        #endregion

        #region Constructor
        public Roles() { }

        public Roles(int id)
        {
            _id = id;
            Cargar();
        }
        #endregion

        #region Propiedades
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public bool Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value;}
        }

        public int DiasTrabajadosTurno
        {
            get { return _diasTrabajadosTurno; }
            set { _diasTrabajadosTurno = value; }
        }

        public int HorasTrabajadasTurno
        {
            get { return _horasTrabajadasTurno; }
            set { _horasTrabajadasTurno = value; }
        }

        public decimal PagoPorHora
        {
            get { return _pagoPorHora; }
            set { _pagoPorHora = value; }
        }

        public decimal BonoPorEntrega
        {
            get { return _bonosPorEntrega; }
            set { _bonosPorEntrega = value; }
        }

        public decimal BonoPorHora
        {
            get { return _bonosPorHora; }
            set { _bonosPorHora = value; }
        }

        public string UsuarioModificacion
        {
            get { return _usuarioModificacion; }
            set { _usuarioModificacion = value; }
        }

        public DateTime FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }

        #endregion

        #region Metodos Privados

        private void Cargar()
        {
            conDB = new dbConnection();

            try
            {
                conDB.IniciarConexion();
                SqlCommand cmd = new SqlCommand("SP_CONSULTA_ROL_POR_ID", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", this._id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this._nombre = reader["NOMBRE"].ToString();
                    this._estatus = Convert.ToBoolean(reader["ESTATUS"].ToString());
                    this._fechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"].ToString());
                    this._diasTrabajadosTurno = Convert.ToInt32(reader["DIAS_TRABAJADOS_TURNO"].ToString());
                    this._horasTrabajadasTurno = Convert.ToInt32(reader["HORAS_TRABAJADAS_TURNO"].ToString());
                    this._pagoPorHora = Convert.ToDecimal(reader["PAGO_POR_HORA"].ToString());
                    this._bonosPorEntrega = Convert.ToDecimal(reader["BONOS_POR_ENTREGA"].ToString());
                    this._bonosPorHora = Convert.ToDecimal(reader["BONOS_POR_HORA"].ToString());
                    this._usuarioModificacion = reader["USUARIO_MODIFICACION"].ToString();
                    this._fechaModificacion = (reader["FECHA_MODIFICACION"].ToString().Trim() != "") ? Convert.ToDateTime(reader["FECHA_MODIFICACION"].ToString()) : DateTime.MinValue;                     
                }

                cmd.Dispose();
                conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar la información. " + ex.Message);
            }
        }

        #endregion

        #region Metodos Publicos
        public List<Roles> ConsultaRoles()
        {
            conDB = new dbConnection();
            List<Roles> lstRoles = new List<Roles>();

            try
            {
                conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_ROLES", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    lstRoles.Add(new Roles(Convert.ToInt32(reader["ID"].ToString())));

                cmd.Dispose();
                conDB.CerrarConexion();

                return lstRoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los roles: " + ex.Message);
                return lstRoles;
            }
        }

        #endregion

    }
}
