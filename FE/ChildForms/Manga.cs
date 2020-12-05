using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FE.Forms
{
    public partial class Manga : Form
    {
        public Manga()
        {
            InitializeComponent();
        }

        private void serie1_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/boku-no-hero-academia");
        }

        private void serie2_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/one-piece");
        }

        private void serie3_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/anime/mekaku-city-actors");
        }

        private void serie4_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/d-frag");
        }

        private void serie5_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/overlord-novel");
        }

        private void serie6_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/re-zero-kara-hajimeru-isekai-seikatsu");
        }

        private void serie7_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/dungeon-ni-deai-wo-motomeru-no-wa-machigatteiru-no-darou-ka");
        }

        private void serie8_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitsu.io/manga/haikyuu");
        }
    }
}
