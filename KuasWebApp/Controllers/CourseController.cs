using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class CourseController : ApiController
    {
        public ICourseService CourseService { get; set; }

        [HttpGet]
        public IList<Course> GetAllCourses()
        {
            var courses = CourseService.GetAllCourses();
            return courses;
        }

        [HttpGet]
        [ActionName("byId")]
        public Course GetCourseById(string id)
        {
            var course = CourseService.GetCourseById(id);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

        [HttpGet]
        [ActionName("byName")]
        public Course GetCourseByName(string name)
        {
            var course = CourseService.GetCourseById(name);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }
    }
}