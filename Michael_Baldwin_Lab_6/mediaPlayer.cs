using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michael_Baldwin_Lab_6
{
    public partial class mediaPlayer : Form
    {
        public mediaPlayer()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            if (browseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pathTextBox.Text = browseFile.FileName;
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            mainWindowsMediaPlayer.URL= this.pathTextBox.Text;
            mainWindowsMediaPlayer.Ctlcontrols.play();

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            mainWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            mainWindowsMediaPlayer.Ctlcontrols.fastForward();
        }

        private void rewindButton_Click(object sender, EventArgs e)
        {
            mainWindowsMediaPlayer.Ctlcontrols.fastReverse();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mainWindowsMediaPlayer.Ctlcontrols.stop();
        }
    }
}
