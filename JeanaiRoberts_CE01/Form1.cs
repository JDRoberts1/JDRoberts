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
        public EventHandler DisplaySelectedItem;

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        // Events

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            movieInput.AddButton();
            movieInput.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movieInput.AddToListBox += new EventHandler(HandleAddToList);
            DisplaySelectedItem += new EventHandler(movieInput.HandleDisplay);
            movieInput.ModifyCourse += new EventHandler<ModifyCourseEventArgs>(HandleModifyObject);
        }

        
        private void bttnMove_Click(object sender, EventArgs e)
        {
            if(lbComplete.SelectedItem != null)
            {
                ((Course)lbComplete.SelectedItem).CourseComplete = false;

                if (((Course)lbComplete.SelectedItem).CourseColor == "Red")
                {
                    lbNotTaken.ForeColor = Color.Red;
                    MoveItem(lbComplete, lbNotTaken);
                }
                else if (((Course)lbComplete.SelectedItem).CourseColor == "Blue")
                {
                    lbNotTaken.ForeColor = Color.Blue;
                    MoveItem(lbComplete, lbNotTaken);
                }
                else
                {
                    lbNotTaken.ForeColor = default;
                    MoveItem(lbComplete, lbNotTaken);
                }
            }

            if(lbNotTaken.SelectedItem != null)
            {
                ((Course)lbNotTaken.SelectedItem).CourseComplete = true;

                if (((Course)lbNotTaken.SelectedItem).CourseColor == "Red")
                {
                    lbComplete.ForeColor = Color.Red;
                    MoveItem(lbNotTaken, lbComplete);
                }
                else if (((Course)lbNotTaken.SelectedItem).CourseColor == "Blue")
                {
                    lbComplete.ForeColor = Color.Blue;
                    MoveItem(lbNotTaken, lbComplete);
                }
                else
                {
                    lbComplete.ForeColor = default;
                    MoveItem(lbNotTaken, lbComplete);
                }
            }
        }

        // Handler Methods

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
        public void HandleAddToList(object sender, EventArgs e)
        {
            Course newCourse = (Course)sender;

            if (newCourse.CourseComplete != true)
            {
                if (newCourse.CourseColor == "Red")
                {
                    lbNotTaken.ForeColor = Color.Red;
                    lbNotTaken.Items.Add(newCourse);
                }
                else if (newCourse.CourseColor == "Blue")
                {
                    lbNotTaken.ForeColor = Color.Blue;
                    lbNotTaken.Items.Add(newCourse);
                }
                else
                {
                    lbNotTaken.ForeColor = default;
                    lbNotTaken.Items.Add(newCourse);
                }
            }
            else
            {
                if (newCourse.CourseColor == "Red")
                {
                    lbComplete.ForeColor = Color.Red;
                    lbComplete.Items.Add(newCourse);
                }
                else if (newCourse.CourseColor == "Blue")
                {
                    lbComplete.ForeColor = Color.Blue;
                    lbComplete.Items.Add(newCourse);
                }
                else
                {
                    lbComplete.ForeColor = default;
                    lbComplete.Items.Add(newCourse.ToString());
                }
            }
        }

        public void HandleModifyObject(object sender, ModifyCourseEventArgs e)
        {
            Course c = e.CourseToModify1 as Course;

            if(lbComplete.SelectedItem != null)
            {
                ((Course)lbComplete.SelectedItem).CourseName = c.CourseName;
                ((Course)lbComplete.SelectedItem).CourseComplete = c.CourseComplete;
                ((Course)lbComplete.SelectedItem).CourseDate = c.CourseDate;
                ((Course)lbComplete.SelectedItem).CourseColor = c.CourseColor;

                if(c.CourseComplete != true)
                {
                    MoveItem(lbComplete, lbNotTaken);
                }
            }
            else if(lbNotTaken.SelectedItem != null)
            {
                ((Course)lbNotTaken.SelectedItem).CourseName = c.CourseName;
                ((Course)lbNotTaken.SelectedItem).CourseComplete = c.CourseComplete;
                ((Course)lbNotTaken.SelectedItem).CourseDate = c.CourseDate;
                ((Course)lbNotTaken.SelectedItem).CourseColor = c.CourseColor;

                if (c.CourseComplete != false)
                {
                    MoveItem(lbNotTaken, lbComplete);
                }
            }
        }

        // Methods

        private void MoveItem (ListBox lstfrm, ListBox lstto)
        {
            while(lstfrm.SelectedItems.Count > 0)
            {
                Course course = (Course)lstfrm.SelectedItems[0];
                lstto.Items.Add(course);
                lstfrm.Items.Remove(course);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            lbComplete.Items.Remove(lbComplete.SelectedItem);
            lbNotTaken.Items.Remove(lbNotTaken.SelectedItem);
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            movieInput.SaveButton();
            movieInput.Show();

            if (lbComplete.SelectedItem != null)
            {
                sender = ((Course)lbComplete.SelectedItem);
            }

            if(lbNotTaken.SelectedItem != null)
            {
                sender = ((Course)lbNotTaken.SelectedItem);
            }


            if (DisplaySelectedItem != null)
            {
                DisplaySelectedItem(sender, new EventArgs());
            }
            
        }
    }
}
