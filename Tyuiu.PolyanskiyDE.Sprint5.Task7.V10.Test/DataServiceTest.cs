using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.PolyanskiyDE.Sprint5.Task7.V10.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.PolyanskiyDE.Sprint5\Tyuiu.PolyanskiyDE.Sprint5.Task7.V10\bin\Debug\OutPutFileTask7V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
