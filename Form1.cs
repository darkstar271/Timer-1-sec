using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {//Create the timer
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            //Set the timer tick event
            myTimer.Tick += new System.EventHandler(myTimer_Tick);
        }



        private void Button1_Click_1(object sender, EventArgs e)
        {
            //Set the timer tick interval time in milliseconds
            myTimer.Interval = 1000;
            //Start timer
            myTimer.Start();
        }




        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //Timer tick event handler
        private void myTimer_Tick(object sender, System.EventArgs e)
        {
            this.label1.Text = "Successful";
            //Stop the timer - if required
            myTimer.Stop();
        }


    }
}




