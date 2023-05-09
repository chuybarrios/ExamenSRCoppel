using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;
using ExamenSRCoppel.Classes.Connection;
using System.Security.Cryptography;

namespace ExamenSRCoppel.Classes.Controllers
{
    internal class Login
    {

        #region Variables Privada
        private string _user;
        private string _password;
        private string _passwordEncriptado;
        private dbConnection _conDB = new dbConnection();
        #endregion

        #region Public Variables
        public static Session.Usuario usuario;
        #endregion

        #region Constructor
        public Login(string User, string Password)
        {
            this._user = User;
            this._password = Password;
        }
        #endregion

        #region Metodos Publicos
        public bool ValidarLogin()
        {
            _conDB = new dbConnection();
            bool bValidate = true;

            try
            {
                _conDB.IniciarConexion();

                SqlCommand cmd = new SqlCommand("SP_CONSULTA_USUARIO", _conDB.ConexionActiva);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@USUARIO", this._user);

                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (!ValidarPassword(dt.Rows[0]["USUARIO_PASSWORD"].ToString()))
                        bValidate = false;

                    usuario = new Session.Usuario(Convert.ToInt32(dt.Rows[0]["ID"].ToString()), this._user, this._passwordEncriptado,
                    (Convert.ToBoolean(dt.Rows[0]["USUARIO_ESTATUS"].ToString())));
                }

                cmd.Dispose();
                dap.Dispose();

                _conDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar la información:" + ex.Message);
                return false;
            }

            return bValidate;
        }
        #endregion

        #region Private Methods
        private string EncryptPassword(string pUser, string pPassword)
        {
            SHA512Managed mhash = new SHA512Managed();
            byte[] bytValue = Encoding.UTF8.GetBytes(pUser.ToUpper() + pPassword.ToUpper());
            byte[] bytHash = mhash.ComputeHash(bytValue);
            mhash.Clear();

            return Convert.ToBase64String(bytHash);
        }

        private bool ValidarPassword(string pPassword)
        {
            this._passwordEncriptado = EncryptPassword(this._user, this._password);

            if (pPassword == _passwordEncriptado)
                return true;

            return false;
        }
        #endregion
    }
}
