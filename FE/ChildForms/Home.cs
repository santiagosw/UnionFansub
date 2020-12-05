using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;


namespace FE.Forms
{
    
    public partial class Home : Form
    {
        private int activeSlider = 1;

        public Home()
        {
            InitializeComponent();

            
        }
        //Play music in loop
        private void btnPlay_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.toro);
            player.PlayLooping();
            btnMute.Visible = true;
            btnPlay.Visible = false;
        }

        //Stop music 
        private void btnMute_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.toro);
            player.Stop();
            btnMute.Visible = false;
            btnPlay.Visible = true;
        }

        #region sliderHome      
        private void sliderChange(object sender, EventArgs e)
        {
            if (((Siticone.UI.WinForms.SiticoneImageButton)sender).Name == "sliderRight")
            {
                activeSlider++;
            }
            else
            {
                activeSlider--; 
            }

            if (activeSlider==6)
            {
                activeSlider = 1;
            }
            else if (activeSlider==0)
            {
                activeSlider = 5;
            }

            slider1.Visible = false;
            slider2.Visible = false;
            slider3.Visible = false;
            slider4.Visible = false;
            slider5.Visible = false;

            switch (activeSlider)
            {
                case 1:
                    slider1.Visible = true;
                    break;
                case 2:
                    slider2.Visible = true;
                    break;
                case 3:
                    slider3.Visible = true;
                    break;
                case 4:
                    slider4.Visible = true;
                    break;
                case 5:
                    slider5.Visible = true;
                    break;
            }


        }
        #endregion

        #region EnterLinks Sliders
        private void slider1_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/adachi-to-shimamura");
        }

        private void slider2_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yesterday-wo-utatte");
        }

        private void slider3_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yao-jing-zhong-zhi-shou-ce");
        }

        private void slider4_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yuru-camp");
        }

        private void slider5_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/kimetsu-no-yaiba");
        }




        #endregion

        #region EnterLinks Others
        private void imgs1_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/shingeki-no-kyojin-the-final-season");
        }

        private void imgs2_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/tensei-shitara-slime-datta-ken-2");
        }

        private void imgs3_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yakusoku-no-neverland-2nd-season");
        }

        private void imgs4_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/5-toubun-no-hanayome-2");
        }

        private void imgs5_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/date-a-bullet-nightmare-or-queen");
        }

        private void imgs6_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/shigatsu-wa-kimi-no-uso");
        }

        private void imgs7_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/boku-dake-ga-inai-machi");
        }

        private void imgs8_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/kaguya-sama-wa-kokurasetai-tensai-tachi-no-renai-zunousen");
        }

        #endregion

    }

}



