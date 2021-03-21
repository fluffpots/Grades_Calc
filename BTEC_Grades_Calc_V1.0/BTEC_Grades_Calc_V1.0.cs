using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTEC_Grades_Calc_V1._0
{
    public partial class Form1 : Form
    {
        //initialise global pass, merti and dist values to zero
        int passes = 0;
        int merits = 0;
        int dist = 0;

        //initialise combo box values to zero
        int cmbPassAll = 0;
        int cmbMeritAll = 0;
        int cmbDistAll = 0;

        public Form1()
        {
            InitializeComponent();
            comBoxCourse.SelectedIndex = 0;
            comBoxPasses.SelectedIndex = 0;
            comBoxMerits.SelectedIndex = 0;
            comBoxDistinctions.SelectedIndex = 0;
        }

        public string GeneralDipCalculation(int cmbPass, int cmbMerit, int cmbDist)
        {
            string finalResult;
            passes = cmbPass;
            merits = cmbMerit;
            dist = cmbDist;

            //add together all grades
            int calc = (passes * 70) + (merits * 80) + (dist * 90);

            //check ranges to get final grade for General Diploma
            if(calc >= 840 && calc <=879)
            {
                finalResult = "PP";
                return finalResult;
            }
            else if (calc >= 880 && calc <= 919)
            {
                finalResult = "MP";
                return finalResult;
            } 
            else if(calc >= 920 && calc <= 959)
            {
                finalResult = "MM";
                return finalResult;
            }
            else if (calc >= 960 && calc <= 999)
            {
                finalResult = "DM";
                return finalResult;
            }
            else if (calc >= 1000 && calc <= 1029)
            {
                finalResult = "DD";
                return finalResult;
            }
            else if (calc >= 1030 && calc <= 1059)
            {
                finalResult = "D*D";
                return finalResult;
            }
            else if (calc >= 1060)
            {
                finalResult = "D*D*";
                return finalResult;
            }
            else
            {
                finalResult = "FAIL";
                return finalResult;
            }
        }

        public string ExtendedDipCalculation(int cmbPass, int cmbMerit, int cmbDist)
        {
            string finalResult;
            passes = cmbPass;
            merits = cmbMerit;
            dist = cmbDist;

            //add together all grades
            int calc = (passes * 70) + (merits * 80) + (dist * 90);

            //check ranges to get final grade for Extended Diploma
            if (calc >= 1260 && calc <= 1299)
            {
                finalResult = "PPP";
                return finalResult;
            }
            else if (calc >= 1300 && calc <= 1339)
            {
                finalResult = "MPP";
                return finalResult;
            }
            else if (calc >= 1340 && calc <= 1379)
            {
                finalResult = "MMP";
                return finalResult;
            }
            else if (calc >= 1380 && calc <= 1419)
            {
                finalResult = "MMM";
                return finalResult;
            }
            else if (calc >= 1420 && calc <= 1459)
            {
                finalResult = "DMM";
                return finalResult;
            }
            else if (calc >= 1460 && calc <= 1499)
            {
                finalResult = "DDM";
                return finalResult;
            }
            else if (calc >= 1500 && calc <= 1529)
            {
                finalResult = "DDD";
                return finalResult;
            }
            else if (calc >= 1530 && calc <= 1559)
            {
                finalResult = "D*DD";
                return finalResult;
            }
            else if (calc >= 1560 && calc <= 1589)
            {
                finalResult = "D*D*D";
                return finalResult;
            }
            else if (calc >= 1590)
            {
                finalResult = "D*D*D*";
                return finalResult;
            }
            else
            {
                finalResult = "FAIL";
                return finalResult;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //check qual, run correct method

            if (comBoxCourse.Text == "12 unit - General Diploma in IT")
            {
                //check if values are equal to 12 units
                if ((cmbPassAll + cmbMeritAll + cmbDistAll) == 12)
                {
                    //if units are equal to 12, display grade
                    lblResult.Text = "RESULT: " + GeneralDipCalculation(cmbPassAll, cmbMeritAll, cmbDistAll);
                }
                else
                {
                    //display message box if not equal to 12
                    MessageBox.Show("Grades for Level 3 General Diploma must equal 12.");
                }
            }
            else if (comBoxCourse.Text == "18 unit - Extended Diploma in IT")
            {
                //check if values are equal to 18 units
                if ((cmbPassAll + cmbMeritAll + cmbDistAll) == 18)
                {
                    //if units are equal to 18, display grade
                    lblResult.Text = "RESULT: " + ExtendedDipCalculation(cmbPassAll, cmbMeritAll, cmbDistAll);
                }
                else
                {
                    //display message box if not equal to 12
                    MessageBox.Show("Grades for Level 3 Extended Diploma must equal 18.");
                }
            }
            else
            {
                MessageBox.Show("Course cannot be empty");
            }

        }

        private void comBoxPasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            //update total units number after passes selected
            cmbPassAll = int.Parse(comBoxPasses.Text);
            lblTotalUnits.Text = "Total Units: " + (cmbPassAll + cmbMeritAll + cmbDistAll).ToString();
        }

        private void comBoxMerits_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update total units number after merits selected
            cmbMeritAll = int.Parse(comBoxMerits.Text);
            lblTotalUnits.Text = "Total Units: " + (cmbPassAll + cmbMeritAll + cmbDistAll).ToString();
        }

        private void comBoxDistinctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update total units number after distinctions selected
            cmbDistAll = int.Parse(comBoxDistinctions.Text);
            lblTotalUnits.Text = "Total Units: " + (cmbPassAll + cmbMeritAll + cmbDistAll).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comBoxCourse.SelectedIndex = 0;
            comBoxPasses.SelectedIndex = 0;
            comBoxMerits.SelectedIndex = 0;
            comBoxDistinctions.SelectedIndex = 0;
            lblResult.Text = "RESULT ";
            lblTotalUnits.Text = "Total Units: 0";
        }
    }
}