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

        // Methods
        private bool RetrieveData()
        {
            if(conn == null)
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
            foreach(DataRow item in data.Rows)
            {
                newMovie = new MovieObject();

                newMovie.Title = item["Title"].ToString();
                string year = item["YearReleased"].ToString();
                newMovie.Year = Convert.ToDecimal(year);
                newMovie.Publisher = item["Publisher"].ToString();
                newMovie.Author = item["Author"].ToString();
                newMovie.Genre = item["Genre"].ToString();

                if(newMovie.Year == 2001)
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

        void ClearInput()
        {
            txtTitle.Clear();
            numYear.Value = 2000;
            cmbPublisher.Text = null;
            txtAuthor.Clear();
            cmbGenre.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newMovie = new MovieObject();

            while (String.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a vaild input!");
                newMovie.Title = txtTitle.Text;
            }
            



            newMovie.Year = numYear.Value;
            newMovie.Publisher = cmbGenre.Text;
            newMovie.Author = txtAuthor.Text;
            newMovie.Genre = cmbGenre.Text;

            lvi = new ListViewItem();
            lvi.Tag = newMovie;
            lvi.ImageIndex = newMovie.Index;
            lvi.Text = newMovie.ToString();

            lvMovies.Items.Add(lvi);

            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(row -1 >= 0)
            {
                row--;

                txtTitle.Text = movieData.Rows[row]["Title"].ToString();
                string yearString = movieData.Rows[row]["YearReleased"].ToString();
                numYear.Value = Convert.ToDecimal(yearString);
                cmbPublisher.Text = movieData.Rows[row]["Publisher"].ToString();
                txtAuthor.Text = movieData.Rows[row]["Author"].ToString();
                cmbGenre.Text = movieData.Rows[row]["Genre"].ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (row + 1 < movieData.Select().Length)
            {
                row++;

                txtTitle.Text = movieData.Rows[row]["Title"].ToString();
                string yearString = movieData.Rows[row]["YearReleased"].ToString();
                numYear.Value = Convert.ToDecimal(yearString);
                cmbPublisher.Text = movieData.Rows[row]["Publisher"].ToString();
                txtAuthor.Text = movieData.Rows[row]["Author"].ToString();
                cmbGenre.Text = movieData.Rows[row]["Genre"].ToString();
            }
        }
    }
}
