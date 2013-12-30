using System;
using IDSA_SQL.DB.SQL.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationUnitTests
{
    [TestClass]
    public class DataBaseConnectionTests
    {
        private String GOOD_CONNECTION_STRING =
         @"metadata=res://*/DB.SQL.Files.Reports.csdl|res://*/DB.SQL.Files.Reports.ssdl|res://*/DB.SQL.Files.Reports.msl;s
         provider=System.Data.SqlClient; +
         provider connection string=&quot; 
         user id=derfuw-PC\derfuw;
         password=;
         Data Source=DERFUW-PC\SQLEXPRESS;
         Initial Catalog=idsa-test;
         Integrated Security=True;
         App=EntityFramework&quot;";
        [TestMethod]
        public void CheckGoodConnection()
        {
            // ? IDEA ?
            //var entity = new ReportsContainer(GOOD_CONNECTION_STRING);
            
        }
    }
}
