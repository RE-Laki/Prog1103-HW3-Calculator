using System.ComponentModel.Design.Serialization;

namespace HW3Calculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;
        double root;
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();

            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(currentInput))
                return;

            if (currentInput.StartsWith("-"))
                currentInput = currentInput.Substring(1); //this removes -

            else
                currentInput = "-" + currentInput;

            lblDisplay.Text = currentInput;



        }


        private void btnOne_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;

                    case "-":
                        result -= secondNumber;
                        break;

                    case "X":
                        result *= secondNumber;
                        break;

                    //failed making of Sqrt button

                    // case "Sqrt":

                    //   root = double.Parse(currentInput);
                    // result = Math.Sqrt(root);
                    //break;

                    //case ""

                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;

                        }
                        else
                        {
                            lblDisplay.Text = "Error";
                            return;

                        }
                        break;
                }
                lblDisplay.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();

            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();

            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();

            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            lblDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Evaluate();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                //removing the last character displayed
                currentInput = currentInput.Substring(0, currentInput.Length - 1);

                //if theres nothing left show blank
                if (string.IsNullOrEmpty(currentInput))
                {
                    lblDisplay.Text = "";

                }
                else
                {
                    lblDisplay.Text = currentInput;
                }
            }



        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentInput))
                return;

            double number = double.Parse(currentInput);

            if (number < 0)

            {
                lblDisplay.Text = "Error";
                currentInput = "";
                operationPending = false;
                return;


            }
            result = Math.Sqrt(number);
            lblDisplay.Text = result.ToString();
            currentInput = result.ToString();
            operationPending = false;



        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            lblDisplay.Text = currentInput;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentInput))
                return;

            double number = double.Parse(currentInput);

            if (number == 0)
            {
                lblDisplay.Text = "Error";
                currentInput = "";
                operationPending = false;
                return;
            }
            result = 1 / number;
            lblDisplay.Text = result.ToString();
            currentInput = result.ToString();
            operationPending = false;

        }
    }
}
