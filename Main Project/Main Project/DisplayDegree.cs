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
                
            DegreeOnePage.Visible = true;
            DegreeTwoPage.Visible = true;
            DegreeThreePage.Visible = true;

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

            //************************************************************************************************

            //************************************************************************************************

            //used to determine which degrees the user is closest to

            int[] NumberOfClassesLeft = new int[NeededClasses.Count()]; ;



            if (FinalDegrees.Contains("Aeronautical Engineering"))

            {

                NumberOfClassesLeft[0] = NeededClasses[0].Count();

            }

            else

            {

                NumberOfClassesLeft[0] = 100;

            }

            if (FinalDegrees.Contains("Air Traffic Management"))

            {

                NumberOfClassesLeft[1] = NeededClasses[1].Count();

            }

            else

            {

                NumberOfClassesLeft[1] = 100;

            }

            if (FinalDegrees.Contains("Aviation Management"))

            {
                NumberOfClassesLeft[2] = NeededClasses[2].Count();

            }

            else

            {

                NumberOfClassesLeft[2] = 100;

            }

            if (FinalDegrees.Contains("Aviation and Operations Management"))

            {

                NumberOfClassesLeft[3] = NeededClasses[3].Count();

            }

            else

            {

                NumberOfClassesLeft[3] = 100;

            }

            if (FinalDegrees.Contains("Biology"))

            {

                NumberOfClassesLeft[4] = NeededClasses[4].Count();

            }

            else

            {

                NumberOfClassesLeft[4] = 100;

            }

            if (FinalDegrees.Contains("Communication"))

            {

                NumberOfClassesLeft[5] = NeededClasses[5].Count();

            }

            else

            {

                NumberOfClassesLeft[5] = 100;

            }

            if (FinalDegrees.Contains("Computer Science"))

            {

                NumberOfClassesLeft[6] = NeededClasses[6].Count();

            }

            else

            {

                NumberOfClassesLeft[6] = 100;

            }

            if (FinalDegrees.Contains("Construction Management"))

            {

                NumberOfClassesLeft[7] = NeededClasses[7].Count();

            }

            else

            {

                NumberOfClassesLeft[7] = 100;

            }

            if (FinalDegrees.Contains("Electrical and Computer Engineering"))

            {

                NumberOfClassesLeft[8] = NeededClasses[8].Count();

            }

            else

            {

                NumberOfClassesLeft[8] = 100;

            }

            if (FinalDegrees.Contains("Electrical Engineering"))

            {

                NumberOfClassesLeft[9] = NeededClasses[9].Count();

            }

            else

            {

                NumberOfClassesLeft[9] = 100;

            }

            if (FinalDegrees.Contains("Environmental Science"))

            {

                NumberOfClassesLeft[10] = NeededClasses[10].Count();

            }

            else

            {

                NumberOfClassesLeft[10] = 100;

            }

            if (FinalDegrees.Contains("Game Art and Development"))

            {

                NumberOfClassesLeft[11] = NeededClasses[11].Count();

            }

            else

            {

                NumberOfClassesLeft[11] = 100;

            }

            if (FinalDegrees.Contains("Game Programming and Development"))

            {

                NumberOfClassesLeft[12] = NeededClasses[12].Count();

            }

            else

            {

                NumberOfClassesLeft[12] = 100;

            }

            if (FinalDegrees.Contains("Graphic Design and Media Arts"))

            {

                NumberOfClassesLeft[13] = NeededClasses[13].Count();

            }

            else

            {

                NumberOfClassesLeft[13] = 100;

            }

            if (FinalDegrees.Contains("Information Technologies"))

            {

                NumberOfClassesLeft[14] = NeededClasses[14].Count();

            }

            else

            {

                NumberOfClassesLeft[14] = 100;

            }

            if (FinalDegrees.Contains("Mechanical Engineering"))

            {

                NumberOfClassesLeft[15] = NeededClasses[15].Count();

            }

            else

            {

                NumberOfClassesLeft[15] = 100;

            }



            List<int> classCount = new List<int>();

            foreach (var item in NumberOfClassesLeft)

            {

                if (item != 100)

                {

                    classCount.Add(item);

                }

            }

            //displays top three degrees user is closest to finishing

            int minIndex = classCount.IndexOf(classCount.Min());

            Degree1.Text = FinalDegrees[minIndex];

            classCount[minIndex] = 100;





            if (FinalDegrees.Count() > 1)

            {

                int secondMinIndex = classCount.IndexOf(classCount.Min());

                Degree2.Text = FinalDegrees[secondMinIndex];

                classCount[secondMinIndex] = 100;

            }





            if (FinalDegrees.Count() > 2)

            {

                int thirdMinIndex = classCount.IndexOf(classCount.Min());

                Degree3.Text = FinalDegrees[thirdMinIndex];

            }




            //************************************************************************************************

            //************************************************************************************************

            //these are to display the information with the degree depending on what one it ends up being on

            if (Degree1.Text == "Aeronautical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));

                }

               //  DegreeOne.BackgroundImage = Properties.Resources.Aeronautical_Engineering;

            }

            if (Degree2.Text == "Aeronautical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));

                }

                //DegreeTwo.BackgroundImage = Properties.Resources.Aeronautical_Engineering;

            }

            if (Degree3.Text == "Aeronautical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(0).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(0).ElementAt(i));

                }

                 //DegreeThree.BackgroundImage = Properties.Resources.Aeronautical_Engineering;

            }

            if (Degree1.Text == "Air Traffic Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));

                }

                //DegreeOne.BackgroundImage = Properties.Resources.Air_Traffic_Management;

            }

            if (Degree2.Text == "Air Traffic Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));

                }

                 //DegreeTwo.BackgroundImage = Properties.Resources.Air_Traffic_Management;

            }

            if (Degree3.Text == "Air Traffic Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(1).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(1).ElementAt(i));

                }

                //DegreeThree.BackgroundImage = Properties.Resources.Air_Traffic_Management;

            }

            if (Degree1.Text == "Aviation Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));

                }

                 //DegreeOne.BackgroundImage = Properties.Resources.Aviation_Management;

            }

            if (Degree2.Text == "Aviation Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));

                }

                //DegreeTwo.BackgroundImage = Properties.Resources.Aviation_Management;

            }

            if (Degree3.Text == "Aviation Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(2).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(2).ElementAt(i));

                }

                //DegreeThree.BackgroundImage = Properties.Resources.Aviation_Management;

            }

            if (Degree1.Text == "Aviation and Operations Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));

                }

                //DegreeOne.BackgroundImage = Properties.Resources.Aviation_and_Operations_Management;

            }

            if (Degree2.Text == "Aviation and Operations Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));

                }

                 //DegreeTwo.BackgroundImage = Properties.Resources.Aviation_and_Operations_Management;

            }

            if (Degree3.Text == "Aviation and Operations Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(3).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(3).ElementAt(i));

                }

                 //DegreeThree.BackgroundImage = Properties.Resources.Aviation_and_Operations_Management;

            }

            if (Degree1.Text == "Computer Science")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(6).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(6).ElementAt(i));

                }

                 //DegreeOne.BackgroundImage = Properties.Resources.Computer_Science;

            }

            if (Degree2.Text == "Computer Science")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(6).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(6).ElementAt(i));

                }

                //DegreeTwo.BackgroundImage = Properties.Resources.Computer_Science;

            }

            if (Degree3.Text == "Computer Science")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(6).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(6).ElementAt(i));

                }

                //DegreeThree.BackgroundImage = Properties.Resources.Computer_Science;

            }

            if (Degree1.Text == "Construction Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(7).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(7).ElementAt(i));

                }

                //DegreeOne.BackgroundImage = Properties.Resources.Construction_Management;

            }

            if (Degree2.Text == "Construction Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(7).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(7).ElementAt(i));

                }

                //DegreeTwo.BackgroundImage = Properties.Resources.Construction_Management;

            }

            if (Degree3.Text == "Construction Management")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(7).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(7).ElementAt(i));

                }

                //DegreeThree.BackgroundImage = Properties.Resources.Construction_Management;

            }

            if (Degree1.Text == "Electrical and Computer Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(8).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(8).ElementAt(i));

                }

                //DegreeOne.BackgroundImage = Properties.Resources.Electrical_and_Computer_Engineering;

            }

            if (Degree2.Text == "Electrical and Computer Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(8).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(8).ElementAt(i));

                }

                //DegreeTwo.BackgroundImage = Properties.Resources.Electrical_and_Computer_Engineering;

            }

            if (Degree3.Text == "Electrical and Computer Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(8).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(8).ElementAt(i));

                }

                //DegreeThree.BackgroundImage = Properties.Resources.Electrical_and_Computer_Engineering;
             

            }

            if (Degree1.Text == "Electrical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(9).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(9).ElementAt(i));

                }
                //DegreeOne.BackgroundImage = Properties.Resources.Electrical_Engineering;

            }

            if (Degree2.Text == "Electrical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(9).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(9).ElementAt(i));

                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Electrical_Engineering;

            }

            if (Degree3.Text == "Electrical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(9).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(9).ElementAt(i));

                }
                //DegreeThree.BackgroundImage = Properties.Resources.Electrical_Engineering;

            }

            if (Degree1.Text == "Information Technologies")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(14).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(14).ElementAt(i));

                }
                //DegreeOne.BackgroundImage = Properties.Resources.Information_Technologies;

            }

            if (Degree2.Text == "Information Technologies")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(14).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(14).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Information_Technologies;

            }

            if (Degree3.Text == "Information Technologies")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(14).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(14).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Information_Technologies;

            }

            if (Degree1.Text == "Mechanical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(15).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(15).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Mechanical_Engineering;

            }

            if (Degree2.Text == "Mechanical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(15).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(15).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Mechanical_Engineering;

            }

            if (Degree3.Text == "Mechanical Engineering")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(15).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(15).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Mechanical_Engineering;

            }

            if (Degree1.Text == "Biology")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(4).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(4).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Biology;

            }

            if (Degree2.Text == "Biology")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(4).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(4).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Biology;

            }

            if (Degree3.Text == "Biology")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(4).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(4).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Biology;

            }

            if (Degree1.Text == "Environmental Science")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(10).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(10).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Environmental_Science;

            }

            if (Degree2.Text == "Environmental Science")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(10).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(10).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Environmental_Science;

            }

            if (Degree3.Text == "Environmental Science")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(10).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(10).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Environmental_Science;

            }

            if (Degree1.Text == "Game Art and Development")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(11).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(11).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Game_Art_and_Development;

            }

            if (Degree2.Text == "Game Art and Development")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(11).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(11).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Game_Art_and_Development;

            }

            if (Degree3.Text == "Game Art and Development")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(11).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(11).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Game_Art_and_Development;

            }

            if (Degree1.Text == "Game Programming and Development")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(12).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(12).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Game_Programming_and_Development;

            }

            if (Degree2.Text == "Game Programming and Development")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(12).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(12).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Game_Programming_and_Development;

            }

            if (Degree3.Text == "Game Programming and Development")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(12).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(12).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Game_Programming_and_Development;

            }

            if (Degree1.Text == "Graphic Design and Media Arts")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(13).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(13).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Graphic_Design_and_Media_Arts;

            }

            if (Degree2.Text == "Graphic Design and Media Arts")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(13).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(13).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Graphic_Design_and_Media_Arts;

            }

            if (Degree3.Text == "Graphic Design and Media Arts")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(13).Count - 1; i++)

                {

                    Degree3Txt.Items.Add(NeededClasses.ElementAt(13).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Graphic_Design_and_Media_Arts;

            }

            if (Degree1.Text == "Communication")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(5).Count - 1; i++)

                {

                    Degree1Txt.Items.Add(NeededClasses.ElementAt(5).ElementAt(i));
                }
                //DegreeOne.BackgroundImage = Properties.Resources.Communication;

            }

            if (Degree2.Text == "Communication")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(5).Count - 1; i++)

                {

                    Degree2Txt.Items.Add(NeededClasses.ElementAt(5).ElementAt(i));
                }
                //DegreeTwo.BackgroundImage = Properties.Resources.Communication;

            }

            if (Degree3.Text == "Communication")

            {

                for (int i = 0; i <= NeededClasses.ElementAt(5).Count - 1; i++)

                {
                    Degree3Txt.Items.Add(NeededClasses.ElementAt(5).ElementAt(i));
                }
                //DegreeThree.BackgroundImage = Properties.Resources.Communication;

            }


            //hides button and labels
            Results.Visible = false;

           /* if(Degree1.Text != "Electrical Engineering")
            {
                Degree1.Visible = false;
            }
            if (Degree2.Text != "Electrical Engineering")
            {
                Degree2.Visible = false;
            }
            if (Degree3.Text != "Electrical Engineering")
            {
                Degree3.Visible = false;
            }

            if (Degree1.Text == "Electrical Engineering")
            {
                Degree1.ForeColor = Color.White;
                Degree1.Font = new Font("Times New Roman", 14);
            }
            if (Degree2.Text == "Electrical Engineering")
            {
                Degree2.ForeColor = Color.White;
                Degree2.Font = new Font("Times New Roman", 14);
            }
            if (Degree3.Text == "Electrical Engineering")
            {
                Degree3.ForeColor = Color.White;
                Degree3.Font = new Font("Times New Roman", 14);
            } */
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

        private void DegreeOnePage_Click(object sender, EventArgs e)
        {
            if(Degree1.Text == "Aeronautical Engineering")
            {

                    System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aeronautical-engineering");
                
            }

            if (Degree1.Text == "Air Traffic Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-air-traffic-management");

            }

            if (Degree1.Text == "Aviation Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aviation-management");

            }

            if (Degree1.Text == "Aviation and Operations Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aviation-operations-and-management");

            }

            if (Degree1.Text == "Computer Science")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-computer-science");

            }

            if (Degree1.Text == "Construction Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-construction-management");

            }

            if (Degree1.Text == "Electrical and Computer Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-electrical-and-computer-engineering");

            }

            if (Degree1.Text == "Electrical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/about-us/newsroom/2018/10/what-do-electrical-engineers-do");

            }

            if (Degree1.Text == "Information Technologies")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-information-technologies");

            }

            if (Degree1.Text == "Mechanical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-mechanical-engineering");

            }

            if (Degree1.Text == "Biology")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-biology");

            }

            if (Degree1.Text == "Environmental Science")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-environmental-science");

            }

            if (Degree1.Text == "Game Art and Development")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-game-art-and-development");

            }

            if (Degree1.Text == "Game Programming and Development")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-game-programming-and-development");

            }

            if (Degree1.Text == "Graphic Design and Media Arts")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-graphic-design-and-media-arts");

            }

            if (Degree1.Text == "Communication")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-communication");

            }
        }

        private void DegreeTwoPage_Click(object sender, EventArgs e)
        {
            if (Degree2.Text == "Aeronautical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aeronautical-engineering");

            }

            if (Degree2.Text == "Air Traffic Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-air-traffic-management");

            }

            if (Degree2.Text == "Aviation Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aviation-management");

            }

            if (Degree2.Text == "Aviation and Operations Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aviation-operations-and-management");

            }

            if (Degree2.Text == "Computer Science")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-computer-science");

            }

            if (Degree2.Text == "Construction Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-construction-management");

            }

            if (Degree2.Text == "Electrical and Computer Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-electrical-and-computer-engineering");

            }

            if (Degree2.Text == "Electrical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/about-us/newsroom/2018/10/what-do-electrical-engineers-do");

            }

            if (Degree2.Text == "Information Technologies")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-information-technologies");

            }

            if (Degree2.Text == "Mechanical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-mechanical-engineering");

            }

            if (Degree2.Text == "Biology")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-biology");

            }

            if (Degree2.Text == "Environmental Science")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-environmental-science");

            }

            if (Degree2.Text == "Game Art and Development")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-game-art-and-development");

            }

            if (Degree2.Text == "Game Programming and Development")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-game-programming-and-development");

            }

            if (Degree2.Text == "Graphic Design and Media Arts")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-graphic-design-and-media-arts");

            }

            if (Degree1.Text == "Communication")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-communication");

            }
        }

        private void DegreeThreePage_Click(object sender, EventArgs e)
        {
            if (Degree3.Text == "Aeronautical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aeronautical-engineering");

            }

            if (Degree3.Text == "Air Traffic Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-air-traffic-management");

            }

            if (Degree3.Text == "Aviation Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aviation-management");

            }

            if (Degree3.Text == "Aviation and Operations Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-aviation-operations-and-management");

            }

            if (Degree3.Text == "Computer Science")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-computer-science");

            }

            if (Degree3.Text == "Construction Management")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-construction-management");

            }

            if (Degree3.Text == "Electrical and Computer Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-electrical-and-computer-engineering");

            }

            if (Degree3.Text == "Electrical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/about-us/newsroom/2018/10/what-do-electrical-engineers-do");

            }

            if (Degree3.Text == "Information Technologies")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-information-technologies");

            }

            if (Degree3.Text == "Mechanical Engineering")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-mechanical-engineering");

            }

            if (Degree3.Text == "Biology")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-biology");

            }

            if (Degree3.Text == "Environmental Science")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-environmental-science");

            }

            if (Degree3.Text == "Game Art and Development")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-game-art-and-development");

            }

            if (Degree3.Text == "Game Programming and Development")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/bs-game-programming-and-development");

            }

            if (Degree3.Text == "Graphic Design and Media Arts")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-graphic-design-and-media-arts");

            }

            if (Degree1.Text == "Communication")
            {

                System.Diagnostics.Process.Start("https://www.snhu.edu/campus-majors/undergraduate/ba-communication");

            }
        }

    }
}
