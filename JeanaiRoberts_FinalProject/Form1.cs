using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using RestSharp;
using System.Xml;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace JeanaiRoberts_FinalProject
{
    public partial class Form1 : Form
    {
        string API = "http://www.omdbapi.com/?apikey=1a2565db&t=";
        string APIEndPoint;

        ListView listView;
        movieData newMovie;

        public EventHandler AddToListView;
        WebClient apiConnection = new WebClient();
        MySqlConnection conn = new MySqlConnection();
        

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();

            string connectionString = DBUtilities.BuildConnectionString();
            conn = DBUtilities.Connect(connectionString);
        }

        private void BuildAPI()
        {
            string sTitle = ReturnTitle();

            APIEndPoint = API + sTitle;
        }
        
        private string ReturnTitle()
        {
            string apiTitle = txtSearch.Text.Replace(" ", "-");

            return apiTitle;
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

        private void ReadTheJSONData()
        {
            // the var dataType lets the application decide what dataType to use when the code runs
            var apiData = apiConnection.DownloadString(APIEndPoint);
            
            // parse the datastring to a JObject
            JObject o = JObject.Parse(apiData);

            // string variable to hold specific data from the JSON object 
            // The second set of square brackets indicates that we want to see the very first element in the array of JSON Data
            txtTitle.Text = o["Title"].ToString();
            dateReleased.Text = o["Released"].ToString();
            txtRating.Text = o["Rated"].ToString();
            txtRuntime.Text = o["Runtime"].ToString();
            txtGenre.Text = o["Genre"].ToString();
            txtPlot.Text = o["Plot"].ToString();

            txtSearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildAPI();
            ReadTheJSONData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listView = new ListView();

            
            listView.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView = new ListView();

            AddToListView += new EventHandler(listView.HandleAddTOListView);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listView = new ListView();
            newMovie = new movieData();
            newMovie.MovieTitle = txtTitle.Text;
            newMovie.ReleaseDate = dateReleased.Text;
            newMovie.Rated = txtRating.Text;
            newMovie.Genre = txtGenre.Text;
            newMovie.Runtime = txtRuntime.Text;
            newMovie.Plot = txtPlot.Text;

            sender = newMovie;

            if(AddToListView != null)
            {
                AddToListView(sender, new EventArgs());
            }

            // application must be able to pass information to and from a database
            string sql = "INSERT INTO SeriesTitles (MovieTitle, DateReleased, Rated, Genre, Runtime, Plot) VALUES (@MovieTitle, @DateReleased, @Rated, @Genre, @Runtime, @Plot);";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MovieTitle", newMovie.MovieTitle);
            cmd.Parameters.AddWithValue("@DateReleased", newMovie.ReleaseDate);
            cmd.Parameters.AddWithValue("@Rated", newMovie.Rated);
            cmd.Parameters.AddWithValue("@Genre", newMovie.Genre);
            cmd.Parameters.AddWithValue("@Runtime", newMovie.Runtime);
            cmd.Parameters.AddWithValue("@Plot", newMovie.Plot);

            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Handlers

    }
}
