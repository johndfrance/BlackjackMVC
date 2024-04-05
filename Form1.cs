namespace BlackjackMVC
{
    public partial class Form1 : Form
    {
        private Controller Controller;
        public Form1()
        {
            InitializeComponent();
            Controller = new Controller();
            UpdateUI();
        }

        private void btnBet1_Click(object sender, EventArgs e)
        {
            Controller.Pot += 1;
            UpdateUI();
        }

        private void btnBet5_Click(object sender, EventArgs e)
        {
            Controller.Pot += 5;
            UpdateUI();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Controller.StartGame();
            UpdateUI();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Controller.Hit();
            UpdateUI();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            Controller.Stand();
            UpdateUI();
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Controller.Reset();
            UpdateUI();
        }

        private void btnDoubleDown_Click(object sender, EventArgs e)
        {
            Controller.DoubleDown();
            UpdateUI();
            Controller.Hit();
            UpdateUI();
            Controller.Stand();
            UpdateUI();

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            Controller.Split();
            UpdateUI();
        }
        public void UpdateUI()
        {
            lblPlayerCards.Text = Controller.GetPlayerHandString();
            lblDealerCards.Text = Controller.GetDealerHandString();
            lblSplitCards.Text = Controller.GetSplitHandString();
            lblPlayerWallet.Text = Controller.Player.wallet.ToString();
            lblPot.Text = Controller.Pot.ToString();
            lblPlayerHandValue.Text = Controller.PlayerHand.HandValue().ToString();
            lblDealerHandValue.Text = Controller.DealerHand.HandValue().ToString();
            lblSplitHandValue.Text = Controller.SplitHand.HandValue().ToString();

            lblResult.Text = "";
            btnPlayAgain.Visible = false;
            btnDoubleDown.Visible = false;
            btnInsurance.Visible = false;
            btnSplit.Visible = false;

            lblSplitCards.Visible = false;
            lblSplitHandValue.Visible = false;

            if (Controller.BettingPhase)
            {
                btnBet1.Enabled = true;
                btnBet5.Enabled = true;
                btnDeal.Enabled = true;
                btnHit.Enabled = false;
                btnStand.Enabled = false;
                btnDoubleDown.Visible = false;
                lblPlayerHandValue.Visible = false;
                lblDealerHandValue.Visible = false;
            }
            else
            {
                if (Controller.PlayerHand.countCard() == 2)
                {
                    if (Controller.DealerHand.AceHole())
                    {
                        btnInsurance.Visible = true;
                    }
                    if (Controller.PlayerHand.CheckSplit())
                    {
                        btnSplit.Visible = true;

                    }
                    btnDoubleDown.Visible = true;
                }
                else
                {
                    btnDoubleDown.Visible = false;
                    btnInsurance.Visible = false;
                    btnSplit.Visible = false;
                }

                btnBet1.Enabled = false;
                btnBet5.Enabled = false;
                btnDeal.Enabled = false;
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                lblPlayerHandValue.Visible = true;
                lblDealerHandValue.Visible = true;

                if (Controller.SplitActive || Controller.SplitHold)
                {
                    lblSplitCards.Visible = true;
                    lblSplitHandValue.Visible = true;
                    lblResult.Text = Controller.Result;
                }

            }

            if (Controller.GameOver)
            {
                btnBet1.Enabled = false;
                btnBet5.Enabled = false;
                btnDeal.Enabled = false;
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                lblResult.Text = Controller.Result;
                btnPlayAgain.Visible = true;
            }
        }

        private void lblSplitCards_Click(object sender, EventArgs e)
        {

        }
    }
}
