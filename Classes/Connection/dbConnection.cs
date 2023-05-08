using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ExamenSRCoppel.Classes.Connection
{
    internal class dbConnection
    {
        #region Variables PRivadas
        private string _conexionString;
        private SqlConnection _conexion;
        private SqlTransaction _transaccion;
        #endregion

        #region Propiedades
        public SqlTransaction TransaccionActiva
        {
            get { return _transaccion; }
            set { _transaccion = value; }
        }

        public SqlConnection ConexionActiva
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        #endregion

        #region Constructor
        public dbConnection()
        {
            this._conexionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            this._transaccion = null;
        }
        #endregion

        #region Metodos Publicos
        public void IniciarConexion()
        {
            if (this._conexion == null)
            {
                this._conexion = new SqlConnection(this._conexionString);
                this._conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (this._conexion != null)
                this._conexion.Close();
        }

        public void IniciarTransaccion()
        {
            if (this._transaccion == null || this._transaccion.Connection == null)
            {
                this._conexion = new SqlConnection(this._conexionString);
                this._conexion.Open();
                this._transaccion = _conexion.BeginTransaction();
            }
        }

        public void ConfirmarTransaccion()
        {
            if (this._transaccion != null)
            {
                this._transaccion.Commit();

                if (this._transaccion.Connection != null)
                    if (this._transaccion.Connection.State == ConnectionState.Open)
                        this._transaccion.Connection.Close();

                this._transaccion = null;
            }
        }

        public void RollBackTransaccion()
        {
            if (this._transaccion != null)
            {
                this._transaccion.Rollback();

                if (this._transaccion.Connection != null)
                    if (this._transaccion.Connection.State == ConnectionState.Open)
                        this._transaccion.Connection.Close();

                this._transaccion = null;
            }
        }
        #endregion

    }
}
