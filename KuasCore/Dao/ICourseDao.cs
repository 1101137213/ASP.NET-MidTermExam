using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Dao
{
    public interface ICourseDao
    {
        IList<Course> GetAllCourses();

        Course GetCourseById(string id);

        Course GetCourseByName(string name);
    }
}