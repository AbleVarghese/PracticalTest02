/*
 * File: AblityForm
 * Author's Name: Able Varghese
 * Date:03/25/2015
 * App Description: App to randomly generating roll playing characters ability scores each time
 * when the roll button is clicked.
 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalExam02
{
    //Ability form is a subclass inherited from the Form Class
    public partial class AbilityForm1 : Form
    {
        public AbilityForm1()
        {
            InitializeComponent();
        }

        Random Rolling = new Random();

    //button1_Click is a Method for the event, which is click of the roll button
        private void button1_Click(object sender, EventArgs e)
        {

    /*
    Statement 41 to 47 below is generating a random numbers and then converting it into string 
    and displaying it in the respective textboxes as output at the run time.
        */

            FightingTextBox.Text = Convert.ToString(Rolling.Next(1, 101));
            AgilityTextBox.Text = Convert.ToString(Rolling.Next(1, 101));
            StrengthTextBox.Text = Convert.ToString(Rolling.Next(1, 101));
            EnduranceTextBox.Text = Convert.ToString(Rolling.Next(1, 101));
            ReasonTextBox.Text = Convert.ToString(Rolling.Next(1, 101));
            IntuitionTextBox.Text = Convert.ToString(Rolling.Next(1, 101));
            PhycheTextBox.Text = Convert.ToString(Rolling.Next(1, 101));



        }


       
    }
}
