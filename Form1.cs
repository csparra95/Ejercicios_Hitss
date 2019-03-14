using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Musica
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = listBox1.SelectedIndex;
            

            switch (c)
            {
                case 0:
                    textBox1.Text = "ARTISTA: Luis Fonsi, DemiLovato\r\nALBUM: VIDA\r\nGENERO: Pop, Regueton\r\nAÑO: 2019";
                    wplayer.URL = "C:\\Users\\Public\\Music\\Sample Music\\Kalimba.mp3";
                    wplayer.controls.stop();
                    break;
                case 1:
                    textBox1.Text = "ARTISTA: The Chainsmokers\r\nALBUM: Collage\r\nGENERO: Pop\r\nAÑO: 2016";
                    wplayer.URL = "C:\\Users\\Public\\Music\\Sample Music\\Maid with the Flaxen Hair.mp3";
                    wplayer.controls.stop();
                    break;
                case 2:
                    textBox1.Text = "ARTISTA: BacKstreetBoys\r\nALBUM: Millennium\r\nGENERO: Pop\r\nAÑO: 1999";
                    wplayer.URL = "C:\\Users\\Public\\Music\\Sample Music\\Sleep Away.mp3";
                    wplayer.controls.stop();
                    break;
                case 3:
                    textBox1.Text = "ARTISTA: Bon Jovi\r\nALBUM: Crush\r\nGENERO: Pop rock \r\nAÑO: 2000";
                    break;
                case 4:
                    textBox1.Text = "ARTISTA: Mago De Oz\r\nALBUM: Finisterra\r\nGENERO: Rock\r\nAÑO: 2000";
                    break;
                case 5:
                    textBox1.Text = "ARTISTA: Banda MS\r\nALBUM: No Me Pidas Perdon\r\nGENERO: Banda\r\nAÑO: 2014";
                    break;
                case 6:
                    textBox1.Text = "ARTISTA: Clean Bandit\r\nALBUM: What is Love?\r\nGENERO: Dane Pop\r\nAÑO: 2018";
                    break;
                case 7:
                    textBox1.Text = "ARTISTA: El Chapo De Sinaloa\r\nALBUM: El Jaripeo\r\nGENERO: Banda\r\nAÑO: 2006";
                    break;
                case 8:
                    textBox1.Text = "ARTISTA: Mago De Oz\r\nALBUM: Hechizos, Pocimas y Brujeria\r\nGENERO: Heavy Metal\r\nAÑO: 2012";
                    break;
                case 9:
                    textBox1.Text = "ARTISTA: Likin Park\r\nALBUM: Meteora\r\nGENERO: Nu Metal\r\nAÑO: 2003";
                    break;
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int next = listBox1.SelectedIndex;
            if (next < 9)
            listBox1.SetSelected(next + 1, true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.SetSelected(0, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int prev = listBox1.SelectedIndex;
            if (prev > 0)
                listBox1.SetSelected(prev - 1, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int last = listBox1.Items.Count - 1;
            if (listBox1.SelectedIndex < 9)
                listBox1.SetSelected(last, true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
        }
    }
}
