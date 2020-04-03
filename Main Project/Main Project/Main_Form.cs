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
    public partial class Degree_Matcher : Form
    {

        public Degree_Matcher()
        {
            InitializeComponent();
        }

        private void ClassOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Texts_Click(object sender, EventArgs e)
        {

        }
        List<String> Data = new List<String>();
        private void Match_Click(object sender, EventArgs e)
        {
            //checks for all checked blocks
            for (int i = 0; i < ClassOptions.Items.Count; i++)
            {
                
                if (ClassOptions.GetItemChecked(i))
                {
                    //This puts the selected checkbox strings into the list
                    Data.Add(ClassOptions.GetItemText(ClassOptions.Items[i]));
 }
            }
            //loop to display all the ones that got seletced and put into the list.
            //for (int i = 0; i <= Data.Count - 1; i++)
            //{
            //    MessageBox.Show(Data[i]);
            //}

            //begin sorting completed courses
            List<string>[] DegreeDatabase = new List<string>[11];
            List<string>[] EmptyDegreeDatabase = new List<string>[11];

            List<string> EmptyAeroEng = new List<string> { };
            List<string> EmptyAirTrafMgmt = new List<string> { };
            List<string> EmptyAviationMgmt = new List<string> { };
            List<string> EmptyAviationOpMgmt = new List<string> { };
            List<string> EmptyCompSci = new List<string> { };
            List<string> EmptyConstMgmt = new List<string> { };
            List<string> EmptyConstSci = new List<string> { };
            List<string> EmptyElecAndCompEng = new List<string> { };
            List<string> EmptyElecEng = new List<string> { };
            List<string> EmptyIT = new List<string> { };
            List<string> EmptyMechEng = new List<string> { };

            EmptyDegreeDatabase[0] = EmptyAeroEng;
            EmptyDegreeDatabase[1] = EmptyAirTrafMgmt;
            EmptyDegreeDatabase[2] = EmptyAviationMgmt;
            EmptyDegreeDatabase[3] = EmptyAviationOpMgmt;
            EmptyDegreeDatabase[4] = EmptyCompSci;
            EmptyDegreeDatabase[5] = EmptyConstMgmt;
            EmptyDegreeDatabase[6] = EmptyConstSci;
            EmptyDegreeDatabase[7] = EmptyElecAndCompEng;
            EmptyDegreeDatabase[8] = EmptyElecEng;
            EmptyDegreeDatabase[9] = EmptyIT;
            EmptyDegreeDatabase[10] = EmptyMechEng;

            List<string> AeroEng = new List<string> {"MAT225 - Calculus I", "EG110 - Engineering Design I", "EG498 - Capstone Design I",
                "CHM120 - General Chemistry I", "PHY215 - Physics I", "MAT275 - Calculus II", "EG499 - Capstone Design III", "EG201 - Fluid Mechanics",
                "EG202 - Mechanics of Materials I", "EG203 - Dynamics", "EG209 - Thermodynamics I", "EG308 - Gas Dynamics", "EG314 - Aerodynamics",
                "EG326 - Aircraft Structures", "EG330 - Propulsion", "EG412 - Aircraft Design I", "EG418 - Flight Dynamics I", "EG418FT - Flight Testing",
                "EG419 - Flight Dynamics II", "EG419FT - Flight Testing", "EG200 - Statics", "EG207 - Instrumentation & Measurements",
                "EG208 - Materials Science", "EG310 - Junior Engineering Design", "EG316 - Electrical Circuits", "EG333 - Control Systems Analysis",
                "MAT325 - Calculus III", "MAT330 - Differential Equations", "MAT350 - Linear Algebra", "PHY216 - Physics II", "PHY216L - Physics II Lab",
                "CHM120L - General Chemistry I Lab", "PHY215L - Physics I Lab",
                "One of the Following: EG340 - Probability and Statistics for Engineers or MAT730 - Numerical Analysis",
                "Plus 21 more Credits from General Education"};
            List<string> AirTrafMgmt = new List<string> { };
            List<string> AviationMgmt = new List<string> { };
            List<string> AviationOpMgmt = new List<string> {"MAT225 - Calculus I", "ACC105 - Foundations of Accounting I", "AM201 - Aviation Law",
                "INT105 - International Business: A Macro Perspective", "MKT105 - Foundations of Marketing", "QSO205 - Business Operations Management",
                "OL215 - Principles of Management", "OL318 - Employee and Labor Relations", "SB100 - Integration & Application of Business I",
                "SB105 - Integration & Application of Business II", "AT110 - Fundamentals of Air Traffic Control", "AV220 - Advanced Aircraft and Navigation Systems",
                "AV306 - Human Factors of Flight", "AV401 - Aerodynamics and Aircraft Performance", "AV410 - Aviation Safety", "AV491 - Aviation Internship II",
                "PLT101 - Private Pilot Ground" , "PLT102 - Private Pilot Flight", "PLT103 - Instrument Ground Training", "PLT104 - Instrument Flight Training",
                "PLT105 - Commercial Pilot I", "AV207 - Fundamentals of Instruction", "PLT202 - Certified Flight Instructor I",
                "PLT203 - Certified Flight Instructor II", "PLT205 - Commercial Pilot II", "PLT305 - Commercial Pilot III", "PLT405 - Commercial Multi-Engine"};
            List<string> CompSci = new List<string> { "MAT225", "CS203", "CS204", "MAT275", "PHY215", "MAT350", "CS113", "CS113L",
            "CS114", "CS114L", "CS217", "CS218", "CS219", "CS238", "CS303", "CS304", "CS312", "CS317", "CS321", "CS361",
            "MAT230", "MAT235", "PHY215L", "CS413", "CS414", "CS490", "CS231", "CS328", "CS331", "CS407", "CS411", "CS425",
            "EG424", "EG426"};
            List<string> ConstMgmt = new List<string> { };
            List<string> ConstSci = new List<string> { };
            List<string> ElecAndCompEng = new List<string> { };
            List<string> ElecEng = new List<string> {"MAT225", "EG498", "EG110", "CHM120", "PHY215", "MAT275", "EG499", "CS113",
            "CS113L", "CS114", "CS114L", "CS219", "EE201", "EE220", "EE310", "EE318", "EE318L", "EE301", "EE301L", "EE330",
            "EE330L", "EE305", "EE306", "EG207", "EG310", "EG316", "EG333", "EG340", "MAT325", "MAT330", "MAT350", "PHY216",
            "PHY216L", "CHM120L", "PHY215L" };
            List<string> IT = new List<string> { };
            List<string> MechEng = new List<string> { };

            DegreeDatabase[0] = AeroEng;
            DegreeDatabase[1] = AirTrafMgmt;
            DegreeDatabase[2] = AviationMgmt;
            DegreeDatabase[3] = AviationOpMgmt;
            DegreeDatabase[4] = CompSci;
            DegreeDatabase[5] = ConstMgmt;
            DegreeDatabase[6] = ConstSci;
            DegreeDatabase[7] = ElecAndCompEng;
            DegreeDatabase[8] = ElecEng;
            DegreeDatabase[9] = IT;
            DegreeDatabase[10] = MechEng;

            List<string> DegreeList = new List<string> { "Aeronautical Engineering","Air Traffic Management","Aviation Management",
                "Aviation and Operations Management","Computer Science","Construction Management","Construction Science",
                "Electrical and Computer Engineering","Electrical Engineering","Information Technologies","Mechanical Engineering"};

            //adds additional entry to lists to make each list the same size, helps with looping for matching classes later
            do
            {
                for (int i = 0; i < DegreeDatabase.Count(); ++i)
                {
                    for (int j = 1; j < DegreeDatabase.Count(); ++j)
                    {
                        if (DegreeDatabase[i].Count() < DegreeDatabase[j].Count())
                        {
                            DegreeDatabase[i].Add($"added entry");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            } while (DegreeDatabase[0].Count() != DegreeDatabase[1].Count());

            //  ***This loop checks that all the degrees have the same number of 
            //  ***classes after the loop above adds additional entries to make them even
            //
            //for (int i = 0; i < DegreeDatabase[0].Count(); ++i)
            //{
            //    if (i == DegreeDatabase.Count())
            //    {
            //        break;
            //    }
            //    Console.WriteLine(DegreeDatabase[i].Count());
            //}
            //Console.ReadLine();



            for (int i = 0; i < DegreeDatabase.Count(); ++i)
            {
                for (int j = 0; j < Data.Count(); ++j)
                {
                    for (int k = 0; k < AeroEng.Count(); ++k)
                    {
                        if (Data.ElementAt(j).Split().ElementAt(0) == DegreeDatabase[i].ElementAt(k).Split().ElementAt(0))
                        {
                            EmptyDegreeDatabase[i].Add(Data.ElementAt(j));
                        }
                    }
                }
            }

            for (int i = 0; i < EmptyDegreeDatabase.Count(); ++i)
            {
                EmptyDegreeDatabase[i].Sort();
            }
            for (int i = 0; i < EmptyDegreeDatabase.Count(); ++i)
            {
                MessageBox.Show($"Classes towards {DegreeList.ElementAt(i)}: \n\n{string.Join(Environment.NewLine, EmptyDegreeDatabase[i])}");
            }

        }
    }
}