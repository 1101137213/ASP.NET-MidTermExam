using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KuasCoreTests.Dao
{
    [TestClass]
    public class CourseDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region 單元測試 Spring 必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] {
                    // assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml"
                };
            }
        }

        #endregion 單元測試 Spring 必寫的內容

        public ICourseDao CourseDao { get; set; }

        [TestMethod]
        public void TestCourseDao_GetCourseById()
        {
            Course course = CourseDao.GetCourseById("1101137213");
            Assert.IsNotNull(course);
            Console.WriteLine("課稱編號為 = " + course.Course_ID);
            Console.WriteLine("課程名稱為 = " + course.Course_Name);
            Console.WriteLine("課程描述為 = " + course.Course_Description);
        }
    }
}