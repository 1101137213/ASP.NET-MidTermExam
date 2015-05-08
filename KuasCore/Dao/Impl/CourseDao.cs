using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao
    {
        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public IList<Course> GetAllCourses()
        {
            string command = @"SELECT * FROM Course ORDER BY Course_ID ASC";
            IList<Course> courses = ExecuteQueryWithRowMapper(command);
            return courses;
        }

        public Course GetCourseById(string id)
        {
            string command = @"SELECT * FROM Course WHERE Course_ID = @Course_ID";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Course_ID", DbType.String).Value = id;

            IList<Course> coueses = ExecuteQueryWithRowMapper(command, parameters);
            if (coueses.Count > 0)
            {
                return coueses[0];
            }

            return null;
        }

        public Course GetCourseByName(string name)
        {
            string command = @"SELECT * FROM Course WHERE Course_Name = @Course_Name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Course_Name", DbType.String).Value = name;

            IList<Course> coueses = ExecuteQueryWithRowMapper(command, parameters);
            if (coueses.Count > 0)
            {
                return coueses[0];
            }

            return null;
        }
    }
}