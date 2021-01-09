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
    public partial class Form1 : Form
    {
        UserInput movieInput = new UserInput();
        
        List<Course> compCourse;


        public Form1()
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

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            movieInput.ShowDialog();
        }

        public void HandleAddToList(object sender, EventArgs e)
        {
            Course newCourse = (Course)sender;

            if(newCourse.CourseComplete != true)
            {
                lbNotTaken.Items.Add(newCourse.ToString());
            }
            else
            {
                lbComplete.Items.Add(newCourse.ToString());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movieInput.AddToListBox += new EventHandler(HandleAddToList);
        }
    }
}
