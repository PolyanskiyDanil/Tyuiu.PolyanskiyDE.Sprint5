using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.PolyanskiyDE.Sprint5.Task4.V2.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint5.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckesExistsFile()
        {
            string path = @"C:\DataSprint5\InPutFileTask4V2";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
