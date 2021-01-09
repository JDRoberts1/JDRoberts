using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanaiRoberts_CE01
{
    public partial class UserInput : Form
    {
        public EventHandler AddToListBox;
        Course newCourse;
        

        public UserInput()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        void HandleClientWindowSize()
        {
            //Modify ONLY these float values

            float HeightValueToChange = 1.4f;

            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE

            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);

            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);

            if (height < Size.Height)

                height = Size.Height;

            if (width < Size.Width)

                width = Size.Width;

            //this.Size = new Size(width, height);

            this.Size = new Size(376, 720);

        }

        void ClearInput()
        {
            txtClassName.Clear();
            chkTaken.Checked = false;
            dateClassDate.Value = DateTime.Now;
            rdoRed.Checked = false;
            rdoBlue.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newCourse = new Course();
            newCourse.CourseName = txtClassName.Text;
            newCourse.CourseComplete = chkTaken.Checked;

            newCourse.CourseDate = dateClassDate.Value.ToShortDateString();

            if(rdoRed.Checked == true)
            {
                newCourse.CourseColor = "Red";

            }
            else if (rdoBlue.Checked == true)
            {
                newCourse.CourseColor = "Blue";
            }
            else
            {
                newCourse.CourseColor = "Black";
            }

            sender = newCourse;

            AddToListBox?.Invoke(sender, new EventArgs());

            ClearInput();
        }
    }
}
