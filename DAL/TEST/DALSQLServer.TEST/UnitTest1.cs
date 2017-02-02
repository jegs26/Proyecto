using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALSQLServer.TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DAL objDAL = new DAL();
            objDAL.Conectar("Conexion");

            string sBD = objDAL.sBD;
        }
    }
}
