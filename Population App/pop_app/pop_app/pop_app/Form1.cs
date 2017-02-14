/* Student Name: Merlin Bierekofen
 * Student ID: 14101805
 * Date: 13.11.2016
 * Assignment: 5
 
   In the Assignment 5 folder on Blackboard, you will find a file named “IrishPopulation.txt”. The file
contains the midyear population of Ireland, during the years 1950 through 1990.
The first line in the file contains the population for 1950, the second line contains the population for
1951, and so forth.
Create an application that reads the file’s contents into an array or a List.
The application should display the following data in an easy to understand manner
􀁸 The increase in population each year e.g. (1951 there is a population increase of 31,710)
􀁸 The average annual change in population during the time period
􀁸 The year with the greatest increase in population during the time period
􀁸 The year with the least increase in population during the time period
1) Handle unexpected errors. (Invalid inputs, file not found etc.)
2) Follow good programming conventions for object names: include comments for some
methods and at the top of the file to explain what the application is about.
3) Give the form a name that will display at the top of the form.
4) Include your name in the bottom right corner “Programmed by …………….”
5) Include screenshots showing the application in use.
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
using System.IO;

namespace pop_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Average(int[]iArray)
        {
            //variable holding population increase
            int totIncrease = 0;
            //variable holding increase from year to year
            int incPerYear = 0;
            //variable holding year checked for the for loop
            int incCount = 0;
            //variable holding number of real variables in the array
            int arrayLength = iArray.Length - 1;

            double average;

            for (int index = 0; index < arrayLength; index++)
            {
                int index2 = index + 1;

                    int y1Population = iArray[index];
                    int y2Population = iArray[index2];

                    incPerYear = y2Population - y1Population;
                    incCount++;

                //adding inc to the var
                totIncrease = totIncrease + incPerYear;
            }

            //calc average increase
            average = totIncrease / incCount;
            return average;
        }

        public int Highest(int[] iArray)
        {
            //variable holding highest pop increase
            int highest = 0;
            //variable holding inc from year to year 
            int incPerYear = 0;
            //variable holding number of real variables in the array 
            int arrayLength = iArray.Length - 1;
            int firstYear = 1950;
            int highestYear = 0;

            //loop to calc change in popul.
            for (int index = 0; index < arrayLength; index++)
            {
                int index2 = index + 1;
                int y1Population = iArray[index];
                int y2Population = iArray[index2];

                incPerYear = y2Population - y1Population;

                //getting year with the greatest population
                if (incPerYear > highest)
                {
                    highest = incPerYear;
                    highestYear = firstYear + index2;
                }
            }

            return highestYear;
        }

        public int Lowest(int[] iArray)
        {
            //variable holding lowest pop increase
            int lowest = 1000000;
            //variable holding inc from year to year 
            int incPerYear = 0;
            //variable holding number of real variables in the array 
            int arrayLength = iArray.Length - 1;
            int firstYear = 1950;
            int lowestYear = 0;

            //loop to calc change in popul.
            for (int index = 0; index < arrayLength; index++)
            {
                int index2 = index + 1;
                int y1Population = iArray[index];
                int y2Population = iArray[index2];

                incPerYear = y2Population - y1Population;

                //getting year with the lowest population
                if (incPerYear < lowest)
                {
                    lowest = incPerYear;
                    lowestYear = firstYear + index2;
                }
            }

            return lowestYear;
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variable used for the size of the array
                const int Num = 40;

                //decl array
                int[] newNum = new int[Num];
                int index = 0;
                int hScore;
                int lScore;
                int y1 = 1951;
                int incPerYear = 0;
                int arrayRealCount = newNum.Length - 1;
                double avg;

                //use streamreader for input 
                StreamReader inputFile;
                inputFile = File.OpenText("IrishPopulation.txt");
                while (!inputFile.EndOfStream && index < newNum.Length)
                {
                    newNum[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                //loop to add years to list box
                for (int index2 = 0; index2 < arrayRealCount; index2++)
                {
                    int index3 = index2 + 1;
                    int y1Population = newNum[index2];
                    int y2Population = newNum[index3];

                    incPerYear = y2Population - y1Population;
                    annualTotalChangeListBox.Items.Add(y1 + " :" + incPerYear);
                    y1++;
                }

                //calling meth

                hScore = Highest(newNum);
                lScore = Lowest(newNum);
                avg = Average(newNum);

                avAnChangeOutputLabel.Text = avg.ToString("n1");
                greatestIncreaseOutputLlabel.Text = hScore.ToString("n1");
                lestIncreaseOutputLabel.Text = lScore.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            annualTotalChangeListBox.Items.Clear();
            avAnChangeOutputLabel.Text = "";
            greatestIncreaseOutputLlabel.Text = "";
            lestIncreaseOutputLabel.Text = "";
        }
    }
}
