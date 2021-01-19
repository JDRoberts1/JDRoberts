using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JeanaiRoberts_CE02
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();
        DataTable movieData = new DataTable();

        int row;
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

        private void btnSave_Click(object sender, EventArgs e)
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

            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (row -1 >= 0)
            {
                row--;

                MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (row + 1 < lvMovies.Items.Count)
            {
                row++;

                MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnApply.Visible = true;
            btnCancel.Visible = true;

            if( lvMovies.SelectedItems.Count > 0)
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

        private void btnApply_Click(object sender, EventArgs e)
        {

            newMovie = new MovieObject();

            newMovie.Title = txtTitle.Text;
            newMovie.Year = numYear.Value;
            newMovie.Publisher = cmbPublisher.Text;
            newMovie.Author = txtAuthor.Text;
            newMovie.Genre = cmbGenre.Text;

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


            if (ModifyObject != null)
            {
                ModifyObject(this, new ModifyObjectEventArgs(newMovie));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lvMovies.Items.Remove(lvMovies.SelectedItems[0]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideBTN();
            MovieInfo = (MovieObject)lvMovies.Items[row].Tag;
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

        private bool RetrieveData()
        {
            if (conn == null)
            {
                return false;
            }
            else
            {
                string sql = "SELECT Title, YearReleased, Publisher, Author, Genre FROM SeriesTitles LIMIT 5;";

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
                MovieInfo = (MovieObject)lvMovies.Items[0].Tag;

            }
        }

        public void HandleModifyObject(object sender, ModifyObjectEventArgs e)
        {
            MovieObject m = e.CourseToModify1 as MovieObject;

            if (lvMovies.SelectedItems != null)
            {
                lvMovies.SelectedItems[0].Text = m.ToString();
                lvMovies.SelectedItems[0].Tag = m; ;
                lvMovies.SelectedItems[0].ImageIndex = m.Index;

            }

            btnApply.Visible = false;
            btnCancel.Visible = false;
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
    }
}
