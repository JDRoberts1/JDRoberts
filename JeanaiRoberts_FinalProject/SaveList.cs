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
    public partial class SaveList : Form
    {
        public string selectedList;

        public SaveList()
        {
            InitializeComponent();
        }

        public void ComboBoxLoad(List<string> movieLists)
        {
            foreach (string m in movieLists)
            {
                comboBox1.Items.Add(m);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                selectedList = comboBox1.Text;
            }

            Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
