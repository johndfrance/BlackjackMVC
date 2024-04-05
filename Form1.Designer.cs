namespace BlackjackMVC
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
            btnHit = new Button();
            btnStand = new Button();
            btnBet1 = new Button();
            btnBet5 = new Button();
            btnDeal = new Button();
            lblDealerCards = new Label();
            lblPlayerCards = new Label();
            lblPlayerWallet = new Label();
            lblPot = new Label();
            lblPlayerHandValue = new Label();
            lblDealerHandValue = new Label();
            lblResult = new Label();
            btnPlayAgain = new Button();
            btnDoubleDown = new Button();
            btnInsurance = new Button();
            lblSplitCards = new Label();
            lblSplitHandValue = new Label();
            btnSplit = new Button();
            SuspendLayout();
            // 
            // btnHit
            // 
            btnHit.Location = new Point(547, 197);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(75, 66);
            btnHit.TabIndex = 0;
            btnHit.Text = "HIT";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(651, 197);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(75, 66);
            btnStand.TabIndex = 1;
            btnStand.Text = "STAND";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnBet1
            // 
            btnBet1.Location = new Point(46, 197);
            btnBet1.Name = "btnBet1";
            btnBet1.Size = new Size(103, 34);
            btnBet1.TabIndex = 2;
            btnBet1.Text = "$1";
            btnBet1.UseVisualStyleBackColor = true;
            btnBet1.Click += btnBet1_Click;
            // 
            // btnBet5
            // 
            btnBet5.Location = new Point(46, 249);
            btnBet5.Name = "btnBet5";
            btnBet5.Size = new Size(103, 35);
            btnBet5.TabIndex = 3;
            btnBet5.Text = "$5";
            btnBet5.UseVisualStyleBackColor = true;
            btnBet5.Click += btnBet5_Click;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(547, 74);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(179, 49);
            btnDeal.TabIndex = 4;
            btnDeal.Text = "Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // lblDealerCards
            // 
            lblDealerCards.AutoSize = true;
            lblDealerCards.Location = new Point(295, 74);
            lblDealerCards.Name = "lblDealerCards";
            lblDealerCards.Size = new Size(70, 15);
            lblDealerCards.TabIndex = 5;
            lblDealerCards.Text = "DealerCards";
            // 
            // lblPlayerCards
            // 
            lblPlayerCards.AutoSize = true;
            lblPlayerCards.Location = new Point(257, 326);
            lblPlayerCards.Name = "lblPlayerCards";
            lblPlayerCards.Size = new Size(69, 15);
            lblPlayerCards.TabIndex = 6;
            lblPlayerCards.Text = "PlayerCards";
            // 
            // lblPlayerWallet
            // 
            lblPlayerWallet.AutoSize = true;
            lblPlayerWallet.Location = new Point(69, 335);
            lblPlayerWallet.Name = "lblPlayerWallet";
            lblPlayerWallet.Size = new Size(40, 15);
            lblPlayerWallet.TabIndex = 7;
            lblPlayerWallet.Text = "Wallet";
            // 
            // lblPot
            // 
            lblPot.AutoSize = true;
            lblPot.Location = new Point(317, 192);
            lblPot.Name = "lblPot";
            lblPot.Size = new Size(25, 15);
            lblPot.TabIndex = 8;
            lblPot.Text = "Pot";
            // 
            // lblPlayerHandValue
            // 
            lblPlayerHandValue.AutoSize = true;
            lblPlayerHandValue.Location = new Point(181, 326);
            lblPlayerHandValue.Name = "lblPlayerHandValue";
            lblPlayerHandValue.Size = new Size(96, 15);
            lblPlayerHandValue.TabIndex = 9;
            lblPlayerHandValue.Text = "PlayerHandValue";
            // 
            // lblDealerHandValue
            // 
            lblDealerHandValue.AutoSize = true;
            lblDealerHandValue.Location = new Point(407, 74);
            lblDealerHandValue.Name = "lblDealerHandValue";
            lblDealerHandValue.Size = new Size(97, 15);
            lblDealerHandValue.TabIndex = 10;
            lblDealerHandValue.Text = "DealerHandValue";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(206, 239);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(111, 45);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(46, 49);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(144, 65);
            btnPlayAgain.TabIndex = 12;
            btnPlayAgain.Text = "Play Again?";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnDoubleDown
            // 
            btnDoubleDown.Location = new Point(547, 282);
            btnDoubleDown.Name = "btnDoubleDown";
            btnDoubleDown.Size = new Size(78, 68);
            btnDoubleDown.TabIndex = 13;
            btnDoubleDown.Text = "Double Down";
            btnDoubleDown.UseVisualStyleBackColor = true;
            btnDoubleDown.Click += btnDoubleDown_Click;
            // 
            // btnInsurance
            // 
            btnInsurance.Location = new Point(651, 282);
            btnInsurance.Name = "btnInsurance";
            btnInsurance.Size = new Size(75, 68);
            btnInsurance.TabIndex = 14;
            btnInsurance.Text = "Insurance";
            btnInsurance.UseVisualStyleBackColor = true;
            // 
            // lblSplitCards
            // 
            lblSplitCards.AutoSize = true;
            lblSplitCards.Location = new Point(382, 326);
            lblSplitCards.Name = "lblSplitCards";
            lblSplitCards.Size = new Size(60, 15);
            lblSplitCards.TabIndex = 15;
            lblSplitCards.Text = "SplitCards";
            lblSplitCards.Click += lblSplitCards_Click;
            // 
            // lblSplitHandValue
            // 
            lblSplitHandValue.AutoSize = true;
            lblSplitHandValue.Location = new Point(471, 326);
            lblSplitHandValue.Name = "lblSplitHandValue";
            lblSplitHandValue.Size = new Size(87, 15);
            lblSplitHandValue.TabIndex = 16;
            lblSplitHandValue.Text = "SplitHandValue";
            // 
            // btnSplit
            // 
            btnSplit.Location = new Point(598, 356);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(83, 65);
            btnSplit.TabIndex = 17;
            btnSplit.Text = "SPLIT";
            btnSplit.UseVisualStyleBackColor = true;
            btnSplit.Click += btnSplit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSplit);
            Controls.Add(lblSplitHandValue);
            Controls.Add(lblSplitCards);
            Controls.Add(btnInsurance);
            Controls.Add(btnDoubleDown);
            Controls.Add(btnPlayAgain);
            Controls.Add(lblResult);
            Controls.Add(lblDealerHandValue);
            Controls.Add(lblPlayerHandValue);
            Controls.Add(lblPot);
            Controls.Add(lblPlayerWallet);
            Controls.Add(lblPlayerCards);
            Controls.Add(lblDealerCards);
            Controls.Add(btnDeal);
            Controls.Add(btnBet5);
            Controls.Add(btnBet1);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHit;
        private Button btnStand;
        private Button btnBet1;
        private Button btnBet5;
        private Button btnDeal;
        private Label lblDealerCards;
        private Label lblPlayerCards;
        private Label lblPlayerWallet;
        private Label lblPot;
        private Label lblPlayerHandValue;
        private Label lblDealerHandValue;
        private Label lblResult;
        private Button btnPlayAgain;
        private Button btnDoubleDown;
        private Button btnInsurance;
        private Label lblSplitCards;
        private Label lblSplitHandValue;
        private Button btnSplit;
    }
}
