namespace CalculatorPro
{
    public partial class Form1 : Form
    {
        int FirstNumber;
        string Operation;
        bool binary;
        bool hexa;
        bool octal;
        bool deci = true;
        public Form1()
        {
            InitializeComponent();
            checkButton();
            
        }
        public void checkButton()
        {
            if (deci)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                button_C.Enabled = false;
                buttonD.Enabled = false;
                buttonE.Enabled = false;
                buttonF.Enabled = false;
            }
          else  if (binary)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                button_C.Enabled = false;
                buttonD.Enabled = false;
                buttonE.Enabled = false;
                buttonF.Enabled = false;
            }
            else if (octal)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = false;
                button9.Enabled = false;
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                button_C.Enabled = false;
                buttonD.Enabled = false;
                buttonE.Enabled = false;
                buttonF.Enabled = false;
            }
            else if (hexa)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                buttonA.Enabled = true;
                buttonB.Enabled = true;
                button_C.Enabled = true;
                buttonD.Enabled = true;
                buttonE.Enabled = true;
                buttonF.Enabled = true;
            }
        }

        public void display(double? res=null)
        {
            if (deci && res==null)
            {
                int val = Convert.ToInt32(textBox1.Text);
                textBoxBinary.Text = Convert.ToString(val, 2);
                textBoxDecimal.Text = Convert.ToString(val, 10);
                textBoxHex.Text = (Convert.ToString(val, 16)).ToUpper();
                textBoxOctal.Text = Convert.ToString(val, 8);
            }
            else if (binary && res== null)
            {
                int val = Convert.ToInt32(textBox1.Text, 2);
                textBoxBinary.Text = textBox1.Text;
                textBoxDecimal.Text = Convert.ToString(val, 10);
                textBoxHex.Text = (Convert.ToString(val, 16)).ToUpper();
                textBoxOctal.Text = Convert.ToString(val, 8);
            }
            else if (hexa && res == null)
            {
                int val = Convert.ToInt32(textBox1.Text, 16);
                textBoxHex.Text=textBox1.Text;
                textBoxBinary.Text=Convert.ToString(val, 2);
                textBoxDecimal.Text=Convert.ToString(val, 10);
                textBoxOctal.Text=Convert.ToString(val, 8);
            }
            else if(octal && res==null)
            {
                int val = Convert.ToInt32(textBox1.Text, 8);
                textBoxOctal.Text = textBox1.Text;
                textBoxBinary.Text = Convert.ToString(val, 2);
                textBoxDecimal.Text= Convert.ToString(val, 10);
                textBoxHex.Text=(Convert.ToString(val, 16)).ToUpper();
            }
            else
            {
                int val = Convert.ToInt32(res);
                textBoxOctal.Text = Convert.ToString(val, 8);
                textBoxHex.Text = (Convert.ToString(val, 16)).ToUpper();
                textBoxBinary.Text = Convert.ToString(val, 2);
                if (deci)
                {
                    textBox1.Text= textBoxDecimal.Text;
                }
                else if (octal) { textBox1.Text = textBoxOctal.Text; }
                else if (binary) { textBox1.Text = textBoxBinary.Text; }
                else { textBox1.Text=textBoxHex.Text; }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
                display();
            
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                display();
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
                display();
          
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                display();
         
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                display();
        
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                display();
                
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
                    display();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                display();
    
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
                display();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                display();
              
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
                display();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                display();
               
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
                display();
           
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                display();
             
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
                display();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                display();
                
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
                display();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                    display();
              
            }
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            display();
           
        }

    

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBoxBinary.Text = "0";
            textBoxDecimal.Text = "0";
            textBoxHex.Text = "0";
            textBoxOctal.Text = "0";

        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            int SecondNumber;
            int Result;

            SecondNumber = Convert.ToInt32(textBoxDecimal.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);

            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);

            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);

            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBoxDecimal.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    display(Result);

                }
            }
            if (Operation == "AND")
            {
                Result = (FirstNumber & SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);

            }
            if (Operation == "OR")
            {
                Result = (FirstNumber | SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);

            }
            if (Operation == "NAND")
            {
                Result = ~(FirstNumber & SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);
            }
            if (Operation == "NOR")
            {
                Result = ~(FirstNumber | SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);
            }
            if (Operation == "XOR")
            {
                Result = (FirstNumber ^ SecondNumber);
                textBoxDecimal.Text = Convert.ToString(Result);
                FirstNumber = Result;
                display(Result);
            }
            }
            
        

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "A";
            }
            else
            {
                textBox1.Text = textBox1.Text + "A";
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "B";
            }
            else
            {
                textBox1.Text = textBox1.Text + "B";
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "C";
            }
            else
            {
                textBox1.Text = textBox1.Text + "C";
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "D";
            }
            else
            {
                textBox1.Text = textBox1.Text + "D";
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "E";
            }
            else
            {
                textBox1.Text = textBox1.Text + "E";
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "F";
            }
            else
            {
                textBox1.Text = textBox1.Text + "F";
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            deci=true;
            binary = false;
            hexa=false;
            octal=false;
            checkButton();
            textBox1.Text = textBoxDecimal.Text;
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            binary = true;     
            deci=false;
            hexa= false;
            octal= false;
            checkButton();
            textBox1.Text = textBoxBinary.Text;
        }

        private void buttonHexa_Click(object sender, EventArgs e)
        {
            hexa= true;
            octal= false;
            binary= false;
            deci= false;
            checkButton();
            textBox1.Text = textBoxHex.Text;
        }

        private void buttonOctal_Click(object sender, EventArgs e)
        {
            octal= true;
            binary = false;
            deci= false;
            hexa= false;
            checkButton();
            textBox1.Text = textBoxOctal.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkButton();
            display();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            MemTextBox.Text += textBox1.Text;
            MemTextBox.Text += "\n";
        }

        private void buttonMemClear_Click(object sender, EventArgs e)
        {
            MemTextBox.Text = null;
        }

        private void buttonAnd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "AND";
        }

        private void buttonOR_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "OR";
        }

        private void buttonNOT_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            FirstNumber = ~FirstNumber;
            textBox1.Text = Convert.ToString(FirstNumber);
            display();
        }

        private void buttonNAND_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "NAND";
        }

        private void buttonNOR_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "NOR";
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBoxDecimal.Text);
            textBox1.Text = "0";
            Operation = "XOR";
        }
    }
}