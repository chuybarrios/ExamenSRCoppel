using ExamenSRCoppel.Classes.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExamenSRCoppel.Classes.Controllers
{
    internal class Empleado
    {
        #region Variables Privadas
        private int _id;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _email;
        private string _telefono;
        private char _sexo;
        private DateTime _fechaNacimiento;
        private bool _estatus;
        private Roles _rol;
        private bool _cargado;
        private dbConnection conDB = new dbConnection();
        #endregion

        #region Constructor
        public Empleado() { }

        public Empleado(int id)
        {
            _id = id;
            Cargar();
        }

        public Empleado(string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, char sexo, DateTime fechaNacimiento, bool estatus, Roles rol)
        {
            this._nombre = nombre;
            this._apellidoPaterno = apellidoPaterno;
            this._apellidoMaterno = apellidoMaterno;
            this._email = email;
            this._telefono = telefono;
            this._sexo = sexo;
            this._fechaNacimiento = fechaNacimiento;
            this._estatus = estatus;
            this._rol = rol;
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

        public string ApellidoPaterno
        {
            get { return _apellidoPaterno; }
            set { _apellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public char Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public bool Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        public Roles Rol
        {
            get { return _rol; }
            set { _rol = value; }
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

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_EMPLEADO_POR_ID", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", this._id);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    this._nombre = sdr["NOMBRE"].ToString();
                    this._apellidoPaterno = sdr["APELLIDO_PATERNO"].ToString();
                    this._apellidoMaterno = sdr["APELLIDO_MATERNO"].ToString();
                    this._email = sdr["EMAIL"].ToString();
                    this._telefono = sdr["TELEFONO"].ToString();
                    this._sexo = Convert.ToChar(sdr["SEXO"].ToString());
                    this._fechaNacimiento = Convert.ToDateTime(sdr["FECHA_NACIMIENTO"].ToString());
                    this._estatus = Convert.ToBoolean(sdr["ESTATUS"].ToString());
                    this._rol = new Roles(Convert.ToInt32(sdr["ID_ROL"].ToString()));
                    this._cargado = true;
                }

                cmd.Dispose();

                conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar la información: " + ex.Message);
            }
        }
        #endregion

        #region Metodos Publicos
        public bool GuardarEmpleado(bool bEdita)
        {
            conDB = new dbConnection();
            bool registrado = true;

            try
            {
                conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_GUARDAR_EMPLEADO", conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NOMBRE", this._nombre);
                cmd.Parameters.AddWithValue("@APELLIDO_PATERNO", this._apellidoPaterno);
                cmd.Parameters.AddWithValue("@APELLIDO_MATERNO", this._apellidoMaterno);
                cmd.Parameters.AddWithValue("@EMAIL", this._email);
                cmd.Parameters.AddWithValue("@TELEFONO", this._telefono);
                cmd.Parameters.AddWithValue("@SEXO", this._sexo);
                cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", this._fechaNacimiento);
                cmd.Parameters.AddWithValue("@ESTATUS", this._estatus);
                cmd.Parameters.AddWithValue("@ID_ROL", this._rol.ID);
                if (bEdita)
                    cmd.Parameters.AddWithValue("@ID_EMPLEADO", this._id);
                else
                    cmd.Parameters.AddWithValue("@ID_EMPLEADO", 0);

                var returnParameter = cmd.Parameters.Add("@RESULT", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                if (Convert.ToInt32(returnParameter.Value) == 0)
                    throw new Exception("Error al registrar al empleado.");

                this._id = Convert.ToInt32(returnParameter.Value);

                conDB.CerrarConexion();
            }
            catch
            {
                registrado = false;
                conDB.CerrarConexion();
            }

            return registrado;
        }
        #endregion

    }
}
