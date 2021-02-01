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

        public ListView()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        //Call this method AFTER InitializeComponent() inside the form's constructor.

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

        public void HandleAddTOListView(object sender, EventArgs e)
        {

            movieData movie = (sender as movieData);

            ListViewItem lvi = new ListViewItem();

            lvi.Tag = movie;
            lvi.Text = movie.ToString();

            listView1.Items.Add(lvi);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            movieData title = (movieData)listView1.SelectedItems[0].Tag;

            sender = title;

            DeleteMovie?.Invoke(sender, new EventArgs());

            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
