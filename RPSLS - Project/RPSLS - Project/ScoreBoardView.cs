﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS___Project
{
  public partial class ScoreBoardView : UserControl
  {
    public ScoreBoardView()
    {
      InitializeComponent();
    }
    
        public void updateView()
        {
            lblPoints.Text  = "Hier moete de punten komen";
            lblSets.Text    = "Hier moeten het aantal sets komen";
        }

        private void ScoreBoardView_Load(object sender, EventArgs e)
        {
            lblPoints.Text  = "Points: 0";
            lblSets.Text    = "Sets: 0";
        }
    }
}