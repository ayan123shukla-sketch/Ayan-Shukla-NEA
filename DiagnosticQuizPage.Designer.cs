namespace Ayan_Shukla_NEA
{
    partial class DiagnosticQuizPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioAthleticism = new System.Windows.Forms.RadioButton();
            this.radioBodyBuilding = new System.Windows.Forms.RadioButton();
            this.radioGeneralHealth = new System.Windows.Forms.RadioButton();
            this.radio1to2 = new System.Windows.Forms.RadioButton();
            this.radio2to3 = new System.Windows.Forms.RadioButton();
            this.radio3to4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your goal?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "How often do you excercie heavily?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioAthleticism
            // 
            this.radioAthleticism.AutoSize = true;
            this.radioAthleticism.Location = new System.Drawing.Point(41, 20);
            this.radioAthleticism.Name = "radioAthleticism";
            this.radioAthleticism.Size = new System.Drawing.Size(117, 17);
            this.radioAthleticism.TabIndex = 10;
            this.radioAthleticism.TabStop = true;
            this.radioAthleticism.Text = "Athleticism or Agility";
            this.radioAthleticism.UseVisualStyleBackColor = true;
            // 
            // radioBodyBuilding
            // 
            this.radioBodyBuilding.AutoSize = true;
            this.radioBodyBuilding.Location = new System.Drawing.Point(41, 43);
            this.radioBodyBuilding.Name = "radioBodyBuilding";
            this.radioBodyBuilding.Size = new System.Drawing.Size(86, 17);
            this.radioBodyBuilding.TabIndex = 11;
            this.radioBodyBuilding.TabStop = true;
            this.radioBodyBuilding.Text = "BodyBuilding";
            this.radioBodyBuilding.UseVisualStyleBackColor = true;
            this.radioBodyBuilding.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioGeneralHealth
            // 
            this.radioGeneralHealth.AutoSize = true;
            this.radioGeneralHealth.Location = new System.Drawing.Point(41, 66);
            this.radioGeneralHealth.Name = "radioGeneralHealth";
            this.radioGeneralHealth.Size = new System.Drawing.Size(96, 17);
            this.radioGeneralHealth.TabIndex = 12;
            this.radioGeneralHealth.TabStop = true;
            this.radioGeneralHealth.Text = "General Health";
            this.radioGeneralHealth.UseVisualStyleBackColor = true;
            // 
            // radio1to2
            // 
            this.radio1to2.AutoSize = true;
            this.radio1to2.Location = new System.Drawing.Point(38, 20);
            this.radio1to2.Name = "radio1to2";
            this.radio1to2.Size = new System.Drawing.Size(127, 17);
            this.radio1to2.TabIndex = 13;
            this.radio1to2.TabStop = true;
            this.radio1to2.Text = "1 - 2 Times per Week";
            this.radio1to2.UseVisualStyleBackColor = true;
            // 
            // radio2to3
            // 
            this.radio2to3.AutoSize = true;
            this.radio2to3.Location = new System.Drawing.Point(38, 42);
            this.radio2to3.Name = "radio2to3";
            this.radio2to3.Size = new System.Drawing.Size(127, 17);
            this.radio2to3.TabIndex = 14;
            this.radio2to3.TabStop = true;
            this.radio2to3.Text = "2 - 3 Times per Week";
            this.radio2to3.UseVisualStyleBackColor = true;
            // 
            // radio3to4
            // 
            this.radio3to4.AutoSize = true;
            this.radio3to4.Location = new System.Drawing.Point(38, 65);
            this.radio3to4.Name = "radio3to4";
            this.radio3to4.Size = new System.Drawing.Size(127, 17);
            this.radio3to4.TabIndex = 15;
            this.radio3to4.TabStop = true;
            this.radio3to4.Text = "3 - 4 Times per Week";
            this.radio3to4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioGeneralHealth);
            this.panel1.Controls.Add(this.radioAthleticism);
            this.panel1.Controls.Add(this.radioBodyBuilding);
            this.panel1.Location = new System.Drawing.Point(15, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio3to4);
            this.panel2.Controls.Add(this.radio1to2);
            this.panel2.Controls.Add(this.radio2to3);
            this.panel2.Location = new System.Drawing.Point(15, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // DiagnosticQuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiagnosticQuizPage";
            this.Text = "DiagnosticQuizPage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioAthleticism;
        private System.Windows.Forms.RadioButton radioBodyBuilding;
        private System.Windows.Forms.RadioButton radioGeneralHealth;
        private System.Windows.Forms.RadioButton radio1to2;
        private System.Windows.Forms.RadioButton radio2to3;
        private System.Windows.Forms.RadioButton radio3to4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}