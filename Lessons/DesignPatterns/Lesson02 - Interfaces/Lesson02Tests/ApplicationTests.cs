﻿using System;
using Lesson02;
using Lesson02.Data.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Lesson02Tests
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void DisplayFullList()
        {
            var testRepo = new TestUserRepository();
            var app = new HandyDandyApplication(testRepo);
            var data = string.Empty;

            using (var writer = new StringWriter())
            {
                app.DisplayUsers(writer);
                data = writer.ToString();
            }

            var lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(lines[0]);

            Assert.IsTrue(lines.Length == 4);
        }
    }
}
