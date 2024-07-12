using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades_if_Students
{


    //todo Create Fail Success Text
    public partial class Form1 : Form
    {
        public Form1() //constructor
        {
            InitializeComponent();
            lblDataError.Text = "";
        }

        private void BtnCaclulate_Click(object sender, EventArgs e)
        {
            Single Grade = 0; //make a variable to hold the Grade
            string Name = "";





            try //try to run this code
            {
                Grade = Convert.ToSingle(txtGrade.Text);
                Name = txtName.Text;

                if (Grade < 0)
                {
                    lblDataError.Text = "You cannot have a grade less than 0" + Environment.NewLine + "Bad data for " + Name;
                }
                //Create less than 50 Grade
                else if (Grade < 50)
                {
                    lbxGrade.Items.Add(Name + " had a result of " + Grade + " = Fail");
                }
                else //if the number is greater than 50
                {
                    lbxGrade.Items.Add(Name + " had a result of " + Grade + " = Pass");
                }

            }
            catch (Exception ex) //if it fails tan run the message
            {
                MessageBox.Show(Name + " or " + Grade + " is borked " + Environment.NewLine + ex);

                //swap the text box entries around ready to try again
                string temp; //hold the grade because it gets deleted next line
                temp = txtGrade.Text; //pass the grade to the temp
                txtGrade.Text = txtName.Text; //pass the name to the grade
                txtName.Text = temp; //pass the grade to the name
            }

        }
        /// <summary>
        /// This method checks each time you press a key. If it finds it cannot convert the input to a number it throws the catch. Then it removes that charactor from the number entered
        /// </summary>

        private void TxtGrade_TextChanged(object sender, EventArgs e)
        {  //can you convert the text to a number?
            try
            {
                //each time you the txt field changes the code below tries to change it to a number
                //if it fails it goes to the catch 
                Single Grade = Convert.ToSingle(txtGrade.Text);
            }
            catch
            {
                //show the messagebox if you want to check the catch is working
                //  MessageBox.Show("Please provide number only");

                //take off the last charactor you entered because its not a number

                if (txtGrade.Text != string.Empty) //only run code if there is something in the text box
                {
                    //remove the last charactor in the text box eg: 123w  - remove the w
                    txtGrade.Text = txtGrade.Text.Remove(txtGrade.Text.Length - 1, 1);
                    //set the cursor at the end of the last charactor
                    txtGrade.SelectionStart = txtGrade.Text.Length;
                }
            }

        }
    }
}
