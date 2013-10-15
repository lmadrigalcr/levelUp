﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUpApplication
{
    public partial class RuleDetailsForm : Form
    {
        public RuleDetailsForm()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyRuleButton_Click(object sender, EventArgs e)
        {

        }

        private void RuleDetailsForm_Shown(object sender, EventArgs e)
        {
            AppController = ((MainForm)this.Owner).GetController();
            string Department = ""; //Get Department
            Achievement.Items.AddRange(AppController.GetDepartmentAchievements(Department));
        }

    }
}
