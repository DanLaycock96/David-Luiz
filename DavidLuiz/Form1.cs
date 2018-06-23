using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidLuiz
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            playSimpleSound();
        }

        private void playSimpleSound()
        {
            Stream str = Properties.Resources.tune;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }


    }
}
