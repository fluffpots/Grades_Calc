
namespace BTEC_Grades_Calc_V1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPasses = new System.Windows.Forms.Label();
            this.lblMerits = new System.Windows.Forms.Label();
            this.lblDistinctions = new System.Windows.Forms.Label();
            this.comBoxPasses = new System.Windows.Forms.ComboBox();
            this.comBoxMerits = new System.Windows.Forms.ComboBox();
            this.comBoxDistinctions = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalUnits = new System.Windows.Forms.Label();
            this.lblCourseSelect = new System.Windows.Forms.Label();
            this.comBoxCourse = new System.Windows.Forms.ComboBox();
            this.panelInstruct = new System.Windows.Forms.Panel();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelInstruct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(300, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BTEC Grades Calculator";
            // 
            // lblPasses
            // 
            this.lblPasses.AutoSize = true;
            this.lblPasses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasses.Location = new System.Drawing.Point(12, 186);
            this.lblPasses.Name = "lblPasses";
            this.lblPasses.Size = new System.Drawing.Size(67, 25);
            this.lblPasses.TabIndex = 1;
            this.lblPasses.Text = "Passes";
            // 
            // lblMerits
            // 
            this.lblMerits.AutoSize = true;
            this.lblMerits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMerits.Location = new System.Drawing.Point(12, 247);
            this.lblMerits.Name = "lblMerits";
            this.lblMerits.Size = new System.Drawing.Size(66, 25);
            this.lblMerits.TabIndex = 2;
            this.lblMerits.Text = "Merits";
            // 
            // lblDistinctions
            // 
            this.lblDistinctions.AutoSize = true;
            this.lblDistinctions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDistinctions.Location = new System.Drawing.Point(12, 311);
            this.lblDistinctions.Name = "lblDistinctions";
            this.lblDistinctions.Size = new System.Drawing.Size(112, 25);
            this.lblDistinctions.TabIndex = 3;
            this.lblDistinctions.Text = "Distinctions";
            // 
            // comBoxPasses
            // 
            this.comBoxPasses.AllowDrop = true;
            this.comBoxPasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPasses.FormattingEnabled = true;
            this.comBoxPasses.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comBoxPasses.Location = new System.Drawing.Point(147, 183);
            this.comBoxPasses.Name = "comBoxPasses";
            this.comBoxPasses.Size = new System.Drawing.Size(76, 33);
            this.comBoxPasses.TabIndex = 4;
            this.comBoxPasses.SelectedIndexChanged += new System.EventHandler(this.comBoxPasses_SelectedIndexChanged);
            // 
            // comBoxMerits
            // 
            this.comBoxMerits.AllowDrop = true;
            this.comBoxMerits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMerits.FormattingEnabled = true;
            this.comBoxMerits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comBoxMerits.Location = new System.Drawing.Point(147, 244);
            this.comBoxMerits.Name = "comBoxMerits";
            this.comBoxMerits.Size = new System.Drawing.Size(76, 33);
            this.comBoxMerits.TabIndex = 5;
            this.comBoxMerits.SelectedIndexChanged += new System.EventHandler(this.comBoxMerits_SelectedIndexChanged);
            // 
            // comBoxDistinctions
            // 
            this.comBoxDistinctions.AllowDrop = true;
            this.comBoxDistinctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDistinctions.FormattingEnabled = true;
            this.comBoxDistinctions.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comBoxDistinctions.Location = new System.Drawing.Point(147, 308);
            this.comBoxDistinctions.Name = "comBoxDistinctions";
            this.comBoxDistinctions.Size = new System.Drawing.Size(76, 33);
            this.comBoxDistinctions.TabIndex = 6;
            this.comBoxDistinctions.SelectedIndexChanged += new System.EventHandler(this.comBoxDistinctions_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(28, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(111, 26);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "RESULT: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Maroon;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(12, 401);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(524, 122);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalUnits
            // 
            this.lblTotalUnits.AutoSize = true;
            this.lblTotalUnits.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUnits.Location = new System.Drawing.Point(26, 38);
            this.lblTotalUnits.Name = "lblTotalUnits";
            this.lblTotalUnits.Size = new System.Drawing.Size(134, 26);
            this.lblTotalUnits.TabIndex = 9;
            this.lblTotalUnits.Text = "Total Units: ";
            // 
            // lblCourseSelect
            // 
            this.lblCourseSelect.AutoSize = true;
            this.lblCourseSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseSelect.Location = new System.Drawing.Point(12, 118);
            this.lblCourseSelect.Name = "lblCourseSelect";
            this.lblCourseSelect.Size = new System.Drawing.Size(129, 25);
            this.lblCourseSelect.TabIndex = 10;
            this.lblCourseSelect.Text = "Select course:";
            // 
            // comBoxCourse
            // 
            this.comBoxCourse.AllowDrop = true;
            this.comBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCourse.FormattingEnabled = true;
            this.comBoxCourse.Items.AddRange(new object[] {
            "--Select course--",
            "12 unit - General Diploma in IT",
            "18 unit - Extended Diploma in IT"});
            this.comBoxCourse.Location = new System.Drawing.Point(147, 115);
            this.comBoxCourse.Name = "comBoxCourse";
            this.comBoxCourse.Size = new System.Drawing.Size(389, 33);
            this.comBoxCourse.TabIndex = 11;
            // 
            // panelInstruct
            // 
            this.panelInstruct.BackColor = System.Drawing.Color.Khaki;
            this.panelInstruct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInstruct.CausesValidation = false;
            this.panelInstruct.Controls.Add(this.lblInstruct);
            this.panelInstruct.Location = new System.Drawing.Point(691, 89);
            this.panelInstruct.Name = "panelInstruct";
            this.panelInstruct.Size = new System.Drawing.Size(380, 434);
            this.panelInstruct.TabIndex = 12;
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruct.Location = new System.Drawing.Point(-2, 37);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(358, 360);
            this.lblInstruct.TabIndex = 0;
            this.lblInstruct.Text = resources.GetString("lblInstruct.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTotalUnits);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(272, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 173);
            this.panel1.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 555);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1118, 629);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInstruct);
            this.Controls.Add(this.comBoxCourse);
            this.Controls.Add(this.lblCourseSelect);
            this.Controls.Add(this.lblPasses);
            this.Controls.Add(this.comBoxPasses);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDistinctions);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comBoxDistinctions);
            this.Controls.Add(this.lblMerits);
            this.Controls.Add(this.comBoxMerits);
            this.Name = "Form1";
            this.Text = "BTEC Grades Calculator V1.0";
            this.panelInstruct.ResumeLayout(false);
            this.panelInstruct.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPasses;
        private System.Windows.Forms.Label lblMerits;
        private System.Windows.Forms.Label lblDistinctions;
        private System.Windows.Forms.ComboBox comBoxPasses;
        private System.Windows.Forms.ComboBox comBoxMerits;
        private System.Windows.Forms.ComboBox comBoxDistinctions;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalUnits;
        private System.Windows.Forms.Label lblCourseSelect;
        private System.Windows.Forms.ComboBox comBoxCourse;
        private System.Windows.Forms.Panel panelInstruct;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
    }
}

