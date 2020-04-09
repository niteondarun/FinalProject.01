using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class DisplayDegree : Form
    {
        public DisplayDegree()
        {
            InitializeComponent();
        }

        private void DisplayDegree_Load(object sender, EventArgs e)
        {

        }
        private void Results_Click(object sender, EventArgs e)
        {

            Degree_Matcher f1 = (Degree_Matcher)this.Owner;
            //gets the data from list
            List<string> FinalDegrees = f1.RemoveDegree();

            Degree1.Text = FinalDegrees[0];
            Degree2.Text = FinalDegrees[1];
            Degree3.Text = FinalDegrees[2];
            List<string>[] NeededClasses = f1.GetDegreeInfo();

            if (Degree1.Text == "Aeronautical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));
                }
                DegreeOne.BackgroundImage = Properties.Resources.aeronautical_Engineering;
            }

            if (Degree2.Text == "Aeronautical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));
                }
            }
            if (Degree3.Text == "Aeronautical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));
                }
            }

            if (Degree1.Text == "Air Traffic Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));
                }
            }

            if (Degree2.Text == "Air Traffic Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));
                }
                DegreeTwo.BackgroundImage = Properties.Resources.air_Traffic_Management;
            }
            if (Degree3.Text == "Air Traffic Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));
                }
            }
            if (Degree1.Text == "Aviation Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));
                }
                DegreeOne.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree2.Text == "Aviation Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));
                }
                DegreeTwo.BackgroundImage = Properties.Resources.aviation_Management;
            }
            if (Degree3.Text == "Aviation Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));
                }
                DegreeThree.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree1.Text == "Aviation and Operations Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));
                }

            }

            if (Degree2.Text == "Aviation and Operations Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));
                }

            }
            if (Degree3.Text == "Aviation and Operations Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));
                }
        
            }
            Results.Visible = false;
        }

        private void DegreeOne_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
