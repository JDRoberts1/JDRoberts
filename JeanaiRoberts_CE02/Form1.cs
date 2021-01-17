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
        
    }
}
