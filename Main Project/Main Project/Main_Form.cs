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
            List<String> Data = new List<String> { };
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

        public List<string>[] GetDegreeInfo()
        {
            List<string> Classes = new List<string> { };
            Classes = GetData();

            //Declare Arrays with size equal to entries in DegreeList
            List<string> DegreeList = new List<string> { "Aeronautical Engineering","Air Traffic Management",
                "Aviation Management", "Aviation and Operations Management","Computer Science",
                "Construction Management", "Electrical and Computer Engineering","Electrical Engineering",
                "Information Technologies","Mechanical Engineering","Biology","Environmental Science","Game Art and Development","Game Programming and Development","Graphic Design and Media Arts","Communication"};
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
            List<string> HaveBiology = new List<string> { };
            List<string> HaveEnvirSci = new List<string> { };
            List<string> HaveGameArtDev = new List<string> { };
            List<string> HaveGameProAndDev = new List<string> { };
            List<string> HaveGraphDesAndMedArt = new List<string> { };
            List<string> HaveCommunication = new List<string> { };

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
            HaveClassesTowardsDegree[10] = HaveBiology;
            HaveClassesTowardsDegree[11] = HaveEnvirSci;
            HaveClassesTowardsDegree[12] = HaveGameArtDev;
            HaveClassesTowardsDegree[13] = HaveGameProAndDev;
            HaveClassesTowardsDegree[14] = HaveGraphDesAndMedArt;
            HaveClassesTowardsDegree[15] = HaveCommunication;

            //Declare lists with complete list of classes for degree
            List<string> AeroEng = new List<string> { "EG201 - Fluid Mechanics", "EG202 - Mechanics of Materials I", "EG203 - Dynamics", "EG209 - Thermodynamics I", "EG308 - Gas Dynamics", "EG314 - Aerodynamics", "EG326 - Aircraft Structures", "EG330 - Propulsion", "EG412 - Aircraft Design I", "EG418 - Flight Dynamics I (Performance)", "EG418FT - Flight Testing - Performance", "EG419 - Flight Dynamics II/Stability/Control", "EG419FT - Flight Testing - Stability and Control", "EG200 - Statics", "EG207 - Instrumentation & Measurements", "EG208 - Materials Science", "EG310 - Junior Engineering Design", "EG316 - Electrical Circuits", "EG333 - Control Systems Analysis", "MAT325 - Calculus III: Multivariable Calculus", "MAT330 - Differential Equations", "MAT350 - Applied Linear Algebra", "PHY216 - Physics II", "PHY216L - Physics II Lab", "CHM120L - General Chemistry I Lab", "PHY215L - Physics I Lab", "EG340 - Probability and Statistics for Engineers", "MAT370 - Numerical Analysis", "21 Credits from General Education"};

            List<string> AirTrafMgmt = new List<string> { "MAT240 - Applied Statistics", "PSY108 - Introduction to Psychology", "AM205 - Aircraft Operating Economics", "AV201 - Aviation Meteorology", "AV490 - Aviation Internship I", "ACC105 - Foundations of Accounting I", "AM201 - Aviation Law", "INT105 - International Business: A Macro Perspective", "MKT105 - Foundations of Marketing", "QSO205 - Business Operations Management", "OL215 - Principles of Management", "OL318 - Employee and Labor Relations", "SB100 - Integration & Application of Business I", "SB105 - Integration & Application of Business II", "AV205 - Aircraft Operations I", "AV206 - Aircraft Operations II", "AM220 - Airport Operations", "AV306 - Human Factors of Flight", "AV410 - Aviation Safety", "AV491 - Aviation Internship II", "AT110 - Fundamentals of Air Traffic Control", "AT210 - Air Traffic Control Tower Operations", "AT210L - Air Traffic Control Tower Operating Lab", "AT310 - Airspace and Air Traffic Systems Management", "AT310L - Air Space/Air Traffic Management Lab", "AT315 - AT Management/Operating Environment", "AT315L - AT Management/Operating Environmental Lab", "AT410 - Sector Resource Management", "AT410L - Sector Resource Management Lab", "AT415 - AT Management/AS Mod/Pol/DM", "AT415L - AT Management/AS Mod/Pol/DM Lab", "AM340 - Airport and Airspace Capacity Management", "AM340L - Airport and Airspace Capacity Management", "27 Credits from General Education", "12 Credits as Free Electives"};

            List<string> AviationMgmt = new List<string> { "MAT240 - Applied Statistics", "PSY108 - Introduction to Psychology", "AM205 - Aircraft Operating Economics", "AV201 - Aviation Meteorology", "AV490 - Aviation Internship I", "ACC105 - Foundations of Accounting I", "AM201 - Aviation Law", "INT105 - International Business: A Macro Perspective", "MKT105 - Foundations of Marketing", "QSO205 - Business Operations Management", "OL215 - Principles of Management", "OL318 - Employee and Labor Relations", "SB100 - Integration & Application of Business I", "SB105 - Integration & Application of Business II", "AV205 - Aircraft Operations I", "AV206 - Aircraft Operations II", "AM220 - Airport Operations", "AV300 - Aviation Logistics", "AV306 - Human Factors of Flight", "AV410 - Aviation Safety", "AV491 - Aviation Internship II", "AM215 - General Aviation Operations", "AV314 - Pilot Aerodynamic Fundamentals", "AM320 - Air Carrier Operation", "AM330 - Business & Corporate Aviation", "AM340 - Airport and Airspace Capacity Management", "AM460 - Airport Planning and Management", "AM404 - Studies/International Aerospace", "QSO340 - Project Management", "QSO345 - Project Management for CAPM® Certification", "ACC202 - Managerial Accounting", "ACC215 - Fundamentals of Financial Accounting", "ACC307 - Intermediate Accounting I", "27 Additional Credits from General Education", "9 Credits from Major Electives or Concentration", "18 Credits as Free Electives"};

            List<string> AviationOpMgmt = new List<string> {"FYS101 - First Year Seminar", "PCC201 - Professional Communication and Career Planning", "PSY108 - Introduction to Psychology", "AV442 - Aviation Economics and Policy", "PHY101 - Principles of Physics", "AV201 - Aviation Meteorology", "AV490 - Aviation Internship I", "MAT140 - Precalculus", "MAT225 - Calculus I: Single-Variable Calculus", "ACC105 - Foundations of Accounting I", "AM201 - Aviation Law", "INT105 - International Business: A Macro Perspective", "MKT105 - Foundations of Marketing", "QSO205 - Business Operations Management", "OL215 - Principles of Management", "OL318 - Employee and Labor Relations", "SB100 - Integration & Application of Business I", "SB105 - Integration & Application of Business II", "AT110 - Fundamentals of Air Traffic Control", "AV220 - Advanced Aircraft and Navigation Systems", "AV306 - Human Factors of Flight", "AV401 - Aerodynamics and Aircraft Performance", "AV410 - Aviation Safet", "AV491 - Aviation Internship II", "PLT101 - Private Pilot Ground", "PLT102 - Private Pilot Flight", "PLT103 - Instrument Ground Training", "PLT104 - Instrument Flight Training", "PLT105 - Commercial Pilot I", "AV207 - Fundamentals of Instruction", "PLT202 - Certified Flight Instructor I", "PLT203 - Certified Flight Instructor II", "PLT205 - Commercial Pilot II", "PLT305 - Commercial Pilot III", "PLT405 - Commercial Multi-Engine", "9 Credits as Free Electives"};

            List<string> CompSci = new List<string> { "MAT225 - Calculus I: Single-Variable Calculus", "CS203 - Sophomore Software Engineering I", "CS204 - Sophomore Software Engineering II", "MAT275 - Calculus II: Integration & Series", "PHY215 - Physics I", "MAT350 - Applied Linear Algebra", "CS113 - Introduction to Programming", "CS113L - Intro to Programming Lab", "CS114 - Intro to Software Engineering", "CS114L - Introduction to Software Engineering Lab", "CS217 - Object Oriented Programming", "CS218 - Data Structure and Algorithms", "CS219 - Computer Architecture I", "CS238 - UNIX Programming", "CS303 - Junior Software Engineering I", "CS304 - Junior Software Engineering II", "CS312 - Analysis of Algorithms", "CS317 - Computer Networks", "CS321 - Programming Language Concept", "CS361 - Computer Software and Operating Systems", "MAT230 - Discrete Mathematics", "MAT235 - Discrete Mathematics II", "PHY215L - Physics I Lab", "CS413 - Software Engineering Project I", "CS414 - Software Engineering Project II", "CS490 - Computer Science Internship", "CS231 - Database Systems", "CS328 - Embedded Systems", "CS331 - Computer Security", "CS407 - Principles of Machine Learning", "CS411 - Artificial Intelligence", "CS425 - Systems Architecture", "EG424 - Industrial Robots", "EG426 - Mobile Robots", "15 Free Electives" };

            List<string> ConstMgmt = new List<string> { "MAT225 - Calculus I: Single-Variable Calculus", "CM400 - Construction Project Management & Safety", "FAS260 - History of Architecture", "PSY108 - Introduction to Psychology", "CHM101 - Fundamentals of Chemistry", "MAT240 - Applied Statistics", "CM498 - Senior Capstone Project", "ACC105 - Foundations of Accounting I", "CM380 - Construction Law and Contracts", "INT105 - International Business: A Macro Perspective", "MKT105 - Foundations of Marketing", "QSO205 - Business Operations Management", "OL215 - Principles of Management", "OL318 - Employee and Labor Relations", "SB100 - Integration & Application of Business I", "SB105 - Integration & Application of Business II", "CM100 - Fundamentals of Building Construction and Management", "CM115 - Construction Plan Reading and Building Codes", "CM120 - Computer Graphics Applications for Construction", "CM200 - Statics for Building Construction", "CM230 - Construction Surveying", "CM250 - Heavy Construction Equipment", "CM275 - Introduction to Building Structures", "CM280 - Passive Environmental Design Systems", "CM320 - Construction Methods and Materials", "CM370 - Construction Estimating and Scheduling", "CM375 - Building Systems", "CM390 - Materials Testing and Quality Control", "CM410 - Advanced Estimating and Bid Analysis", "CM415 - Construction Planning and Scheduling", "CM485 - Construction Business and Finance", "EG202 - Mechanics of Materials I", "PHY215 - Physics I", "PHY215L - Physics I Lab", "21 Additional Credits from General Education", "9 Credits as Free Electives"};

            List<string> ElecAndCompEng = new List<string> { "MAT225 - Calculus I: Single-Variable Calculus", "EG110 - Engineering Design I", "EG498 - Capstone Design I", "CHM120 - General Chemistry I", "PHY215 - Physics I", "MAT275 - Calculus II: Integration & Series", "EG499 - Capstone Design II", "CS113 - Introduction to Programming", "CS113L - Intro to Programming Lab", "CS114 - Intro to Software Engineering", "CS114L - Introduction to Software Engineering Lab", "CS219 - Computer Architecture I", "EE201 - Signals and Systems", "EE220 - Electromagnetics", "EE301 - Digital Circuits", "EE301L - Digital Circuits Lab", "EE330 - Analog Electronics", "EE330L - Analog Electronics", "CS317 - Computer Networks", "CS328 - Embedded Systems", "EE310 - Communication Systems", "EE304 - Electrical Machines and Power Systems", "EG200 - Statics", "EG207 - Instrumentation & Measurements", "EG208 - Materials Science", "EG310 - Junior Engineering Design", "EG316 - Electrical Circuits", "EG333 - Control Systems Analysis", "EG340 - Probability and Statistics for Engineers", "MAT325 - Calculus III: Multivariable Calculus", "MAT330 - Differential Equations", "MAT350 - Applied Linear Algebra", "CHM120L - General Chemistry I Lab", "PHY215L - Physics I Lab", "PHY216 - Physics II", "PHY216L - Physics II Lab", "21 Additional Credits from General Education", "9 Credits from Major Electives or Concentration", "6 Credits as Free Electives"};
         
            List<string> ElecEng = new List<string> {"MAT225 - Calculus I: Single-Variable Calculus", "EG498 - Capstone Design I", "EG110 - Engineering Design I", "CHM120 - General Chemistry I", "PHY215 - Physics I", "MAT275 - Calculus II: Integration & Series", "EG499 - Capstone Design II", "CS113 - Introduction to Programming", "CS113L - Intro to Programming Lab", "CS114 - Intro to Software Engineering", "CS114L - Introduction to Software Engineering Lab", "CS219 - Computer Architecture I", "EE201 - Signals and Systems", "EE220 - Electromagnetics", "EE310 - Communication Systems", "EE318 - Electrical Circuits II", "EE318L - Electrical Circuits II Lab", "EE301 - Digital Circuits", "EE301L - Digital Circuits Lab", "EE330 - Analog Electronics", "EE330L - Analog Electronics", "EE305 - Electrical Machines", "EE306 - Electrical Power Systems", "EG207 - Instrumentation & Measurements", "EG310 - Junior Engineering Design", "EG316 - Electrical Circuits", "EG333 - Control Systems Analysis", "EG340 - Probability and Statistics for Engineers", "MAT325 - Calculus III: Multivariable Calculus", "MAT330 - Differential Equations", "MAT350 - Applied Linear Algebra", "PHY216 - Physics II", "PHY216L - Physics II Lab", "CHM120L - General Chemistry I Lab", "PHY215L - Physics I Lab", "21 Additional Credits from General Education", "9 Credits from Major Electives or Concentration", "6 Credits as Free Electives"};

            List<string> IT = new List<string> {"ECO201 - Microeconomics", "PHY101 - Principles of Physics", "MAT224 - Calculus I: Single-Variable Calculus Part B", "MAT225 - Calculus I: Single-Variable Calculus", "CS110 - Fundamentals of Programming", "CS231 - Database Systems", "CS238 - UNIX Programming", "IT145 - Foundation in Application Development", "IT200 - Fundamentals of Information Technology", "IT201 - Computer Platform Technologies", "IT221 - Web-based Information Technology", "IT315 - Object Oriented Analysis and Design", "QSO340 - Project Management", "SOC335 - Technology and Society", "IT340 - Network and Telecommunication Management", "IT361 - Systems and Network Administration", "IT380 - Cybersecurity and Information Assurance", "IT385 - Information Technology Communications", "IT412 - Cyberlaw and Ethics", "OL125 - Human Relations in Administration", "MAT241 - Modern Statistics with Software", "IT490 - Information Technology Internship", "MAT124 - Calculus I: Single-Variable Calculus Part A", "36 Additional Credits from General Education", "12 Credits from IT CS or CIS within course number range 300-499", "9 Credits as Free Electives"};

            List<string> MechEng = new List<string> {"MAT225 - Calculus I: Single - Variable Calculus", "EG110 - Engineering Design I", "EG498 - Capstone Design I", "CHM120 - General Chemistry I", "PHY215 - Physics I", "MAT275 - Calculus II: Integration & Series", "EG499 - Capstone Design II", "EG112 - Engineering Design II", "EG201 - Fluid Mechanics", "EG202 - Mechanics of Materials I", "EG203 - Dynamics", "EG209 - Thermodynamics I", "EG325 - Mechanics of Materials II", "EG341 - Design of Machine Components", "EG410 - Heat Transfer", "EG318 - Thermodynamics II", "EG350 - Advanced Dynamics of Mechanical Systems", "EG420 - Design of Thermo-Fluid Systems", "EG200 - Statics", "EG207 - Instrumentation & Measurements", "EG208 - Materials Science", "EG310 - Junior Engineering Design", "EG316 - Electrical Circuits", "EG333 - Control Systems Analysis", "MAT325 - Calculus III: Multivariable Calculus", "MAT330 - Differential Equations", "MAT350 - Applied Linear Algebra", "PHY216 - Physics II", "PHY216L - Physics II Lab", "CHM120L - General Chemistry I Lab", "PHY215L - Physics I Lab", "EG340 - Probability and Statistics for Engineers", "MAT370 - Numerical Analysis", "21 Additional Credits from General Education", "Choose Concentration or 9 Credits from EG within course number range 300-499", "6 Credits as Free Electives"};

            List<string> Biology = new List<string>{"PSY108 - Introduction to Psychology", "SOC112 - Introduction to Sociology", "MAT241 - Modern Statistics with Software", "MAT225 - Calculus I: Single-Variable Calculus", "COM212 - Public Speaking", "SOC312 - Biosociology", "MAT300 - Applied Statistics II: Regression Analysis", "PSY225 - Health Psychology", "MAT275 - Calculus II: Integration & Series", "MAT330 - Differential Equations", "MAT350 - Applied Linear Algebra", "BIO120 - General Biology I", "BIO120L - General Biology I Lab", "BIO121 - General Biology II", "BIO121L - General Biology II Lab", "CHM120 - General Chemistry I", "CHM120L - General Chemistry I Lab", "CHM121 - General Chemistry II", "CHM121L - General Chemistry II Lab", "CHM309 - Biological Chemistry", "CHM309L - Biological Chemistry Lab", "PHY101 - Principles of Physics", "BIO205 - Human Anatomy and Physiology I", "BIO205L - Human Anatomy and Physiology I Lab", "BIO211 - Human Anatomy and Physiology II", "BIO211L - Human Anatomy and Physiology II Lab", "BIO270 - Genetics", "BIO280 - The Microbial World", "BIO280L - The Microbial World Lab", "BIO110 - Introduction to Public Health", "BIO200 - Bioethics", "BIO302 - Field Ornithology", "BIO303 - Principles of Nutrition", "BIO312 - Zoology", "BIO314 - Introductory Botany", "BIO320 - Neuroscience", "BIO325 - Animal Behavior", "BIO330 - Conservation Biology", "BIO340 - Human Health and the Environment", "BIO424 - Vertebrate Morphology", "BIO431 - Invasive Biology",  "BIO480 - Independent Study"};

            List<string> EnvirSci = new List<string>{ "MAT240 - Applied Statistics","PHY101 - Principles of Physics", "GEO200 - World Geography", "HIS270 - American Environmental History", "PHL363 - Environmental Ethics", "BIO120 - General Biology I", "BIO120L - General Biology I Lab", "BIO315 - Ecological Principles and Field Methods", "CHM120 - General Chemistry I", "CHM120L - General Chemistry I Lab", "ENV101 - Environmental Science", "ENV111 - Environmental Science Compass", "ENV220 - GIS, Field Methods and Technology", "ENV250 - Environmental Science Research Methods", "ENV440 - Senior Seminar", "PHY105 - Geology" };

            List<string> GameArtDev = new List<string>{"BIO210 - Introduction to Anatomy and Physiology", "PSY108 - Introduction to Psychology", "ENG226 - Introduction to Creative Writing", "FAS110 - Introductory Drawing", "LIT229 - World Mythology", "GRA105 - Concept Art and Color Theory", "GRA201 - Intro to Digital Sculpting", "GRA202 - 3-D Modeling and Animation", "GRA211 - Interactive Animation", "GRA212 - 3-D Character Animation", "GRA215 - Texturing for Games", "GRA311 - Environment Design", "GRA401 - Character Design", "GRA402 - Creature Design", "GRA440 - 3-D Art and Design", "FAS310 - Illustration"};

            List<string> GameProAndDev = new List<string>{"PHY101 - Principles of Physics", "PSY108 - Introduction to Psychology", "MAT225 - Calculus I: Single-Variable Calculus", "COM212 - Public Speaking", "ENG220 - Business Communication", "MAT350 - Applied Linear Algebra", "GAM110 - Game Programming I", "GAM120 - Introduction to Game Development", "GAM150 - Game Design I: Systems and Mechanics", "GAM220 - Game Programming II", "GAM230 - Scripting for Games", "GAM312 - Gameplay Systems Development", "GAM345 - Algorithms and Data Structures for Games", "GAM350 - Multiplayer Video Game Development", "GAM405 - Artificial Intelligence for Games", "GAM415 - Graphics Game Engine", "GAM495 - Game Programming Capstone", "GRA202 - 3-D Modeling and Animation", "GRA315 - Game Design and Production", "GRA317 - Studio Environment ", "COM230 - Graphics and Layout in Print Media", "GRA220 - Introduction to Digital Imaging", "IT205 - Digital Music", "IT210 - Business Systems Analysis and Design", "IT315 - Object Oriented Analysis and Design", "IT330 - Database Design and Management", "IT340 - Network and Telecommunication Management"};

            List<string> GraphDesAndMedArt = new List<string>{"FAS226 - Digital Photography","IT270 - Web Site Design", "COM212 - Public Speaking", "COM230 - Graphics and Layout in Print Media", "COM232 - Desktop Publishing", "COM234 - Digital Toolbox", "COM244 - Digital Video Production: Level I", "GRA101 - Basic Design and Color Theory", "GRA310 - Digital Graphic Design for the Web", "GRA340 - Typography", "GRA410 - Advanced Digital Graphic Design for Web", "GRA420 - Advanced Digital Imaging", "GRA470 - User Interface and Experience", "FAS320 - History of Design", "FAS326 - History of Photography"};

            List<string> Communication = new List<string>{"ENG220 - Business Communication", "GRA310 - Digital Graphic Design for the Web", "POL210 - American Politics", "PSY257 - Social Psychology", "SCI219 - Environmental Issues", "SOC328 - Sociology of Aging", "COM130 - Media Communication and Visual Literacy", "COM212 - Public Speaking", "COM227 - Public Relations", "COM234 - Digital Toolbox", "COM235 - Multimedia Journalism", "COM244 - Digital Video Production: Level I", "COM310 - Social Media", "COM320 - Exploring World Cultures/Mass Media", "COM322 - Advanced Public Speaking", "COM410 - Applied Strategic Communication", "COM430 - Organizational Communications"};

            //assign degrees to array
            DegreeDatabase[0] = AeroEng;
            DegreeDatabase[1] = AirTrafMgmt;
            DegreeDatabase[2] = AviationMgmt;
            DegreeDatabase[3] = AviationOpMgmt;
            DegreeDatabase[4] = Biology;
            DegreeDatabase[5] = Communication;
            DegreeDatabase[6] = CompSci;
            DegreeDatabase[7] = ConstMgmt;
            DegreeDatabase[8] = ElecAndCompEng;
            DegreeDatabase[9] = ElecEng;
            DegreeDatabase[10] = EnvirSci;
            DegreeDatabase[11] = GameArtDev;
            DegreeDatabase[12] = GameProAndDev;
            DegreeDatabase[13] = GraphDesAndMedArt;
            DegreeDatabase[14] = IT;
            DegreeDatabase[15] = MechEng;
    
            //copy full degrees to missing classes array
            MissingClassesTowardsDegree = DegreeDatabase;

           
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
            DisplayDegree f1 = new DisplayDegree();
            f1.Show(this);
        }
        //produces the list with the class they don't want removed
       public List<string> RemoveDegree()
        {
            List<string> ListofDegree = new List<string>{ "Aeronautical Engineering","Air Traffic Management",
                "Aviation Management", "Aviation and Operations Management","Computer Science",
                "Construction Management", "Electrical and Computer Engineering","Electrical Engineering",
                "Information Technologies","Mechanical Engineering","Biology","Environmental Science",
                "Game Art and Development","Game Programming and Development","Graphic Design and Media Arts","Communication"};
            ListofDegree.Sort();
            List<string> removing = RemoveList();
            //goes through the selected code to remove
            for (int i = 0; i <= removing.Count - 1; i++)
            {
                ListofDegree.Remove(removing[i]);

            }
            return ListofDegree;
        }

        private void Degree_Matcher_Load(object sender, EventArgs e)
        {

        }

        private void DegreeRemover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 