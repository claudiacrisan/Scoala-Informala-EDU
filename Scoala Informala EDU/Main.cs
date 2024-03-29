﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoala_Informala_EDU
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void QuizClickEvent(object sender, EventArgs e)
        {
            Form frm = new Quiz();
            frm.ShowDialog();
        }

        private void LearnClickEvent(object sender, EventArgs e)
        {
            Form frm = new Learn();
            frm.ShowDialog();
        }

        private void JobClickEvent(object sender, EventArgs e)
        {
            Form frm = new Job();
            frm.ShowDialog();
        }

        private void AboutClickEvent(object sender, EventArgs e)
        {
            Form frm = new About();
            frm.ShowDialog();
        }

        private void QuitClickEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
