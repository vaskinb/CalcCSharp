using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalcCSharp
{
    public partial class foMain : Form
    {
        Double result = 0;
        String opetation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKevin;
        char iOperation;
        public foMain()
        {
            InitializeComponent();
            this.Width = 326;
            txtDisplay.Width = 286;
            comboBox1.Location = new Point(90, 2);
        }

        private void standartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 326;
            txtDisplay.Width = 286;
            comboBox1.Location =  new Point(90, 2);
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 638;
            txtDisplay.Width = 598;
            comboBox1.Location = new Point(397, 2);
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                this.Width = 992;
            txtDisplay.Width = 598;
            comboBox1.Location = new Point(397, 2);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value)) txtDisplay.Text = "";
          
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;


        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Arithmatic_operator(object sender, EventArgs e)
        {
            try { 
            Button num = (Button)sender;
            opetation = num.Text;
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(result) + " " + opetation;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string buf = lblShowOp.Text;
            string buf2 = txtDisplay.Text;
            lblShowOp.Text = "";
            try
            {
                switch (opetation)
                {
                    case "+":
                        txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "/":
                        txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "Mod":
                        txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "Exp":
                        double i = Double.Parse(txtDisplay.Text);
                        double q;
                        q = (result);
                        txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                        break;
                }
                comboBox1.Items.Add(buf + buf2 + " = " + txtDisplay.Text);
                //enter_value = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
            finally
            {
              
                enter_value = true;

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = Convert.ToString(ilog);
           
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = Convert.ToString(sq);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             result = 0;
             opetation = "";
             enter_value = false;
            txtDisplay.Text = "";
            lblShowOp.Text = "";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try { 
            double qSinh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = Convert.ToString(qSinh);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                double qSin = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
                qSin = Math.Sin(qSin);
                txtDisplay.Text = Convert.ToString(qSin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtDisplay.Text = Convert.ToString(qCosh);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                double qCos = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
                qCos = Math.Cosh(qCos);
                txtDisplay.Text = Convert.ToString(qCos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Cosh(qTanh);
            txtDisplay.Text = Convert.ToString(qTanh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                double qTan = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
                qTan = Math.Cosh(qTan);
                txtDisplay.Text = Convert.ToString(qTan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 2);
            enter_value = true;
            comboBox1.Items.Add(a + "(10) =  " + txtDisplay.Text + "(2)");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 16);
            enter_value = true;
            comboBox1.Items.Add(a + "(10) =  " + txtDisplay.Text + "(16)");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 8);
            enter_value = true;
            comboBox1.Items.Add(a + "(10) =  " + txtDisplay.Text + "(8)");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);
            enter_value = true;
            comboBox1.Items.Add(a + "(10) =  " + txtDisplay.Text + "(10)");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Convert.ToString(a);
                enter_value = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Convert.ToString(a);
                enter_value = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                double buf = Convert.ToDouble(txtDisplay.Text);
                a = Convert.ToDouble(1.0 / buf);
                txtDisplay.Text = Convert.ToString(a);
                comboBox1.Items.Add("1 / " + buf + " = " + txtDisplay.Text);
                enter_value = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void rbCelTFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbCevin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtConvert.Text == "") MessageBox.Show("Введите значение");
            switch (iOperation)
            {
                case 'C':
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFahrenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    iKevin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((iKevin + 459.67) * 5/9).ToString());
                    break;
                default: MessageBox.Show("Выберите величины для перевода");
                    break;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Clear();
            rbCelTFah.Checked = false;
            rbFahToCel.Checked = false;
            rbCevin.Checked = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void очиститьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

          
            if (txtDisplay.Text[0] == '-')
            {
                string x = txtDisplay.Text;
                x = x.Substring(1);
                txtDisplay.Text = x;
            }
            else txtDisplay.Text = "-" + txtDisplay.Text;


        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDisplay.Text == "0") txtDisplay.Text = "";
          
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 44) return;
            else
                e.Handled = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                double ilog = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
                ilog = Math.Log(ilog);
                txtDisplay.Text = Convert.ToString(ilog);
                enter_value = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(txtDisplay.Text) / 100;
                txtDisplay.Text = Convert.ToString(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblShowOp.Text = "";
                txtDisplay.Text = "";
            }
        }
    }
}
