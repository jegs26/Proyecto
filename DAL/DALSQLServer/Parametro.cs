using System.Data;
using System.Data.SqlClient;

namespace DALSQLServer
{
    public class Parametro
    {
        SqlParameter objParametro;
        public Parametro(string strNombre, DbType objTipo, object objValor)
        {
            objParametro = new SqlParameter();
            objParametro.DbType = objTipo;
            objParametro.SqlValue = objValor;
            objParametro.Value = objValor;
            objParametro.ParameterName = strNombre;
        }
        public Parametro(string strNombre, DbType objTipo, object objValor, ParameterDirection objDireccion)
        {
            objParametro = new SqlParameter();
            objParametro.DbType = objTipo;
            objParametro.SqlValue = objValor;
            objParametro.Value = objValor;
            objParametro.ParameterName = strNombre;
            objParametro.Direction = objDireccion;
        }
    }
}
