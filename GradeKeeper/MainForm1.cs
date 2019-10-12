using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GradeKeeper
{
    public partial class MainForm1 : Form
    {
        private GradeBook mGradeBook;

        public GradeBook GradeBook 
        { 
            get => mGradeBook;
            set
            {
                if (mGradeBook != value)
                {
                    mGradeBook = value;
                    gradeBookBindingSource.DataSource = mGradeBook;
                }
            }
        }

        public MainForm1()
        {
            InitializeComponent();
            GradeBook = new GradeBook();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonText = File.ReadAllText(OpenFileDialog.FileName);
                GradeBook = JsonConvert.DeserializeObject<GradeBook>(jsonText);
                GradeBook.FileName = OpenFileDialog.FileName;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
