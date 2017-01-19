using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Course:          ACST 3540
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Lab 01
 */

namespace HelloThereWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            helloLbl.Text = "Hello " + name;
        }
    }
}
