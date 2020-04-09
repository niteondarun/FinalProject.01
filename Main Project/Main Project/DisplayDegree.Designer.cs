namespace Main_Project
{
    partial class DisplayDegree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DegreeThree = new System.Windows.Forms.Panel();
            this.Degree3Txt = new System.Windows.Forms.ListBox();
            this.Degree3 = new System.Windows.Forms.Label();
            this.DegreeTwo = new System.Windows.Forms.Panel();
            this.Degree2Txt = new System.Windows.Forms.ListBox();
            this.Degree2 = new System.Windows.Forms.Label();
            this.DegreeOne = new System.Windows.Forms.Panel();
            this.Degree1Txt = new System.Windows.Forms.ListBox();
            this.Degree1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Button();
            this.DegreeThree.SuspendLayout();
            this.DegreeTwo.SuspendLayout();
            this.DegreeOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // DegreeThree
            // 
            this.DegreeThree.Controls.Add(this.Degree3);
            this.DegreeThree.Location = new System.Drawing.Point(574, 1);
            this.DegreeThree.Name = "DegreeThree";
            this.DegreeThree.Size = new System.Drawing.Size(291, 187);
            this.DegreeThree.TabIndex = 0;
            // 
            // Degree3Txt
            // 
            this.Degree3Txt.FormattingEnabled = true;
            this.Degree3Txt.ItemHeight = 16;
            this.Degree3Txt.Items.AddRange(new object[] {
            " Classes needed:"});
            this.Degree3Txt.Location = new System.Drawing.Point(283, 186);
            this.Degree3Txt.Name = "Degree3Txt";
            this.Degree3Txt.Size = new System.Drawing.Size(291, 324);
            this.Degree3Txt.Sorted = true;
            this.Degree3Txt.TabIndex = 4;
            // 
            // Degree3
            // 
            this.Degree3.AutoSize = true;
            this.Degree3.BackColor = System.Drawing.Color.Transparent;
            this.Degree3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degree3.Location = new System.Drawing.Point(6, 8);
            this.Degree3.Name = "Degree3";
            this.Degree3.Size = new System.Drawing.Size(82, 22);
            this.Degree3.TabIndex = 0;
            this.Degree3.Text = "Degree 3";
            // 
            // DegreeTwo
            // 
            this.DegreeTwo.Controls.Add(this.Degree2);
            this.DegreeTwo.Location = new System.Drawing.Point(283, 1);
            this.DegreeTwo.Name = "DegreeTwo";
            this.DegreeTwo.Size = new System.Drawing.Size(291, 187);
            this.DegreeTwo.TabIndex = 1;
            // 
            // Degree2Txt
            // 
            this.Degree2Txt.FormattingEnabled = true;
            this.Degree2Txt.ItemHeight = 16;
            this.Degree2Txt.Items.AddRange(new object[] {
            " Classes needed:"});
            this.Degree2Txt.Location = new System.Drawing.Point(574, 186);
            this.Degree2Txt.Name = "Degree2Txt";
            this.Degree2Txt.Size = new System.Drawing.Size(291, 324);
            this.Degree2Txt.Sorted = true;
            this.Degree2Txt.TabIndex = 5;
            // 
            // Degree2
            // 
            this.Degree2.AutoSize = true;
            this.Degree2.BackColor = System.Drawing.Color.Transparent;
            this.Degree2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degree2.Location = new System.Drawing.Point(9, 11);
            this.Degree2.Name = "Degree2";
            this.Degree2.Size = new System.Drawing.Size(82, 22);
            this.Degree2.TabIndex = 1;
            this.Degree2.Text = "Degree 2";
            // 
            // DegreeOne
            // 
            this.DegreeOne.Controls.Add(this.Degree1);
            this.DegreeOne.Location = new System.Drawing.Point(1, 1);
            this.DegreeOne.Name = "DegreeOne";
            this.DegreeOne.Size = new System.Drawing.Size(285, 187);
            this.DegreeOne.TabIndex = 1;
            this.DegreeOne.Paint += new System.Windows.Forms.PaintEventHandler(this.DegreeOne_Paint);
            // 
            // Degree1Txt
            // 
            this.Degree1Txt.FormattingEnabled = true;
            this.Degree1Txt.ItemHeight = 16;
            this.Degree1Txt.Items.AddRange(new object[] {
            " Classes needed:"});
            this.Degree1Txt.Location = new System.Drawing.Point(1, 186);
            this.Degree1Txt.Name = "Degree1Txt";
            this.Degree1Txt.Size = new System.Drawing.Size(282, 324);
            this.Degree1Txt.Sorted = true;
            this.Degree1Txt.TabIndex = 5;
            // 
            // Degree1
            // 
            this.Degree1.AutoSize = true;
            this.Degree1.BackColor = System.Drawing.Color.Transparent;
            this.Degree1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degree1.Location = new System.Drawing.Point(3, 13);
            this.Degree1.Name = "Degree1";
            this.Degree1.Size = new System.Drawing.Size(82, 22);
            this.Degree1.TabIndex = 1;
            this.Degree1.Text = "Degree 1";
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.Transparent;
            this.Results.ForeColor = System.Drawing.Color.Black;
            this.Results.Location = new System.Drawing.Point(716, 453);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(149, 57);
            this.Results.TabIndex = 2;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = false;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // DisplayDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 510);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Degree2Txt);
            this.Controls.Add(this.Degree3Txt);
            this.Controls.Add(this.Degree1Txt);
            this.Controls.Add(this.DegreeThree);
            this.Controls.Add(this.DegreeTwo);
            this.Controls.Add(this.DegreeOne);
            this.Name = "DisplayDegree";
            this.Text = "DisplayDegree";
            this.Load += new System.EventHandler(this.DisplayDegree_Load);
            this.DegreeThree.ResumeLayout(false);
            this.DegreeThree.PerformLayout();
            this.DegreeTwo.ResumeLayout(false);
            this.DegreeTwo.PerformLayout();
            this.DegreeOne.ResumeLayout(false);
            this.DegreeOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DegreeThree;
        private System.Windows.Forms.Panel DegreeTwo;
        private System.Windows.Forms.Panel DegreeOne;
        private System.Windows.Forms.Label Degree3;
        private System.Windows.Forms.Label Degree2;
        private System.Windows.Forms.Label Degree1;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.ListBox Degree3Txt;
        private System.Windows.Forms.ListBox Degree2Txt;
        private System.Windows.Forms.ListBox Degree1Txt;
    }
}