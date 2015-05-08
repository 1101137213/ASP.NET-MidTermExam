using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;

namespace KuasCoreTests.Services
{
    [TestClass]
    public class CourseServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] {
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml"
                };
            }
        }

        #endregion Spring 單元測試必寫的內容

        public ICourseService CourseService { get; set; }

        [TestMethod]
        public void TestCourseService_GetCourseById()
        {
            Course course = CourseService.GetCourseById("1101137213");
            Assert.IsNotNull(course);

            Console.WriteLine("課稱編號為 = " + course.Course_ID);
            Console.WriteLine("課程名稱為 = " + course.Course_Name);
            Console.WriteLine("課程描述為 = " + course.Course_Description;
        }
    }
}