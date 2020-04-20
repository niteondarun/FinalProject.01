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
            // gives the access to methods of the other form
            Degree_Matcher f1 = (Degree_Matcher)this.Owner;
            //gets the data from list
            List<string> FinalDegrees = f1.RemoveDegree();
            List<string>[] NeededClasses = f1.GetDegreeInfo();
            List<string> Classes = f1.GetData();

            // loop to remove classes
            for (int u = 0; u <= NeededClasses.Count() - 1; u++)
            {
                for (int h = 0; h <= Classes.Count() - 1; h++)
                {
                    //removes them from all the degrees
                    NeededClasses.ElementAt(u).Remove(Classes[h]);
                    //removes certain one depending on certain selection
                    if (Classes[h] == "EG340 - Probability and Statistics for Engineers" || Classes[h] == "MAT370 - Numerical Analysis")
                    {
                        NeededClasses.ElementAt(0).Remove("MAT370 - Numerical Analysis");
                        NeededClasses.ElementAt(0).Remove("EG340 - Probability and Statistics for Engineers");
                    }
                    //removes certain one depending on certain selection
                    if (Classes[h] == "MAT140 - Precalculus" || Classes[h] == "MAT225 - Calculus I: Single-Variable Calculus")
                    {
                        NeededClasses.ElementAt(3).Remove("MAT140 - Precalculus");
                        NeededClasses.ElementAt(3).Remove("MAT225 - Calculus I: Single-Variable Calculus");
                    }
                    //removes certain one depending on certain selection
                    if (Classes[h] == "CS413 - Software Engineering Project I" || Classes[h] == "Software Engineering Project II")
                    {
                        NeededClasses.ElementAt(4).Remove("CS413 - Software Engineering Project I");
                        NeededClasses.ElementAt(4).Remove("Software Engineering Project II");
                    }
                    //removes certain one depending on certain selection
                    if (Classes[h] == "CS317 - Computer Networks" || Classes[h] == "CS328 - Embedded Systems")
                    {
                        NeededClasses.ElementAt(5).Remove("CS317 - Computer Networks");
                        NeededClasses.ElementAt(5).Remove("CS328 - Embedded Systems");
                    }
                    //removes certain one depending on certain selection
                    if (Classes[h] == "MAT224 - Calculus I: Single-Variable Calculus Part B" || Classes[h] == "MAT225 - Calculus I: Single-Variable Calculus")
                    {
                        NeededClasses.ElementAt(8).Remove("MAT224 - Calculus I: Single-Variable Calculus Part B");
                        NeededClasses.ElementAt(8).Remove("MAT225 - Calculus I: Single-Variable Calculus");
                    }
                    //removes certain one depending on certain selection
                    if (Classes[h] == "EG318 - Thermodynamics II" && Classes[h] == "EG350 - Advanced Dynamics of Mechanical Systems" || Classes[h] == "EG318 - Thermodynamics II" && Classes[h] == "EG420 - Design of Thermo-Fluid Systems" || Classes[h] == "EG420 - Design of Thermo-Fluid Systems" && Classes[h] == "EG350 - Advanced Dynamics of Mechanical Systems")
                    {
                        NeededClasses.ElementAt(9).Remove("EG318 - Thermodynamics II");
                        NeededClasses.ElementAt(9).Remove("EG350 - Advanced Dynamics of Mechanical Systems");
                        NeededClasses.ElementAt(9).Remove("EG420 - Design of Thermo-Fluid Systems");
                    }
                    //removes certain one depending on certain selection
                    if (Classes[h] == "EG340 - Probability and Statistics for Engineers" || Classes[h] == "MAT370 - Numerical Analysis")
                    {
                        NeededClasses.ElementAt(9).Remove("EG340 - Probability and Statistics for Engineers");
                        NeededClasses.ElementAt(9).Remove("MAT370 - Numerical Analysis");
                    }
                }
            }


        // Displays the information of the top three degrees
        Degree1.Text = FinalDegrees[0];
            Degree2.Text = FinalDegrees[1];
            Degree3.Text = FinalDegrees[2];

            //these are to display the information with the degree depending on what one it ends up being on
            if (Degree1.Text == "Aeronautical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));
                }
                // DegreeOne.BackgroundImage = Properties.Resources.aeronautical_Engineering;
    }

            if (Degree2.Text == "Aeronautical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));                   
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.aeronautical_Engineering;
            }

            if (Degree3.Text == "Aeronautical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));                    
                }
               // DegreeThree.BackgroundImage = Properties.Resources.aeronautical_Engineering;
            }

            if (Degree1.Text == "Air Traffic Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));                    
                }
                //DegreeOne.BackgroundImage = Properties.Resources.air_Traffic_Management;
            }

            if (Degree2.Text == "Air Traffic Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));
                }
               // DegreeTwo.BackgroundImage = Properties.Resources.air_Traffic_Management;
            }

            if (Degree3.Text == "Air Traffic Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));                    
                }
                //DegreeThree.BackgroundImage = Properties.Resources.air_Traffic_Management;
            }

            if (Degree1.Text == "Aviation Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));                    
                }
               // DegreeOne.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree2.Text == "Aviation Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));                    
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree3.Text == "Aviation Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));                    
                }
                //DegreeThree.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree1.Text == "Aviation and Operations Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree2.Text == "Aviation and Operations Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));
                }
               // DegreeTwo.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree3.Text == "Aviation and Operations Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));
                }
               // DegreeThree.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree1.Text == "Computer Science")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(4).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(4).ElementAt(i));
                }
               // DegreeOne.BackgroundImage = Properties.Resources.computer_Science;
            }

            if (Degree2.Text == "Computer Science")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(4).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(4).ElementAt(i));                    
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.computer_Science;
            }

            if (Degree3.Text == "Computer Science")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(4).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(4).ElementAt(i));                    
                }
               // DegreeThree.BackgroundImage = Properties.Resources.computer_Science;
            }

            if (Degree1.Text == "Construction Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(5).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(5).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.construction_Management;
            }

            if (Degree2.Text == "Construction Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(5).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(5).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.construction_Management;
            }

            if (Degree3.Text == "Construction Management")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(5).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(5).ElementAt(i));                    
                }
               // DegreeThree.BackgroundImage = Properties.Resources.construction_Management;
            }

            if (Degree1.Text == "Electrical and Computer Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(6).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(6).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree2.Text == "Electrical and Computer Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(6).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(6).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree3.Text == "Electrical and Computer Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(6).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(6).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.aviation_Management;
            }

            if (Degree1.Text == "Electrical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(7).Count - 1; i++)
                {
                    Degree1Txt.Items.Add(NeededClasses.ElementAt(7).ElementAt(i));
                }

            }

            if (Degree2.Text == "Electrical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(7).Count - 1; i++)
                {
                    Degree2Txt.Items.Add(NeededClasses.ElementAt(7).ElementAt(i));
                }

            }

            if (Degree3.Text == "Electrical Engineering")
            {
                for (int i = 0; i <= NeededClasses.ElementAt(7).Count - 1; i++)
                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(7).ElementAt(i));
                }
            }

            if (Degree1.Text == "Information Technologies")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(8).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(8).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Information Technologies")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(8).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(8).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Information Technologies")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(8).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(8).ElementAt(i));
                    }
                }

                    if (Degree1.Text == "Mechanical Engineering")
                    {
                        for (int i = 0; i <= NeededClasses.ElementAt(9).Count - 1; i++)
                        {
                            Degree1Txt.Items.Add(NeededClasses.ElementAt(9).ElementAt(i));
                        }

                    }

                    if (Degree2.Text == "Mechanical Engineering")
                    {
                        for (int i = 0; i <= NeededClasses.ElementAt(9).Count - 1; i++)
                        {
                            Degree2Txt.Items.Add(NeededClasses.ElementAt(9).ElementAt(i));
                        }

                    }

                    if (Degree3.Text == "Mechanical Engineering")
                    {
                        for (int i = 0; i <= NeededClasses.ElementAt(9).Count - 1; i++)
                        {
                            Degree3Txt.Items.Add(NeededClasses.ElementAt(9).ElementAt(i));
                        }

                    }

                if (Degree1.Text == "Biology")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(10).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(10).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Biology")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(10).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(10).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Biology")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(10).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(10).ElementAt(i));
                    }

                }

                if (Degree1.Text == "Environmental Science")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(11).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(11).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Environmental Science")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(11).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(11).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Environmental Science")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(11).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(11).ElementAt(i));
                    }

                }

                if (Degree1.Text == "Game Art and Development")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(12).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(12).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Game Art and Development")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(12).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(12).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Game Art and Development")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(12).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(12).ElementAt(i));
                    }

                }

                if (Degree1.Text == "Game Programming and Development")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(13).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(13).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Game Programming and Development")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(13).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(13).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Game Programming and Development")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(13).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(13).ElementAt(i));
                    }

                }

                if (Degree1.Text == "Graphic Design and Media Arts")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(14).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(14).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Graphic Design and Media Arts")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(14).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(14).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Graphic Design and Media Arts")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(14).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(14).ElementAt(i));
                    }

                }

                if (Degree1.Text == "Communication")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(15).Count - 1; i++)
                    {
                        Degree1Txt.Items.Add(NeededClasses.ElementAt(15).ElementAt(i));
                    }

                }

                if (Degree2.Text == "Communication")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(15).Count - 1; i++)
                    {
                        Degree2Txt.Items.Add(NeededClasses.ElementAt(15).ElementAt(i));
                    }

                }

                if (Degree3.Text == "Communication")
                {
                    for (int i = 0; i <= NeededClasses.ElementAt(15).Count - 1; i++)
                    {
                        Degree3Txt.Items.Add(NeededClasses.ElementAt(15).ElementAt(i));
                    }

                }

            //hides button
            Results.Visible = false;

        }

        private void DegreeOne_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DegreeTwo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DegreeThree_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Degree3_Click(object sender, EventArgs e)
        {

        }

        private void Degree3Txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Degree2_Click(object sender, EventArgs e)
        {

        }

        private void Degree2Txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Degree1_Click(object sender, EventArgs e)
        {

        }

        private void Degree1Txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
