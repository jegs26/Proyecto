using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALSQLServer.TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Conectar1()
        {
            DAL objDAL = new DAL();
            objDAL.Conectar("Conexion");
            objDAL.Desconectar();
        }

        [TestMethod]
        public void Conectar2()
        {
            DAL objDAL = new DAL("DESKTOP-DK86A1I", "PRUEBA", "sa", "123");
            objDAL.Desconectar();
        }

        [TestMethod]
        public void Procedimiento()
        {
            Procedimiento objProcedimiento = new Procedimiento("dbo.Test");
        }
    }
}
