using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculator1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            WeightTb.Text = "";
            HeightTb.Text = "";
            Height2tb.Text = "";
            ResultLbl.Text = "";
            StatusLbl.Text = "";
        }

        private void CaculateBtn_Click(object sender, EventArgs e)
        {
            //calculate
            double Weight = Convert.ToDouble(WeightTb.Text);
            double Height = Convert.ToDouble(HeightTb.Text);
            Height = Height * 0.0254;
            Height2tb.Text = Height.ToString();
            double BMI = Weight / (Height * Height);
            ResultLbl.Text = BMI.ToString();
            if (BMI < 18.5)
            {
                StatusLbl.Text = "YOU ARE UNDERWEIGHT";
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                StatusLbl.Text = "YOUR ARE NORMAL WEIGHT";
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                StatusLbl.Text = "YOUR ARE OVERWEIGHT";
            }
            else if (BMI > 30)
            {
                StatusLbl.Text = "YOU ARE OBESE";
            }
        }

        private void EXITBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
