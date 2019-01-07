﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeParkTycoonGame.UI
{
    public partial class SingleGuestForm : Form
    {
        Guest guest;

        public SingleGuestForm(Guest guest)
        {
            InitializeComponent();

            this.guest = guest;

            // Set the title to this guests name
            this.Text = string.Format("{0} (Entered park @ {1})", guest.Name, guest.TimeEntered);

            MessageBox.Show("TODO: The ride history is to be shown here.", "Under construction!");
        }
    }
}
