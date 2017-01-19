using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * Course:          ACST 3540
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Lab 2
 */

namespace HelloThereWebForms
{
    public partial class HelloThere : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBttn_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            helloLbl.Text = ("Hello " + name);
        }
    }
}