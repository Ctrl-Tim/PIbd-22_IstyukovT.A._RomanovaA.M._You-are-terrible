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
    public partial class FormSelectionCosmeticsForPurchaseList : Form
    {
        public FormSelectionCosmeticsForPurchaseList()
        {
            InitializeComponent();
        }

        private void FormSelectionCosmeticsForPurchaseList_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
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
