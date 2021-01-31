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

namespace JeanaiRoberts_FinalProject
{
    public partial class Form1 : Form
    {
        WebClient apiConnection = new WebClient();

        string API = "http://www.omdbapi.com/?apikey=1a2565db&t=";

        string APIEndPoint;

        ListView listView;
        SaveList selectList;
        newList newList;
        movieData newMovie;

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        private void BuildAPI()
        {
            string sTitle = ReturnTitle();

            APIEndPoint = API + sTitle;
        }
        
        private string ReturnTitle()
        {
            string apiTitle = textBox1.Text.Replace(" ", "-");

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
            textBox2.Text = o["Title"].ToString();
            textBox3.Text = o["Released"].ToString();
            textBox4.Text = o["Rated"].ToString();
            textBox8.Text = o["Runtime"].ToString();
            textBox5.Text = o["Genre"].ToString();
            textBox6.Text = o["Plot"].ToString();

            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildAPI();
            ReadTheJSONData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listView = new ListView();
            listView.Show();
        }
    }
}
