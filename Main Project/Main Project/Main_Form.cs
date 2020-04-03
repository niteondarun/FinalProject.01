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
            for (int i = 0; i <= Data.Count - 1; i++)
            {
                MessageBox.Show(Data[i]);
            }

        }
    }
}