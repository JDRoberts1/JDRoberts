using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace JeanaiRoberts_CE02
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();
        DataTable movieData = new DataTable();

        int row;
        bool create;
        MovieObject newMovie;
        ListViewItem lvi;

        public EventHandler ViewMovie;
        public EventHandler<ModifyObjectEventArgs> ModifyObject;

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();

            string connectionString = DBUtilities.BuildConnectionString();
            conn = DBUtilities.Connect(connectionString);

            RetrieveData();
        }

        public MovieObject MovieInfo
        {
            get
            {
                newMovie = new MovieObject();
                newMovie.Title = txtTitle.Text;
                newMovie.Year = numYear.Value;
                newMovie.Publisher = cmbPublisher.Text;
                newMovie.Author = txtAuthor.Text;
                newMovie.Genre = cmbGenre.Text;

                // Assign an appropriate ImageList icon to each record.
                if (newMovie.Year == 2001)
                {
                    newMovie.Index = 0;
                }
                else if (newMovie.Year == 2002)
                {
                    newMovie.Index = 1;
                }
                else if (newMovie.Year == 2004)
                {
                    newMovie.Index = 2;
                }
                else if (newMovie.Year == 2005)
                {
                    newMovie.Index = 3;
                }
                else if (newMovie.Year == 2007)
                {
                    newMovie.Index = 4;
                }
                else if (newMovie.Year == 2009)
                {
                    newMovie.Index = 5;
                }
                else if (newMovie.Year == 2010)
                {
                    newMovie.Index = 6;
                }
                else if (newMovie.Year == 2011)
                {
                    newMovie.Index = 7;
                }

                return newMovie;
            }

            set
            {
                txtTitle.Text = value.Title;
                numYear.Value = value.Year;
                cmbPublisher.Text = value.Publisher;
                txtAuthor.Text = value.Author;
                cmbGenre.Text = value.Genre;
            }
        }

        // Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        // ability to add new records.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Each of the fields should be validated.
            ValidateInput();

            if (create == true)
            {
                newMovie = new MovieObject();
                newMovie.Title = txtTitle.Text;
                newMovie.Year = numYear.Value;
                newMovie.Publisher = cmbGenre.Text;
                newMovie.Author = txtAuthor.Text;
                newMovie.Genre = cmbGenre.Text;

                lvi = new ListViewItem();
                lvi.Tag = newMovie;
                lvi.ImageIndex = newMovie.Index;
                lvi.Text = newMovie.ToString();

                lvMovies.Items.Add(lvi);

                // application must be able to pass information to and from a database
                string sql = "INSERT INTO SeriesTitles (Title, YearReleased, Publisher, Author, Genre) VALUES (@Title, @YearReleased, @Publisher, @Author, @Genre);";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Title", newMovie.Title);
                cmd.Parameters.AddWithValue("@YearReleased", newMovie.Year);
                cmd.Parameters.AddWithValue("@Publisher", newMovie.Publisher);
                cmd.Parameters.AddWithValue("@Author", newMovie.Author);
                cmd.Parameters.AddWithValue("@Genre", newMovie.Genre);

                MySqlDataReader rdr = cmd.ExecuteReader();

                btnSave.Visible = false;
                btnCancel.Visible = false;

                rdr.Close();
            }
        }

        // ability for the user to move through the records.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (row -1 >= 0)
            {
                row--;

                MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
            }
        }

        // ability for the user to move through the records.
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (row + 1 < lvMovies.Items.Count)
            {
                row++;

                MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
            }
        }

        // Makes applt button visable to save edited object
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnApply.Visible = true;
            btnCancel.Visible = true;

            if ( lvMovies.SelectedItems.Count > 0)
            {
                MovieInfo = (MovieObject)lvMovies.SelectedItems[0].Tag;
            }
            else
            {
                MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModifyObject += HandleModifyObject;
        }

        // ability for the user to edit an individual record.
        private void btnApply_Click(object sender, EventArgs e)
        {
            newMovie = new MovieObject();
            newMovie.Title = txtTitle.Text;
            newMovie.Year = numYear.Value;
            newMovie.Publisher = cmbPublisher.Text;
            newMovie.Author = txtAuthor.Text;
            newMovie.Genre = cmbGenre.Text;

            // Assign an appropriate ImageList icon to each record.
            if (newMovie.Year == 2001)
            {
                newMovie.Index = 0;
            }
            else if (newMovie.Year == 2002)
            {
                newMovie.Index = 1;
            }
            else if (newMovie.Year == 2004)
            {
                newMovie.Index = 2;
            }
            else if (newMovie.Year == 2005)
            {
                newMovie.Index = 3;
            }
            else if (newMovie.Year == 2007)
            {
                newMovie.Index = 4;
            }
            else if (newMovie.Year == 2009)
            {
                newMovie.Index = 5;
            }
            else if (newMovie.Year == 2010)
            {
                newMovie.Index = 6;
            }
            else if (newMovie.Year == 2011)
            {
                newMovie.Index = 7;
            }

            // Each of the fields should be validated.
            ValidateInput();

            if (create == true)
            {
                if (ModifyObject != null)
                {
                    ModifyObject(this, new ModifyObjectEventArgs(newMovie));
                }
            }
        }

        // ability for the user to delete an individual record.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MovieObject title = (MovieObject)lvMovies.SelectedItems[0].Tag;

            // application must be able to pass information to and from a database
            string sql = "DELETE FROM SeriesTitles WHERE Title = @Title;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", title.Title);

            MySqlDataReader rdr = cmd.ExecuteReader();

            lvMovies.Items.Remove(lvMovies.SelectedItems[0]);

            rdr.Close();
        }

        // cancels input and hides buttons
        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideBTN();
            MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
        }

        // ability for the user to save the records as a list that can be printed.
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("Series List");

                        foreach (ListViewItem m in lvMovies.Items)
                        {
                            sw.WriteLine(m.Tag);
                        }
                        
                        sw.Close();
                    }
                }
            }
        }

        // Handlers

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

        // application must be able to pass information to and from a database
        private bool RetrieveData()
        {
            if (conn == null)
            {
                return false;
            }
            else
            {
                // application must be able to pass information to and from a database
                string sql = "SELECT Title, YearReleased, Publisher, Author, Genre FROM SeriesTitles LIMIT 10;";

                MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

                adr.SelectCommand.CommandType = CommandType.Text;

                adr.Fill(movieData);

                AddToListView(movieData);

                return true;
            }
        }

        private void AddToListView(DataTable data)
        {
            foreach (DataRow item in data.Rows)
            {
                newMovie = new MovieObject();

                newMovie.Title = item["Title"].ToString();
                string year = item["YearReleased"].ToString();
                newMovie.Year = Convert.ToDecimal(year);
                newMovie.Publisher = item["Publisher"].ToString();
                newMovie.Author = item["Author"].ToString();
                newMovie.Genre = item["Genre"].ToString();

                // Assign an appropriate ImageList icon to each record.
                if (newMovie.Year == 2001)
                {
                    newMovie.Index = 0;
                }
                else if (newMovie.Year == 2002)
                {
                    newMovie.Index = 1;
                }
                else if (newMovie.Year == 2004)
                {
                    newMovie.Index = 2;
                }
                else if (newMovie.Year == 2005)
                {
                    newMovie.Index = 3;
                }
                else if (newMovie.Year == 2007)
                {
                    newMovie.Index = 4;
                }

                lvi = new ListViewItem();
                lvi.Tag = newMovie;
                lvi.ImageIndex = newMovie.Index;
                lvi.Text = newMovie.ToString();

                lvMovies.Items.Add(lvi);

                // Once data is loaded, The first record should populate user input controls
                MovieInfo = (MovieObject)lvMovies.Items[0].Tag;

            }
        }

        // handler method to edit Movie object
        public void HandleModifyObject(object sender, ModifyObjectEventArgs e)
        {
            MovieObject m = e.CourseToModify1 as MovieObject;

            if (lvMovies.SelectedItems != null)
            {
                lvMovies.SelectedItems[0].Text = m.ToString();
                lvMovies.SelectedItems[0].Tag = m; ;
                lvMovies.SelectedItems[0].ImageIndex = m.Index;

            }

            int sqlIndex = lvMovies.SelectedItems[0].Index + 1;

            // application must be able to pass information to and from a database
            string sql = "UPDATE SeriesTitles SET Title = @Title, YearReleased = @YearReleased, Publisher = @Publisher, Author = @Author, Genre = @Genre WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", sqlIndex);
            cmd.Parameters.AddWithValue("@Title", m.Title);
            cmd.Parameters.AddWithValue("@YearReleased", m.Year);
            cmd.Parameters.AddWithValue("@Publisher", m.Publisher);
            cmd.Parameters.AddWithValue("@Author", m.Author);
            cmd.Parameters.AddWithValue("@Genre", m.Genre);


            MySqlDataReader rdr = cmd.ExecuteReader();

            btnApply.Visible = false;
            btnCancel.Visible = false;

            rdr.Close();
        }

        // Methods

        void HideBTN()
        {
            btnApply.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        void ClearInput()
        {
            txtTitle.Clear();
            numYear.Value = 2000;
            cmbPublisher.Text = null;
            txtAuthor.Clear();
            cmbGenre.Text = null;
        }

        // validates input fields
        public void ValidateInput()
        {
            if (txtTitle.Text == "" && cmbPublisher.Text == "" && txtAuthor.Text == "" && cmbGenre.Text == "")
            {
                // display popup box  
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please do not leave the Title blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            string sYear = Convert.ToString(numYear.Value);
            int year;
            bool sucess = int.TryParse(sYear, out year);

            if (year != 2001)
            {
                // Include error messages for incorrect input.
                MessageBox.Show("Invalid year please use: \n 2001-2002, 2004-2005, 2007, 2009 - 2011", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numYear.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPublisher.Text))
            {
                // Include error messages for incorrect input.
                MessageBox.Show("Please do not leave the Publisher blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPublisher.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                // Include error messages for incorrect input.
                MessageBox.Show("Please do not leave the Author blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbGenre.Text))
            {
                // Include error messages for incorrect input.
                MessageBox.Show("Please do not leave the Genre blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGenre.Focus();
                return;
            }

            // if all fields are correct return true
            create = true;
        }
    }
}
