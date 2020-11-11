using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace FE.Forms
{
    public partial class Anime : Form
    {
        public Anime()
        {
            InitializeComponent();
        }

        #region Series
        private void serie1_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yao-jing-zhong-zhi-shou-ce");
        }

        private void serie2_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yesterday-wo-utatte");
        }

        private void serie3_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/adachi-to-shimamura");
        }

        private void serie4_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/sword-art-online-ii");
        }
        private void serie5_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/grisaia-phantom-trigger-the-animation-stargazer");
        }

        private void serie6_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/toaru-kagaku-no-railgun-t");
        }

        private void serie7_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/yahari-ore-no-seishun-love-comedy-wa-machigatteiru-kan");
        }

        private void serie8_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/kimetsu-no-yaiba");
        }
        #endregion


    }
}
