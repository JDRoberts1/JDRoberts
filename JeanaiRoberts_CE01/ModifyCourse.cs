using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanaiRoberts_CE01
{
    public class ModifyCourseEventArgs : EventArgs
    {
        Course modifyCourse;

        public Course CourseToModify1
        {
            get
            {
                return modifyCourse;
            }

            set
            {
                modifyCourse = value;
            }
        }

        public ModifyCourseEventArgs(Course eCouse)
        {
            modifyCourse = eCouse;
        }
    }
}
