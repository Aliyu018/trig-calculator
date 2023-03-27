namespace calculator
{
    public partial class Form1 : Form
    {
        double result1;
        double result2;
        double result3;
        double result4;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;    
            result3 = 0;
            result4 = 0;
            if(textBox1.Text !="" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Sin(box1);
                label4.Text = "Result =" + result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Sin(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Sin(box2);
                result3 = result1 * result2;
                label4.Text = "Result =" + result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Sin(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Sin(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Sin(box2);
                result4 = result1 * result2 * result3;
                label4.Text = "Result =" + result4.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            /* double x;
             double y;
             y = 10.0;
             x= Math.Sin(y);
             label5.Text = x.ToString();*/
            textBox1.Enabled = false;
            textBox2.Enabled = false;   
            textBox3.Enabled = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            result3 = 0;
            result4 = 0;
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Cos(box1);
                label4.Text = "Result =" + result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Cos(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Cos(box2);
                result3 = result1 * result2;
                label4.Text = "Result =" + result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Cos(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Cos(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Cos(box2);
                result4 = result1 * result2 * result3;
                label4.Text = "Result =" + result4.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            result3 = 0;
            result4 = 0;
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Tan(box1);
                label4.Text = "Result =" + result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Tan(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Tan(box2);
                result3 = result1 * result2;
                label4.Text = "Result =" + result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Tan(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Tan(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Tan(box2);
                result4 = result1 * result2 * result3;
                label4.Text = "Result =" + result4.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            result3 = 0;
            result4 = 0;
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Exp(box1);
                label4.Text = "Result =" + result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Exp(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Exp(box2);
                result3 = result1 * result2;
                label4.Text = "Result =" + result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Exp(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Exp(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Exp(box2);
                result4 = result1 * result2 * result3;
                label4.Text = "Result =" + result4.ToString();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else if (radioButton2.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                
                textBox3.Enabled = false;
            }
            else if (radioButton3.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }
    }
}