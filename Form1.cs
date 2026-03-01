// Course: PROG 1103 – Spring 2026
// Project: HW3
// Team Name: Eddie the Eagle
// Names: Brandon Shook, Tyler

using System;
using System.Windows.Forms;

namespace HW3Calculator
{
    public partial class Form1 : Form
    {
        // Snapshot of the calculator's current state
        private CalculatorState state = new CalculatorState();

        public Form1()
        {
            InitializeComponent();
            lblDisplay.Text = "0";
        }

        /// <summary>
        /// Handles 0-9 and the decimal point. Prevents double decimals.
        /// </summary>
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string input = button.Text;

            if (input == "." && state.CurrentInput.Contains("."))
                return;

            state = state with { CurrentInput = state.CurrentInput + input };
            lblDisplay.Text = state.CurrentInput;
        }

        /// <summary>
        /// Sets the math operator (+, -, X, /).
        /// </summary>
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(state.CurrentInput)) return;

            if (state.OperationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            state = state with
            {
                Operation = button.Text,
                Result = double.Parse(state.CurrentInput),
                CurrentInput = "",
                OperationPending = true
            };
        }

        /// <summary>
        /// Runs the actual math calculation.
        /// </summary>
        private void Evaluate()
        {
            if (!state.OperationPending || string.IsNullOrEmpty(state.CurrentInput)) return;

            try
            {
                double secondNumber = double.Parse(state.CurrentInput);
                double finalResult = state.Result;

                switch (state.Operation)
                {
                    case "+": finalResult += secondNumber; break;
                    case "-": finalResult -= secondNumber; break;
                    case "X": finalResult *= secondNumber; break;
                    case "/":
                        if (secondNumber == 0) throw new DivideByZeroException();
                        finalResult /= secondNumber;
                        break;
                }

                state = state with { CurrentInput = finalResult.ToString(), OperationPending = false };
                lblDisplay.Text = state.CurrentInput;
            }
            catch (DivideByZeroException)
            {
                lblDisplay.Text = "Error";
                state = new CalculatorState(); // Reset on error
            }
        }

        private void btnEqual_Click(object sender, EventArgs e) => Evaluate();

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Resets math but keeps the stored memory safe
            state = state with { CurrentInput = "", Result = 0, Operation = "", OperationPending = false };
            lblDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (state.CurrentInput.Length > 0)
            {
                state = state with { CurrentInput = state.CurrentInput.Substring(0, state.CurrentInput.Length - 1) };
                lblDisplay.Text = string.IsNullOrEmpty(state.CurrentInput) ? "0" : state.CurrentInput;
            }
        }

        // --- Memory Buttons ---

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblDisplay.Text, out double val))
            {
                state = state with { Memory = val };
                lblMemoryIndicator.Text = "M";
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            state = state with { Memory = 0 };
            lblMemoryIndicator.Text = "";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            state = state with { CurrentInput = state.Memory.ToString() };
            lblDisplay.Text = state.CurrentInput;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblDisplay.Text, out double val))
            {
                state = state with { Memory = state.Memory + val };
                lblMemoryIndicator.Text = "M";
            }
        }

        // --- Scientific & Sign Buttons ---

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblDisplay.Text, out double val) && val != 0)
            {
                double res = 1 / val;
                state = state with { CurrentInput = res.ToString() };
                lblDisplay.Text = state.CurrentInput;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblDisplay.Text, out double val) && val >= 0)
            {
                double res = Math.Sqrt(val);
                state = state with { CurrentInput = res.ToString() };
                lblDisplay.Text = state.CurrentInput;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblDisplay.Text, out double val))
            {
                double res = val * -1;
                state = state with { CurrentInput = res.ToString() };
                lblDisplay.Text = state.CurrentInput;
            }
        }
    }
}