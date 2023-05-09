using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSRCoppel.Classes.Session
{
    internal class Usuario
    {

        #region Variables Privadas
        private int _id;
        private string _username;
        private string _password;
        private bool _status;
        #endregion

        #region Constructor
        public Usuario(int id, string name, string password, bool status)
        {
            this._id = id;
            this._username = name;
            this._password = password;
            this._status = status;
        }
        #endregion

        #region Propiedades
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion
    }
}
