﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.PolyanskiyDE.Sprint5.Task2.V3.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint5.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.PolyanskiyDE.Sprint5\Tyuiu.PolyanskiyDE.Sprint5.Task2.V3\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
