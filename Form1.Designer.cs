namespace HW3Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnReciprocal = new Button();
            btnSqrt = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnPosNeg = new Button();
            btnZero = new Button();
            btnDec = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            btnBack = new Button();
            btnClear = new Button();
            btnMS = new Button();
            btnMC = new Button();
            btnMR = new Button();
            btnMP = new Button();
            lblDisplay = new Label();
            lblMemoryIndicator = new Label();
            SuspendLayout();
            // 
            // btnReciprocal
            // 
            btnReciprocal.Font = new Font("Segoe UI", 14F);
            btnReciprocal.Location = new Point(108, 228);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(92, 40);
            btnReciprocal.TabIndex = 1;
            btnReciprocal.Text = "1/x";
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 14F);
            btnSqrt.Location = new Point(205, 228);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(87, 40);
            btnSqrt.TabIndex = 3;
            btnSqrt.Text = "Sqrt";
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 14F);
            btnSeven.Location = new Point(108, 271);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(68, 40);
            btnSeven.TabIndex = 4;
            btnSeven.Text = "7";
            btnSeven.Click += btnNumber_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 14F);
            btnEight.Location = new Point(181, 271);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(68, 40);
            btnEight.TabIndex = 5;
            btnEight.Text = "8";
            btnEight.Click += btnNumber_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 14F);
            btnNine.Location = new Point(254, 271);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(68, 40);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.Click += btnNumber_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 14F);
            btnFour.Location = new Point(108, 314);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(68, 40);
            btnFour.TabIndex = 7;
            btnFour.Text = "4";
            btnFour.Click += btnNumber_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 14F);
            btnFive.Location = new Point(181, 314);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(68, 40);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.Click += btnNumber_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 14F);
            btnSix.Location = new Point(253, 314);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(68, 40);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.Click += btnNumber_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 14F);
            btnOne.Location = new Point(108, 358);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(68, 40);
            btnOne.TabIndex = 10;
            btnOne.Text = "1";
            btnOne.Click += btnNumber_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 14F);
            btnTwo.Location = new Point(181, 358);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(68, 40);
            btnTwo.TabIndex = 11;
            btnTwo.Text = "2";
            btnTwo.Click += btnNumber_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 14F);
            btnThree.Location = new Point(253, 358);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(68, 40);
            btnThree.TabIndex = 12;
            btnThree.Text = "3";
            btnThree.Click += btnNumber_Click;
            // 
            // btnPosNeg
            // 
            btnPosNeg.Font = new Font("Segoe UI", 14F);
            btnPosNeg.Location = new Point(108, 401);
            btnPosNeg.Name = "btnPosNeg";
            btnPosNeg.Size = new Size(68, 40);
            btnPosNeg.TabIndex = 13;
            btnPosNeg.Text = "+/-";
            btnPosNeg.Click += btnSign_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 14F);
            btnZero.Location = new Point(181, 401);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(68, 40);
            btnZero.TabIndex = 14;
            btnZero.Text = "0";
            btnZero.Click += btnNumber_Click;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Segoe UI", 20F);
            btnDec.Location = new Point(253, 401);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(68, 40);
            btnDec.TabIndex = 15;
            btnDec.Text = ".";
            btnDec.Click += btnNumber_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14F);
            btnDivide.Location = new Point(296, 228);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(97, 40);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.Click += btnOperator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 14F);
            btnMultiply.Location = new Point(325, 271);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(68, 40);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "X";
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 20F);
            btnSub.Location = new Point(325, 314);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(68, 40);
            btnSub.TabIndex = 18;
            btnSub.Text = "-";
            btnSub.Click += btnOperator_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 20F);
            btnAdd.Location = new Point(325, 358);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 40);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.Click += btnOperator_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14F);
            btnEqual.Location = new Point(325, 401);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(68, 40);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.Click += btnEqual_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.Location = new Point(258, 185);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 40);
            btnBack.TabIndex = 21;
            btnBack.Text = "<";
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F);
            btnClear.Location = new Point(108, 185);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 22;
            btnClear.Text = "C";
            btnClear.Click += btnClear_Click;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(335, 156);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(58, 20);
            btnMS.TabIndex = 30;
            btnMS.Text = "MS";
            btnMS.Click += btnMS_Click;
            // 
            // btnMC
            // 
            btnMC.Location = new Point(108, 156);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(57, 20);
            btnMC.TabIndex = 31;
            btnMC.Text = "MC";
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(181, 156);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(61, 20);
            btnMR.TabIndex = 32;
            btnMR.Text = "MR";
            btnMR.Click += btnMR_Click;
            // 
            // btnMP
            // 
            btnMP.Location = new Point(258, 156);
            btnMP.Name = "btnMP";
            btnMP.Size = new Size(63, 20);
            btnMP.TabIndex = 34;
            btnMP.Text = "M+";
            btnMP.Click += btnMPlus_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.Font = new Font("Segoe UI", 20F);
            lblDisplay.Location = new Point(108, 79);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(285, 64);
            lblDisplay.TabIndex = 35;
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMemoryIndicator
            // 
            lblMemoryIndicator.AutoSize = true;
            lblMemoryIndicator.Location = new Point(108, 60);
            lblMemoryIndicator.Name = "lblMemoryIndicator";
            lblMemoryIndicator.Size = new Size(0, 15);
            lblMemoryIndicator.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 483);
            Controls.Add(lblMemoryIndicator);
            Controls.Add(lblDisplay);
            Controls.Add(btnMP);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnMS);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDec);
            Controls.Add(btnZero);
            Controls.Add(btnPosNeg);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSqrt);
            Controls.Add(btnReciprocal);
            Name = "Form1";
            Text = "Calculator Pro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReciprocal;
        private Button btnSqrt;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnPosNeg;
        private Button btnZero;
        private Button btnDec;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSub;
        private Button btnAdd;
        private Button btnEqual;
        private Button btnBack;
        private Button btnClear;
        private Button btnMS;
        private Button btnMC;
        private Button btnMR;
        private Button btnMP;
        private Label lblDisplay;
        private Label lblMemoryIndicator;
    }
}