using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTN
{
    public partial class Form1 : Form
    {
        CalculatorRTN CalculateQ;
       
        public Form1()
        {
            InitializeComponent();

            CalculateQ = new CalculatorRTN
            {
                TypeOfBuild = typeBuild.SelectedIndex + 1,
                Temp_in = Convert.ToInt32(temp_inNumeric.Value),
                Temp_out = Convert.ToInt32(temp_outNumerik.Value),
                SpeedOfWind = Convert.ToDouble(speedOfWindBox.Text),
                Alfa = Convert.ToDouble(alfaBox.Text),
                Temp_midle = Convert.ToDouble(tempMiddleNumeric.Value),
                CountDays = Convert.ToInt32(counOfWorkDays.Text),
                Length = Convert.ToInt32(lengthBox.Text),
                High = Convert.ToInt32(highBox.Text),
                Wide = Convert.ToInt32(wideBox.Text),
                Value = Convert.ToInt32(volumebox.Text),
                Year = yearsCheck.Checked,
                QUdel = Convert.ToDouble(qBox.Text),
                FreeHigh = Convert.ToInt32(freeHighBox.Text),
                CostOne = Convert.ToDecimal(textBox1.Text)
            };

        }
        private void lengthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.Length = Convert.ToDouble(lengthBox.Text);
                CalculateQ.CalculateVolume(CalculateQ.Length, CalculateQ.High, CalculateQ.Wide);
                volumebox.Text = CalculateQ.Value.ToString();
                Calculate();
            }
            catch
            {
                lengthBox.Text = "0";
            }
        }

        private void wideBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.Wide = Convert.ToDouble(wideBox.Text);
                CalculateQ.CalculateVolume(CalculateQ.Length, CalculateQ.High, CalculateQ.Wide);
                volumebox.Text = CalculateQ.Value.ToString();
                qBox.Text = CalculateQ.GetqUdel(CalculateQ.TypeOfBuild).ToString();
                Calculate();
            }
            catch
            {
                wideBox.Text = "0";
            }
        }

        private void highBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.High = Convert.ToDouble(highBox.Text);
                CalculateQ.CalculateVolume(CalculateQ.Length, CalculateQ.High, CalculateQ.Wide);
                volumebox.Text = CalculateQ.Value.ToString();
                qBox.Text = CalculateQ.GetqUdel(CalculateQ.TypeOfBuild).ToString();
                Calculate();
            }
            catch
            {
                highBox.Text = "0";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculateQ.Temp_out = Convert.ToInt32(temp_outNumerik.Value);
            alfaBox.Text = CalculateQ.GetAlfa(CalculateQ.Temp_out).ToString();
            qBox.Text = CalculateQ.GetqUdel(CalculateQ.TypeOfBuild).ToString();
            Calculate();
        }

        private void typeBuild_TextChanged(object sender, EventArgs e)
        {
            CalculateQ.TypeOfBuild = typeBuild.SelectedIndex + 1;
            qBox.Text = CalculateQ.GetqUdel(CalculateQ.TypeOfBuild).ToString();
            Calculate();
        }

        private void yearsCheck_CheckedChanged(object sender, EventArgs e)
        {
            CalculateQ.Year = yearsCheck.Checked;
            qBox.Text = CalculateQ.GetqUdel(CalculateQ.TypeOfBuild).ToString();
            Calculate();
        }

        private void checkValue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkValue.Checked)
            {
                volumebox.Enabled = true;
                lengthBox.Enabled = false;
                wideBox.Enabled = false;
                highBox.Enabled = false;
            }
            else
            {
                volumebox.Enabled = false;
                lengthBox.Enabled = true;
                wideBox.Enabled = true;
                highBox.Enabled = true;
            }
        }

        private void volumebox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.Value = Convert.ToDouble(volumebox.Text);
                qBox.Text = CalculateQ.GetqUdel(CalculateQ.TypeOfBuild).ToString();
                CalculateQ.CalculateQHot();
                qhotBox.Text = CalculateQ.CalculateQHot().ToString();
                Calculate();
            }
            catch
            {
                volumebox.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                temp_outNumerik.Enabled = true;
            }
            else
            {
                temp_outNumerik.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                temp_inNumeric.Enabled = true;
            }
            else
            {
                temp_inNumeric.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                tempMiddleNumeric.Enabled = true;
            }
            else
            {
                tempMiddleNumeric.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                speedOfWindBox.Enabled = true;
            }
            else
            {
                speedOfWindBox.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.FreeHigh = Convert.ToDouble(freeHighBox.Text);
                Calculate();
            }
            catch
            {
                freeHighBox.Text = "0";
            }


        }

        private void speedOfWindBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.SpeedOfWind = Convert.ToDouble(speedOfWindBox.Text);
                Calculate();
            }
            catch
            {
                speedOfWindBox.Text = "0";
            }
        }

        private void qhotBox_TextChanged(object sender, EventArgs e)
        {
            CalculateQ.CalculateEnergy();
            Calculate();
        }

        private void tempMiddleNumeric_ValueChanged(object sender, EventArgs e)
        {
            CalculateQ.Temp_midle = Convert.ToDouble(tempMiddleNumeric.Value);
        }

        private void counOfWorkDays_TextChanged(object sender, EventArgs e)
        {
            CalculateQ.CountDays = Convert.ToInt32(counOfWorkDays.Text);
        }

        private void Calculate() {
            
            Q_Box.Text = CalculateQ.CalculateEnergy().ToString();
            kBox.Text = CalculateQ.CalculateCoofInfiltrationg().ToString();
            qhotBox.Text = CalculateQ.CalculateQHot().ToString();
            totalCostBox.Text = CalculateQ.CalculateTotalCost().ToString("c");

            

        }
        private void reset() {

            CalculateQ.Temp_in     = 20;
            CalculateQ.Temp_out    = -30;
            CalculateQ.SpeedOfWind = 4;
            CalculateQ.Alfa        = 1;
            CalculateQ.Temp_midle  = -5.2;
            CalculateQ.CountDays   =203;
            CalculateQ.Length      =0;
            CalculateQ.High        = 0;
            CalculateQ.Wide        = 0;
            CalculateQ.Value       = 0;
            CalculateQ.FreeHigh    = 0;
            
            

            temp_inNumeric.Value = CalculateQ.Temp_in;
            temp_outNumerik.Value = CalculateQ.Temp_out;
            speedOfWindBox.Text  =  CalculateQ.SpeedOfWind.ToString();
            alfaBox.Text =  CalculateQ.Alfa.ToString();
            tempMiddleNumeric.Value = (decimal)CalculateQ.Temp_midle;
            counOfWorkDays.Text =  CalculateQ.CountDays.ToString();
            wideBox.Text =  CalculateQ.Wide.ToString();
            volumebox.Text = CalculateQ.Value.ToString();
            yearsCheck.Checked = false;
            CalculateQ.Year = yearsCheck.Checked;
            freeHighBox.Text = CalculateQ.FreeHigh.ToString();
            lengthBox.Text = CalculateQ.Length.ToString();
            highBox.Text = CalculateQ.High.ToString();
  

            Calculate();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                CalculateQ.CostOne = Convert.ToDecimal(textBox1.Text);
                Calculate();
            }
            catch {
                if (textBox1.Text == null) 
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
            writeQ();
            CalculateQ.SummEnergy += CalculateQ.QHot;
            textBox2.Text = CalculateQ.SummEnergy.ToString();
            textBox3.Text = CalculateQ.CalculateEnergy(CalculateQ.SummEnergy).ToString();
            textBox4.Text = CalculateQ.CalculateTotalCost(CalculateQ.SummEnergy).ToString("c");
            reset();
        }

        private void writeQ() {

            if (q1box.Text == "") {

                q1box.Text = qhotBox.Text;
            }
            else if (q2Box .Text =="")
            {

                q2Box.Text = qhotBox.Text;
            }
            else if (q3Box.Text =="")
            {

                q3Box.Text = qhotBox.Text;
            }
            else if (q4Box.Text == "")
            {

                q4Box.Text = qhotBox.Text;
            }
            else if (q5Box.Text == "")
            {

                q5Box.Text = qhotBox.Text;
            }
            else if (q6Box.Text == "")
            {

                q6Box.Text = qhotBox.Text;
            }
            else if (q7Box.Text == "")
            {

                q7Box.Text = qhotBox.Text;
            }
            else if (q8Box.Text == "")
            {

                q8Box.Text = qhotBox.Text;
            }
            else if (q9Box.Text == "")
            {

                q9Box.Text = qhotBox.Text;
            }
            else if (q10Box.Text =="")
            {

                q10Box.Text = qhotBox.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateQ.Temp_in = 20;
            CalculateQ.Temp_out = -30;
            CalculateQ.SpeedOfWind = 4;
            CalculateQ.Alfa = 1;
            CalculateQ.Temp_midle = -5.2;
            CalculateQ.CountDays = 203;
            CalculateQ.Length = 0;
            CalculateQ.High = 0;
            CalculateQ.Wide = 0;
            CalculateQ.Value = 0;
            CalculateQ.FreeHigh = 0;
            CalculateQ.SummEnergy = 0;


            temp_inNumeric.Value = CalculateQ.Temp_in;
            temp_outNumerik.Value = CalculateQ.Temp_out;
            speedOfWindBox.Text = CalculateQ.SpeedOfWind.ToString();
            alfaBox.Text = CalculateQ.Alfa.ToString();
            tempMiddleNumeric.Value = (decimal)CalculateQ.Temp_midle;
            counOfWorkDays.Text = CalculateQ.CountDays.ToString();
            wideBox.Text = CalculateQ.Wide.ToString();
            volumebox.Text = CalculateQ.Value.ToString();
            yearsCheck.Checked = false;
            CalculateQ.Year = yearsCheck.Checked;
            freeHighBox.Text = CalculateQ.FreeHigh.ToString();
            lengthBox.Text = CalculateQ.Length.ToString();
            highBox.Text = CalculateQ.High.ToString();
            textBox2.Text = qhotBox.Text;
            textBox3.Text = Q_Box.Text;
            textBox4.Text = totalCostBox.Text;

            q1box.Text = "";
            q2Box.Text = "";
            q3Box.Text = "";
            q4Box.Text = "";
            q5Box.Text = "";
            q6Box.Text = "";
            q7Box.Text = "";
            q8Box.Text = "";
            q9Box.Text = "";
            q10Box.Text = "";

            Calculate();
        }
    }
}
