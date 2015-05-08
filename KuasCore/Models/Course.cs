using System;

namespace KuasCore.Models
{
    public class Course
    {
        public string Course_ID { get; set; }

        public string Course_Name { get; set; }

        public string Course_Description { get; set; }

        public override string ToString()
        {
            return "Course: Id = " + Course_ID + ", Name = " + Course_Name + ".";
        }
    }
}