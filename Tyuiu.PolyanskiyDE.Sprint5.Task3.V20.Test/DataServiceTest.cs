using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.PolyanskiyDE.Sprint5.Task3.V20.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint5.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.PolyanskiyDE.Sprint5\Tyuiu.PolyanskiyDE.Sprint5.Task3.V20\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
