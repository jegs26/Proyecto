using System.Data;
using System.Data.SqlClient;

namespace DALSQLServer
{
    public class Procedimiento
    {
        SqlCommand objCommand;

        public Procedimiento(string strNombre)
        {
            objCommand = new SqlCommand(strNombre);
            objCommand.CommandType = CommandType.StoredProcedure;

        }

        public void AgregarParametro(Parametro objParametro)
        {
            objCommand.Parameters.Add(objParametro);
        }
    }
}
