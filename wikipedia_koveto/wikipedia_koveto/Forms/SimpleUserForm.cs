﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wikipedia_koveto.Forms
{
    public partial class SimpleUserForm : Form
    {
        private string userName; // To store which admin logged in

        public SimpleUserForm(string userName)
        {
            InitializeComponent();

            this.userName = userName;
        }
    }
}
