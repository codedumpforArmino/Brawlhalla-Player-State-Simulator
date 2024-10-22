namespace Brawlhalla_Player_State_Simulator
{
    public partial class Form1 : Form
    {
        PlayerState pState;
        int curr_state;
        int prev_state;
        public Form1()
        {
            InitializeComponent();
            pState = new PlayerState();
            lbl_StateIndicator.Text = pState.GetDiscreteStateDescription();
        }

        private void btn_Jump_Click(object sender, EventArgs e)
        {
            prev_state = curr_state;

            switch (prev_state)
            {
                case 3:
                case 6:
                case 9:
                case 12:
                    rtb_ReportLog.AppendText("cannot jump...\n");
                    break;
                default:
                    rtb_ReportLog.AppendText("Jumping...\n");
                    break;
            }

            curr_state = pState.getNextState(1);
            rtb_ReportLog.AppendText("now in q" + curr_state + "\n");
            lbl_StateIndicator.Text = pState.GetDiscreteStateDescription();
            updatePlayerState_Box(curr_state);
        }

        private void btn_Dodge_Click(object sender, EventArgs e)
        {

            prev_state = curr_state;
            switch (prev_state)
            {
                case 4:
                case 5:
                case 6:
                case 10:
                case 11:
                case 12:
                    rtb_ReportLog.AppendText("cannot dodge...\n");
                    break;
                default:
                    rtb_ReportLog.AppendText("Dodging...\n");
                    break;
            }

            curr_state = pState.getNextState(2);
            
            rtb_ReportLog.AppendText("now in q" + curr_state + "\n");
            lbl_StateIndicator.Text = pState.GetDiscreteStateDescription();
            updatePlayerState_Box(curr_state);
        }

        private void btn_Recovery_Click(object sender, EventArgs e)
        {
            prev_state = curr_state;

            switch (prev_state)
            {
                case 0:
                    rtb_ReportLog.AppendText("Heavy Attack...\n");
                    break;
                case 9:
                case 12:
                    rtb_ReportLog.AppendText("Unable to Recover...\n");
                    break;
                default:
                    rtb_ReportLog.AppendText("Recovering...\n");
                    break;
            }
            curr_state = pState.getNextState(3);
            
            rtb_ReportLog.AppendText("now in q" + curr_state + "\n");
            lbl_StateIndicator.Text = pState.GetDiscreteStateDescription();
            updatePlayerState_Box(curr_state);
        }

        private void btn_HGround_Click(object sender, EventArgs e)
        {
            prev_state = curr_state;
            curr_state = pState.getNextState(0);
            rtb_ReportLog.AppendText("Landing...\n");
            rtb_ReportLog.AppendText("now in q" + curr_state + "\n");
            lbl_StateIndicator.Text = pState.GetDiscreteStateDescription();
            updatePlayerState_Box(curr_state);

        }

        private void updatePlayerState_Box(int stateValue)
        {
            switch (stateValue)
            {
                case 0:
                    PlayerState_Box.Image = Properties.Resources.grounded;
                    break;
                case 1:
                case 2:
                case 4:
                case 5:
                case 7:
                case 8:
                case 10:
                case 11:
                    PlayerState_Box.Image = Properties.Resources.Floating;
                    break;

                case 3:
                case 6:
                case 9:
                    PlayerState_Box.Image = Properties.Resources.Jump_Exhausted;
                    break;


                case 12:
                    PlayerState_Box.Image = Properties.Resources.Fully_Exhausted;
                    break;
            }
        }
    }
}
