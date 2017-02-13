using System;
using System.Data.SqlClient;

namespace DALSQLServer
{
    public class DAL
    {
        SqlConnection objConexion;
        public string strBD;
        public string strCadenaConexion;
        public string strServidor;

        public DAL()
        {
            try
            {
                strBD = string.Empty;
                strCadenaConexion = string.Empty;
                strServidor = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DAL(string strNombreConexion)
        {
            Conectar(strNombreConexion);
        }

        public DAL(string strServidor, string strBD, string strUsuario, string strContraseña)
        {
            try
            {
                string strConexion = "Data Source=" + strServidor + ";Initial Catalog=" + strBD + ";User Id=" + strUsuario + ";Password=" + strContraseña + "";
                EstablecerConexion(strConexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Conectar(string strNombreConexion)
        {
            try
            {
                var connection = System.Configuration.ConfigurationManager.ConnectionStrings[strNombreConexion].ConnectionString;
                objConexion = new SqlConnection(connection);
                objConexion.Open();
                strBD = objConexion.Database;
                strCadenaConexion = objConexion.ConnectionString;
                strServidor = objConexion.DataSource;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EstablecerConexion(string strCadenaConexion)
        {
            try
            {
                objConexion = new SqlConnection(strCadenaConexion);
                objConexion.Open();
                strBD = objConexion.Database;
                strCadenaConexion = objConexion.ConnectionString;
                strServidor = objConexion.DataSource;
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
