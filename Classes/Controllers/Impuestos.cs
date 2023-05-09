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
    internal class Impuestos
    {
        #region Variables Privadas
        private int _id;
        private decimal _ISR;
        private decimal _ISRAdicional;
        private decimal _valesDespensa;
        private dbConnection _conDB = new dbConnection();
        #endregion

        #region Constructor
        public Impuestos() 
        { 
            Cargar(); 
        }
        #endregion

        #region Propiedades
        public int ID { get { return _id; } }

        public decimal ISR { get { return _ISR; } }

        public decimal ISRAdicional { get { return _ISRAdicional; } }

        public decimal ValesDespensa { get { return _valesDespensa; } }
        #endregion

        #region Private Methods
        private void Cargar()
        {
            _conDB = new dbConnection();
            try
            {
                _conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_IMPUESTOS", _conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this._id = Convert.ToInt32(reader["ID"].ToString());
                    this._ISR = Convert.ToDecimal(reader["ISR"].ToString());
                    this._ISRAdicional = Convert.ToDecimal(reader["ISR_ADICIONAL"].ToString());
                    this._valesDespensa = Convert.ToDecimal(reader["VALES_DESPENSA"].ToString());
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
    }
}
