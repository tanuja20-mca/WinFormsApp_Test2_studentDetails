
namespace WinFormsApp_Test2_studentDetails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.txt1Rank = new System.Windows.Forms.TextBox();
            this.txt2Rank = new System.Windows.Forms.TextBox();
            this.txt3Rank = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(320, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(320, 112);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(56, 20);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "English";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(320, 165);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(94, 20);
            this.lblMaths.TabIndex = 2;
            this.lblMaths.Text = "Mathematics";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(320, 219);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(59, 20);
            this.lblScience.TabIndex = 3;
            this.lblScience.Text = "Science";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(528, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(528, 109);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(125, 27);
            this.txtEnglish.TabIndex = 5;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(528, 158);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(125, 27);
            this.txtMaths.TabIndex = 6;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(528, 212);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(125, 27);
            this.txtScience.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(429, 293);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(54, 365);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 29);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "1st Rank";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(54, 428);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(94, 29);
            this.btnSecond.TabIndex = 10;
            this.btnSecond.Text = "2nd Rank";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.Location = new System.Drawing.Point(54, 489);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(94, 29);
            this.btnThird.TabIndex = 11;
            this.btnThird.Text = "3rd Rank";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // txt1Rank
            // 
            this.txt1Rank.Location = new System.Drawing.Point(197, 365);
            this.txt1Rank.Name = "txt1Rank";
            this.txt1Rank.Size = new System.Drawing.Size(125, 27);
            this.txt1Rank.TabIndex = 12;
            this.txt1Rank.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2Rank
            // 
            this.txt2Rank.Location = new System.Drawing.Point(197, 430);
            this.txt2Rank.Name = "txt2Rank";
            this.txt2Rank.Size = new System.Drawing.Size(125, 27);
            this.txt2Rank.TabIndex = 13;
            // 
            // txt3Rank
            // 
            this.txt3Rank.Location = new System.Drawing.Point(197, 491);
            this.txt3Rank.Name = "txt3Rank";
            this.txt3Rank.Size = new System.Drawing.Size(125, 27);
            this.txt3Rank.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 667);
            this.Controls.Add(this.txt3Rank);
            this.Controls.Add(this.txt2Rank);
            this.Controls.Add(this.txt1Rank);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtScience);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.lblMaths);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Student Marks Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.TextBox txt1Rank;
        private System.Windows.Forms.TextBox txt2Rank;
        private System.Windows.Forms.TextBox txt3Rank;
    }
}

