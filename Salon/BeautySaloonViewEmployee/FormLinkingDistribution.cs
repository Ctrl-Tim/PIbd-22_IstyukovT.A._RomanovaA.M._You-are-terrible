﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloonViewEmployee
{
    public partial class FormLinkingDistribution : Form
    {
        public FormLinkingDistribution()
        {
            InitializeComponent();
        }

        private void FormLinkingDistribution_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void buttonLinking_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
