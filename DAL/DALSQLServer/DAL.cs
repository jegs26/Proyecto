using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALSQLServer
{
    public class DAL
    {
        SqlConnection objConexion;
        public string sBD;// { get; }

        public DAL()
        {
            try
            {
                sBD = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DAL(string sNombreConexion)
        {
            Conectar(sNombreConexion);
        }

        public DAL(string sServidor, string sBD, string sUsuario, string sContraseña)
        {
            try
            {
                string sConexion = "";
                EstablecerConexion(sConexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Conectar(string sNombreConexion)
        {
            try
            {
                var connection = System.Configuration.ConfigurationManager.ConnectionStrings[sNombreConexion].ConnectionString;
                objConexion = new SqlConnection(connection);
                sBD = objConexion.Database;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EstablecerConexion(string sCadenaConexion)
        {
            try
            {
                objConexion = new SqlConnection(sCadenaConexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Desconectar()
        {
            try
            {
                if (objConexion != null)
                {
                    objConexion.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
