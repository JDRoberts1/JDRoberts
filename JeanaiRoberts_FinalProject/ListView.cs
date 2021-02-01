using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanaiRoberts_FinalProject
{
    public partial class ListView : Form
    {
        public EventHandler DeleteMovie;
        public EventHandler RetrieveData;
        public EventHandler DisplayMovie;

        public ListView()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        // Handles the iPhone backgrond imgae
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

            this.Size = new Size(width, height);

            this.Size = new Size(376, 720);
        }

        // Handles the event handler for adding a new movie to the listbox
        public void HandleAddToList(object sender, EventArgs e)
        {
            movieData movie = (movieData)sender;

            listBox1.Items.Add(movie);
        }

        // Handles the Event Handler for loading the database into the listbox
        public void HandleLoadList(object sender, EventArgs e)
        {
            List<movieData> movies = (List<movieData>)sender;

            HandleClearList();

            foreach (movieData m in movies)
            {
                listBox1.Items.Add(m);
            }
        }

        // removes the movie object from the listbox
        private void btnDelete_Click(object sender, EventArgs e)
        {
            movieData title = (movieData)listBox1.SelectedItems[0];

            sender = title;

            DeleteMovie?.Invoke(sender, new EventArgs());

            listBox1.Items.Remove(listBox1.SelectedItems[0]);
        }

        // Clears the listbox
        public void HandleClearList()
        {
            listBox1.Items.Clear();
        }

        // display the selected movie object
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sender = (movieData)listBox1.SelectedItem;

            if (DisplayMovie != null)
            {
                DisplayMovie(sender, new EventArgs());
            }
        }
    }
}
