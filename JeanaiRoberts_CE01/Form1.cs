using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JeanaiRoberts_CE01
{
    public partial class Form1 : Form
    {
        UserInput movieInput = new UserInput();
        public EventHandler DisplaySelectedItem;
        public EventHandler SaveXML;
        public EventHandler LoadXML;
        Course newCourse;

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        // Events

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            
            if (movieInput == null)
            {
                movieInput = new UserInput();
            }

            movieInput.AddButton();
            movieInput.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movieInput.AddToListBox += new EventHandler(HandleAddToList);
            DisplaySelectedItem += new EventHandler(movieInput.HandleDisplay);
            movieInput.ModifyCourse += new EventHandler<ModifyCourseEventArgs>(HandleModifyObject);
            SaveXML += new EventHandler(HandleSaveXML);
            LoadXML += new EventHandler(HandleLoadXML);
        }

        
        private void bttnMove_Click(object sender, EventArgs e)
        {
            if(lbComplete.SelectedItem != null)
            {
                if (((Course)lbComplete.SelectedItem).CourseColor == "Red")
                {
                    lbNotTaken.ForeColor = Color.Red;
                }
                else if (((Course)lbComplete.SelectedItem).CourseColor == "Blue")
                {
                    lbNotTaken.ForeColor = Color.Blue;
                }
                else
                {
                    lbNotTaken.ForeColor = default;
                }

                ((Course)lbComplete.SelectedItem).CourseComplete = false;
                MoveItem(lbComplete, lbNotTaken);
            }

            if(lbNotTaken.SelectedItem != null)
            {
                if (((Course)lbNotTaken.SelectedItem).CourseColor == "Red")
                {
                    lbComplete.ForeColor = Color.Red;
                }
                else if (((Course)lbNotTaken.SelectedItem).CourseColor == "Blue")
                {
                    lbComplete.ForeColor = Color.Blue;
                }
                else
                {
                    lbComplete.ForeColor = default;
                }

                ((Course)lbNotTaken.SelectedItem).CourseComplete = true;
                MoveItem(lbNotTaken, lbComplete);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            lbComplete.Items.Remove(lbComplete.SelectedItem);
            lbNotTaken.Items.Remove(lbNotTaken.SelectedItem);
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if(movieInput == null)
            {
                movieInput = new UserInput();
            }

            if (lbComplete.SelectedItem != null)
            {
                sender = ((Course)lbComplete.SelectedItem);
            }

            if (lbNotTaken.SelectedItem != null)
            {
                sender = ((Course)lbNotTaken.SelectedItem);
            }


            if (DisplaySelectedItem != null)
            {
                DisplaySelectedItem(sender, new EventArgs());
            }

            movieInput.SaveButton();
            movieInput.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveXML != null)
            {
                SaveXML(sender, new EventArgs());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveXML != null)
            {
                SaveXML(sender, new EventArgs());
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadXML != null)
            {
                LoadXML(sender, new EventArgs());
            }
        }

        private void lbNotTaken_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbNotTaken.SelectedItem != null)
            {
                lbComplete.SelectedIndex = -1;
            }
        }

        private void lbComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbComplete.SelectedItem != null)
            {
                lbNotTaken.SelectedIndex = -1;
            }
        }

        private void lbNotTaken_DoubleClick(object sender, EventArgs e)
        {
            if (movieInput == null)
            {
                movieInput = new UserInput();
            }

            if (lbNotTaken.SelectedItem != null)
            {
                sender = ((Course)lbNotTaken.SelectedItem);
            }

            if (DisplaySelectedItem != null)
            {
                DisplaySelectedItem(sender, new EventArgs());
            }

            movieInput.NoButton();
            movieInput.ShowDialog();
        }

        private void lbComplete_DoubleClick(object sender, EventArgs e)
        {
            if (movieInput == null)
            {
                movieInput = new UserInput();
            }

            if (lbComplete.SelectedItem != null)
            {
                sender = ((Course)lbComplete.SelectedItem);
            }

            if (DisplaySelectedItem != null)
            {
                DisplaySelectedItem(sender, new EventArgs());
            }

            movieInput.NoButton();
            movieInput.ShowDialog();
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
                    lbComplete.Items.Add(newCourse);
                }
            }
        }

        public void HandleModifyObject(object sender, ModifyCourseEventArgs e)
        {
            Course c = e.CourseToModify1 as Course;

            if (lbComplete.SelectedItem != null)
            {
                ((Course)lbComplete.SelectedItem).CourseName = c.CourseName;
                ((Course)lbComplete.SelectedItem).CourseComplete = c.CourseComplete;
                ((Course)lbComplete.SelectedItem).CourseDate = c.CourseDate;
                ((Course)lbComplete.SelectedItem).CourseColor = c.CourseColor;

                if (c.CourseColor == "Red")
                {
                    lbComplete.ForeColor = Color.Red;

                    if (c.CourseComplete != true)
                    {
                        lbNotTaken.ForeColor = Color.Red;
                        MoveItem(lbComplete, lbNotTaken);
                    }

                }
                else if (c.CourseColor == "Blue")
                {
                    lbComplete.ForeColor = Color.Blue;

                    if (c.CourseComplete != true)
                    {
                        lbNotTaken.ForeColor = Color.Blue;
                        MoveItem(lbComplete, lbNotTaken);
                    }
                }
                else
                {
                    lbComplete.ForeColor = default;

                    if (c.CourseComplete != true)
                    {
                        lbNotTaken.ForeColor = Color.Blue;
                        MoveItem(lbComplete, lbNotTaken);
                    }
                }


            }
            else if (lbNotTaken.SelectedItem != null)
            {
                ((Course)lbNotTaken.SelectedItem).CourseName = c.CourseName;
                ((Course)lbNotTaken.SelectedItem).CourseComplete = c.CourseComplete;
                ((Course)lbNotTaken.SelectedItem).CourseDate = c.CourseDate;
                ((Course)lbNotTaken.SelectedItem).CourseColor = c.CourseColor;

                if (c.CourseColor == "Red")
                {
                    lbNotTaken.ForeColor = Color.Red;

                    if (c.CourseComplete != false)
                    {
                        lbComplete.ForeColor = Color.Red;
                        MoveItem(lbNotTaken, lbComplete);
                    }
                }
                else if (c.CourseColor == "Blue")
                {
                    lbNotTaken.ForeColor = Color.Blue;

                    if (c.CourseComplete != false)
                    {
                        lbComplete.ForeColor = Color.Blue;
                        MoveItem(lbNotTaken, lbComplete);
                    }
                }
                else
                {
                    lbNotTaken.ForeColor = default;

                    if (c.CourseComplete != false)
                    {
                        lbComplete.ForeColor = default;
                        MoveItem(lbNotTaken, lbComplete);
                    }
                }
            }
        }

        void HandleSaveXML(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "xml";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;

                settings.Indent = true;

                using (XmlWriter writer = XmlWriter.Create(dlg.FileName, settings))
                {
                    writer.WriteStartElement("CourseList");

                    if (lbComplete.Items.Count > 0)
                    {
                        foreach (Course c in lbComplete.Items)
                        {
                            writer.WriteElementString("CourseName", c.CourseName);
                            writer.WriteElementString("CourseComplete", c.CourseComplete.ToString().ToLower());
                            writer.WriteElementString("CourseDate", c.CourseDate);
                            writer.WriteElementString("CourseColor", c.CourseColor);
                        }
                    }

                    if (lbNotTaken.Items.Count > 0)
                    {
                        foreach (Course c in lbNotTaken.Items)
                        {
                            writer.WriteElementString("CourseName", c.CourseName);
                            writer.WriteElementString("CourseComplete", c.CourseComplete.ToString().ToLower());
                            writer.WriteElementString("CourseDate", c.CourseDate);
                            writer.WriteElementString("CourseColor", c.CourseColor);
                        }
                    }

                    writer.WriteEndElement();
                }
            }
        }

        void HandleLoadXML(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                XmlReaderSettings rSettings = new XmlReaderSettings();
                rSettings.ConformanceLevel = ConformanceLevel.Document;

                rSettings.IgnoreComments = true;
                rSettings.IgnoreWhitespace = true;

                using (XmlReader reader = XmlReader.Create(dlg.FileName, rSettings))
                {
                    reader.MoveToContent();

                    if (reader.Name != "CourseList")
                    {
                        MessageBox.Show("Please select a proper file.");
                        return;
                    }

                    while (reader.Read())
                    {
                        Course newCourse = new Course();

                        if (reader.Name == "CourseName" && reader.IsStartElement())
                        {
                            newCourse.CourseName = reader.ReadElementContentAsString();

                            if (reader.Name == "CourseComplete")
                            {
                                newCourse.CourseDate = reader.ReadElementContentAsString();
                            }
                            if (reader.Name == "CourseDate")
                            {
                                newCourse.CourseDate = reader.ReadElementContentAsString();
                            }
                            if (reader.Name == "CourseColor")
                            {
                                newCourse.CourseColor = reader.ReadElementContentAsString();
                            }

                            if (newCourse.CourseComplete == true)
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
                                    lbComplete.Items.Add(newCourse);
                                }
                            }
                            else
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
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        // Methods

        private void MoveItem(ListBox lstfrm, ListBox lstto)
        {
            while (lstfrm.SelectedItems.Count > 0)
            {
                Course course = (Course)lstfrm.SelectedItems[0];
                lstto.Items.Add(course);
                lstfrm.Items.Remove(course);
            }
        }
    }
}
