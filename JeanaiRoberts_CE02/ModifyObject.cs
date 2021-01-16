using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanaiRoberts_CE02
{
    public class ModifyObjectEventArgs : EventArgs
    {
        MovieObject modifyMovie;

        public MovieObject CourseToModify1
        {
            get
            {
                return modifyMovie;
            }

            set
            {
                modifyMovie = value;
            }
        }

        public ModifyObjectEventArgs(MovieObject eCouse)
        {
            modifyMovie = eCouse;
        }
    }
}
