/***
Program:  Degree Matcher
Purpose: To allow students to see what 
        degrees they are closest to
Author:  Cody.P, Paul Wood, Tyler Scott
Date: April 2,2020

FIX ME: blank entries show up in missing classes
FIX ME: "added entry" doesn't seem to be working because there is no filter to not include it yet and it still isn't showing up
FIX ME: Aesthetics of first form
CHECK ME: is it actually displaying correct information for both the completed classes and the missing classes
ADD ME: 2nd form with nice top 3 closest to completion degree specific displays to open instead of message boxes
ADD ME: Gen Ed List to display how many gen ed courses the student has completed and a more accurate credit count
       that the user is missing in that category.
**/

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
        public List<string> RemoveList()
        {
            List<String> removing = new List<String>();
            for (int i = 0; i < DegreeRemover.Items.Count; i++)
            {
                //checks for all checked blocks
                if ((DegreeRemover.GetItemChecked(i)))
                {
                    //This puts the selected checkbox strings into the list
                    removing.Add(DegreeRemover.GetItemText(DegreeRemover.Items[i]));
                }
            }

            return removing;
        }
        public List<string> GetData()
        {
            List<String> Data = new List<String>();
            //checks for all checked blocks
            for (int i = 0; i < ClassOptions.Items.Count; i++)
            {

                if (ClassOptions.GetItemChecked(i))
                {
                    //This puts the selected checkbox strings into the list
                    Data.Add(ClassOptions.GetItemText(ClassOptions.Items[i]));
                }
            }
            return Data;
        }

        public List<string> [] GetDegreeInfo()
        {
            //loop to display all the ones that got seletced and put into the list.
            //for (int i = 0; i <= Data.Count - 1; i++)
            //{
            //    MessageBox.Show(Data[i]);
            //}

            //Declare Arrays with size equal to entries in DegreeList
            List<string> DegreeList = new List<string> { "Aeronautical Engineering","Air Traffic Management",
                "Aviation Management", "Aviation and Operations Management","Computer Science",
                "Construction Management", "Electrical and Computer Engineering","Electrical Engineering",
                "Information Technologies","Mechanical Engineering"};
            List<string>[] DegreeDatabase = new List<string>[DegreeList.Count()];
            List<string>[] HaveClassesTowardsDegree = new List<string>[DegreeList.Count()];
            List<string>[] MissingClassesTowardsDegree;

            //Declare lists to hold classes towards each degree from user entry
            List<string> HaveAeroEng = new List<string> { };
            List<string> HaveAirTrafMgmt = new List<string> { };
            List<string> HaveAviationMgmt = new List<string> { };
            List<string> HaveAviationOpMgmt = new List<string> { };
            List<string> HaveCompSci = new List<string> { };
            List<string> HaveConstMgmt = new List<string> { };
            List<string> HaveElecAndCompEng = new List<string> { };
            List<string> HaveElecEng = new List<string> { };
            List<string> HaveIT = new List<string> { };
            List<string> HaveMechEng = new List<string> { };

            //assign lists to array
            HaveClassesTowardsDegree[0] = HaveAeroEng;
            HaveClassesTowardsDegree[1] = HaveAirTrafMgmt;
            HaveClassesTowardsDegree[2] = HaveAviationMgmt;
            HaveClassesTowardsDegree[3] = HaveAviationOpMgmt;
            HaveClassesTowardsDegree[4] = HaveCompSci;
            HaveClassesTowardsDegree[5] = HaveConstMgmt;
            HaveClassesTowardsDegree[6] = HaveElecAndCompEng;
            HaveClassesTowardsDegree[7] = HaveElecEng;
            HaveClassesTowardsDegree[8] = HaveIT;
            HaveClassesTowardsDegree[9] = HaveMechEng;

            //Declare lists with complete list of classes for degree
            List<string> AeroEng = new List<string> {"MAT225", "EG110", "EG498", "CHM120", "PHY215", "MAT275",
                "EG499", "EG201", "EG202", "EG203", "EG209", "EG308", "EG314", "EG326", "EG330", "EG412",
                "EG418", "EG418FT", "EG419", "EG419FT", "EG200", "EG207", "EG208", "EG310", "EG316", "EG333",
                "MAT325", "MAT330", "MAT350", "PHY216", "PHY216L", "CHM120L", "PHY215L",
                "One of the Following: EG340 or MAT730",
                "21 Credits from General Education",
                "", "", "", "", ""};
            List<string> AirTrafMgmt = new List<string> { "MAT240", "PSY108", "AM205", "AV201", "AV490", "ACC105",
                "AM201", "INT105", "MKT105", "QSO205", "OL215", "OL318", "SB100", "SB105", "AV205", "AV206",
                "AM220", "AV306", "AV410", "AV491", "AT110", "AT210", "AT210L", "AT310", "AT315", "AT315L", "AT410",
                "AT410L", "AT415", "AT415L", "AM340", "AM340L",
                "27 Credits from General Education",
                "12 Credits as Free Electives",
                "", "", "", "", "", ""};
            List<string> AviationMgmt = new List<string> { "MAT240", "PSY108", "AM205", "AV201", "AV490", "ACC105",
                "AM201", "INT105", "MKT105", "QSO205", "OL215", "OL318", "SB100", "SB105", "AV205", "AV206", "AM220",
                "AV300", "AV306", "AV410", "AV491", "AM215", "AV314", "AM320", "AM330", "AM340", "AM460", "AM404",
                "QSO340", "QSO345", "ACC202", "ACC215", "ACC307",
                "27 Additional Credits from General Education",
                "9 Credits from Major Electives or Concentration",
                "18 Credits as Free Electives",
                "", "", "", ""};
            List<string> AviationOpMgmt = new List<string> {"FYS101", "PCC201", "PSY108", "AV442", "PHY101", "AV201",
                "AV490", "ACC105", "AM201", "INT105", "MKT105", "QSO205", "OL215", "OL318", "SB100", "SB105", "AT110",
                "AV220", "AV306", "AV401", "AV410", "AV491", "PLT101", "PLT102", "PLT103", "PLT104", "PLT105", "AV207",
                "PLT202", "PLT203", "PLT205", "PLT305", "PLT405",
                "One of the following: MAT140 or MAT225",
                "18 Additional Credits from General Education",
                "9 Credits as Free Electives",
                "", "", "", ""};
            List<string> CompSci = new List<string> { "MAT225", "CS203", "CS204", "MAT275", "PHY215", "MAT350", "CS113",
                "CS113L", "CS114", "CS114L", "CS217", "CS218", "CS219", "CS238", "CS303", "CS304", "CS312", "CS317",
                "CS321", "CS361", "MAT230", "MAT235", "PHY215L", "CS413", "CS414", "CS490", "CS231", "CS328", "CS331",
                "CS407", "CS411", "CS425", "EG424", "EG426",
                "15 Credits as Free Electives",
                "", "", "", "", ""};
            List<string> ConstMgmt = new List<string> { "MAT225", "CM400", "FAS260", "PSY108", "CHM101", "MAT240",
                "CM498", "ACC105", "CM380", "INT105", "MKT105", "QSO205", "OL215", "OL318", "SB100", "SB105", "CM100",
                "CM115", "CM120", "CM200", "CM230", "CM250", "CM275", "CM280", "CM320", "CM370", "CM375", "CM390",
                "CM410", "CM415", "CM485", "EG202", "PHY215", "PHY215L",
                "21 Additional Credits from General Education",
                "9 Credits as Free Electives",
                "", "", "", ""};
            List<string> ElecAndCompEng = new List<string> { "MAT225", "EG110", "EG498", "CHM120", "PHY215",
                "MAT275", "EG499", "CS113", "CS113L", "CS114", "CS114L", "CS219", "EE201", "EE220", "EE301",
                "EE301L", "EE318", "EE318L", "EE301", "EE301L", "EE330", "EE330L", "EG200", "EG207", "EG208",
                "EG310", "EG316", "EG333", "EG340", "MAT325", "MAT330", "MAT350", "CHM120L", "PHY215L","PHY216",
                "PHY216L", "One of the Following:  CS317 & CS328 or EE310 & EE304",
                "21 Additional Credits from General Education",
                "9 Credits from Major Electives or Concentration",
                "6 Credits as Free Electives"};
            List<string> ElecEng = new List<string> {"MAT225", "EG498", "EG110", "CHM120", "PHY215", "MAT275",
                "EG499", "CS113", "CS113L", "CS114", "CS114L", "CS219", "EE201", "EE220", "EE310", "EE318",
                "EE318L", "EE301", "EE301L", "EE330", "EE330L", "EE305", "EE306", "EG207", "EG310", "EG316",
                "EG333", "EG340", "MAT325", "MAT330", "MAT350", "PHY216", "PHY216L", "CHM120L", "PHY215L",
                "21 Additional Credits from General Education",
                "9 Credits from Major Electives or Concentration",
                "6 Credits as Free Electives",
                "", ""};
            List<string> IT = new List<string> { "ECO201", "PHY101", "MAT225", "CS110", "CS231", "CS238", "IT145",
                "IT200", "IT201", "IT221", "IT315", "QSO340", "SOC335", "IT340", "IT361", "IT380", "IT385",
                "IT412", "OL125", "MAT241", "IT490",
                "36 Additional Credits from General Education",
                "12 Credits from IT CS or CIS within course number range 300-499",
                "9 Credits as Free Electives",
                "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
            List<string> MechEng = new List<string> { "MAT225", "EG110", "EG498", "CHM120", "PHY215", "MAT275",
                "EG499", "EG112", "EG201", "EG202", "EG203", "EG209", "EG325", "EG341", "EG410", "EG200",
                "EG207", "EG208", "EG310", "EG316", "EG333", "MAT325", "MAT330", "MAT350", "PHY216", "PHY216L",
                "CHM120L", "PHY215L", "Two of the following: EG318, EG350, EG420",
                "One of the following: EG340 or MAT370",
                "21 Additional Credits from General Education",
                "Choose Concentration or 9 Credits from EG within course number range 300-499",
                "6 Credits as Free Electives",
                "", "", "", "", "", "", ""};

            //assign degrees to array
            DegreeDatabase[0] = AeroEng;
            DegreeDatabase[1] = AirTrafMgmt;
            DegreeDatabase[2] = AviationMgmt;
            DegreeDatabase[3] = AviationOpMgmt;
            DegreeDatabase[4] = CompSci;
            DegreeDatabase[5] = ConstMgmt;
            DegreeDatabase[6] = ElecAndCompEng;
            DegreeDatabase[7] = ElecEng;
            DegreeDatabase[8] = IT;
            DegreeDatabase[9] = MechEng;

            //copy full degrees to missing classes array
            MissingClassesTowardsDegree = DegreeDatabase;

            //used to determine count of classes for each degree to aid in making them all equal length for easy looping
            //for (int i = 0; i < DegreeDatabase.Count() - 1; ++i)
            //{
            //    MessageBox.Show(DegreeDatabase[i].Count().ToString());    
            //}

            //loops add classes to array of classes towards degree and remove classes from the missing class array
            for (int i = 0; i < DegreeDatabase.Count() - 1; ++i)
            {
                List<string> Classes = GetData();
                for (int j = 0; j < Classes.Count() - 1; ++j)
                {
                    for (int k = 0; k < AeroEng.Count() - 1; ++k)
                    {
                        if (Classes.ElementAt(j).Split().ElementAt(0) == DegreeDatabase[i].ElementAt(k))
                        {
                            HaveClassesTowardsDegree[i].Add(Classes.ElementAt(j));
                            MissingClassesTowardsDegree[i].ElementAt(k).Equals("added entry"); //replaces class with "added entry" to avoid null exception
                        }
                    }
                }
            }

            //ATTEMPT to sort classes alphabetically, not sure if this is working but I think it is
            for (int i = 0; i < HaveClassesTowardsDegree.Count() - 1; ++i)
            {
                HaveClassesTowardsDegree[i].Sort();
                MissingClassesTowardsDegree[i].Sort();
            }

            /*  //display classes that user checked that are applicable to each degree
              for (int i = 0; i < HaveClassesTowardsDegree.Count() - 1; ++i)
              {
                  MessageBox.Show($"Classes towards {DegreeList.ElementAt(i)}: \n\n{string.Join(Environment.NewLine, HaveClassesTowardsDegree[i])}");
              }

              //display classes for each degree that user still needs to take in order to finish degree
              for (int i = 0; i < MissingClassesTowardsDegree.Count() - 1; ++i)
              {
                  MessageBox.Show($"Classes missing for {DegreeList.ElementAt(i)}: \n\n{string.Join(Environment.NewLine, MissingClassesTowardsDegree[i])}");

              }
  */

            //The following is the FIRST ATTEMPT to display only the top three degrees that the user is closest
            //to and the classes they have left to complete for that degree. Did not work last run

            //Array.Sort(MissingClassesTowardsDegree);
            //Array.Reverse(MissingClassesTowardsDegree);
            //for (int i = 0; i < 3; ++i)
            //{
            //    MessageBox.Show($"Classes missing for {DegreeList.ElementAt(i)}: \n\n{string.Join(Environment.NewLine, MissingClassesTowardsDegree[i])}");
            //}
            return MissingClassesTowardsDegree;
        }

        private void ClassOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Texts_Click(object sender, EventArgs e)
        {

        }        
        private void Match_Click(object sender, EventArgs e)
        {
            GetDegreeInfo();
            RemoveDegree();
            GetData();
            DisplayDegree f1 = new DisplayDegree();
            f1.Show(this);
          
        }
       public List<string> RemoveDegree()
        {
            List<string> ListofDegree = new List<string>{ "Aeronautical Engineering","Air Traffic Management",
                "Aviation Management", "Aviation and Operations Management","Computer Science",
                "Construction Management", "Electrical and Computer Engineering","Electrical Engineering",
                "Information Technologies","Mechanical Engineering"};
            List<string> removing = RemoveList();
            for (int i = 0; i <= removing.Count - 1; i++)
            {
                ListofDegree.Remove(removing[i]);

            }
            return ListofDegree;
        }
    }
}