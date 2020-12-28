using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            MediaPlayerComponent.URL = textBox1.Text;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MediaPlayerComponent.Ctlcontrols.play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            MediaPlayerComponent.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MediaPlayerComponent.Ctlcontrols.stop();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
