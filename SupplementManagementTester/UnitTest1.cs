using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SupplementManagement;
using SupplementManagement.DAO;
using System.Collections.Generic;
using SupplementManagement.DTO;


namespace SupplementManagementTester
{
    [TestClass]
    public class UnitTest1
    {

        public static TestContext TestContext;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            TestContext = context;
        }


        public void TestLoginCorrect(string username, string password)
        {
            //testing exist account --> shoudl return true;
            bool expected = true;
            bool result = AccountDAO.Instance.Login(username, password);
            Assert.AreEqual(expected, result);

        }


        public void TestLoginInCorrect(string username, string password)
        {
            //testing exist account --> shoudl return true;
            bool expected = false;
            bool result = AccountDAO.Instance.Login(username, password);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void autoTestLogin()
        {
            List<Tuple<string, string>> existAccountList = new List<Tuple<string, string>>{
                new Tuple<string, string>("admin", "40bd001563085fc35165329ea1ff5c5ecbdbbeef"),
                new Tuple<string, string>("minhquang88", "7c222fb2927d828af22f592134e8932480637c0d"),
                new Tuple<string, string>("chitincute", "7c222fb2927d828af22f592134e8932480637c0d"),
                new Tuple<string, string>("thythy23", "7c222fb2927d828af22f592134e8932480637c0d"),
                new Tuple<string, string>("baoanh22", "7c222fb2927d828af22f592134e8932480637c0d")
            };
            List<Tuple<string, string>> unExistAccountList = new List<Tuple<string, string>>{
              
                new Tuple<string, string>("minhquang98", "7c222fb2927d828af22f592134e8932480637c0d"),
                 new Tuple<string, string>("admin", "bd001563085fc35165329ea1ff5c5ecbdbbeef"),
                new Tuple<string, string>("chitincute", "7c222fb2927d828af2292134e8932480637"),
                new Tuple<string, string>("thythy2", "7c222fb2927d828af22f592134e8932480637c0d"),
                new Tuple<string, string>("baoanh32", "7c222fb2927d828af22f592134e8932480637c0d")
            };

            foreach (Tuple<string,string> i in existAccountList)
            {
                TestLoginCorrect(i.Item1, i.Item2);
            }
            foreach (Tuple<string, string> i in unExistAccountList)
            {
                TestLoginInCorrect(i.Item1, i.Item2);
            }
        }

        [TestMethod]
        public void autoTestWriteImport()
        {
            long[] validSidList = { 1, 2, 3, 4, 5 };

            // unexist in database sid --> is invalid sid 
            long[] inValidSidList = { 0,-1,-2,6,99};

            foreach (long i in validSidList)
            {
                //testWriteImportWithValidID(i);
            }
            foreach (long i in inValidSidList)
            {
                testWriteImportWithInvalidID(i);
            }
        }

        public void testWriteImportWithInvalidID(long sid)
        {
            //testing existImport---> giving old invalid ID --> can't write --> return false;
            bool expected = false;
            bool result = GoodImportDAO.Instance.writeImport(sid);
            Assert.AreEqual(expected, result);

        }

        public void testWriteImportWithValidID(long sid)
        {
            //testing existImport---> giving an Valid ID --> able to write --> return true;
            bool expected = true;
            bool result = GoodImportDAO.Instance.writeImport(sid);
            Assert.AreEqual(expected, result);

        }

        
        // TESTING STATISTIC

        public bool compareImport(GoodImport a,GoodImport sample)
        {
            Console.WriteLine("ID:" + a.ID.ToString() + " and " + sample.ID.ToString());
            Console.WriteLine("SID a:" + a.SID.ToString() + " and " + sample.ID.ToString());
            Console.WriteLine("Importdate a:" + a.ImportDate.ToString() + " and " + sample.ImportDate.ToString());
            if (a.ID == sample.ID && a.SID == sample.SID && a.ImportDate == sample.ImportDate)
            {
                return true;
            }
            return false;
        }

        public bool compareExport(GoodExport a, GoodExport sample)
        {
            Console.WriteLine("ID:" + a.ID.ToString() + " and " + sample.ID.ToString());
            Console.WriteLine("ID:" + a.SID.ToString() + " and " + sample.ID.ToString());
            Console.WriteLine("ID:" + a.CID.ToString() + " and " + sample.CID.ToString());

            if (a.ID == sample.ID && a.SID == sample.SID && a.ExportDate == sample.ExportDate
                && a.CID == sample.CID 
                && a.StatusDelivery == sample.StatusDelivery && a.StatusPayment == sample.StatusPayment)
            {
                return true;
            }
            return false;
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                @".\DataTestCase\ImportTestCase.txt", "ImportTestCase#csv", DataAccessMethod.Sequential)]
        public void testStatisticWithDataSource()
        {
            long id, sid;
            string importDate;
            id = long.Parse(TestContext.DataRow[0].ToString());
            sid = long.Parse(TestContext.DataRow[1].ToString());
            importDate = TestContext.DataRow[2].ToString();

            GoodImport sample = new GoodImport(id, sid, importDate);
            GoodImport a = GoodImportDAO.Instance.GetGoodImportbyId(id);

            bool expected = true;
            Assert.AreEqual(expected, compareImport(a, sample));


        }
    }
}
