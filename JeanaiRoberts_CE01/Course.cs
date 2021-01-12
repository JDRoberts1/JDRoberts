using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanaiRoberts_CE01
{
    // Class to build course object
    public class Course
    {
        string courseName;
        bool courseComplete;
        string courseDate;
        string courseColor;

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public bool CourseComplete
        {
            get
            {
                return courseComplete;
            }

            set
            {
                courseComplete = value;
            }
        }

        public string CourseDate
        {
            get
            {
                return courseDate;
            }

            set
            {
                courseDate = value;
            }
        }

        public string CourseColor
        {
            get
            {
                return courseColor;
            }

            set
            {
                courseColor = value;
            }
        }

        public override string ToString()
        {
            
            return $"{CourseName} Course complete: {CourseComplete} Date: {CourseDate}";
        }
    }
}
