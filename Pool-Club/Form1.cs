using System.Windows.Forms;

namespace Pool_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(uc_Table1.PlayerName))
            {
                uc_Table1.PlayerName = txtPlayerName.Text;

            }
            else if (string.IsNullOrWhiteSpace(uc_Table2.PlayerName))
            {
                uc_Table2.PlayerName = txtPlayerName.Text;
            }
            else if (string.IsNullOrWhiteSpace(uc_Table3.PlayerName))
            {
                uc_Table3.PlayerName = txtPlayerName.Text;
            }
            else if (string.IsNullOrWhiteSpace(uc_Table4.PlayerName))
            {
                uc_Table4.PlayerName = txtPlayerName.Text;
            }
            else if (string.IsNullOrWhiteSpace(uc_Table5.PlayerName))
            {
                uc_Table5.PlayerName = txtPlayerName.Text;
            }
            else if (string.IsNullOrWhiteSpace(uc_Table6.PlayerName))
            {
                uc_Table6.PlayerName = txtPlayerName.Text;
            }
            else
            {
                MessageBox.Show("Error,There are not an empty table in club", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uc_Table_GameOverForSpecificTable(object sender, uc_Table.GameCompletedEventArgs e)
        {
            MessageBox.Show($"Game over,This player plays : {e.GamingTimeText} and rate per minute is : {e.RatePerMinute},Total price is: {e.TotalFees}");
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            uc_Table1.RatePerMinute = numericUpDown1.Value;
        }

    }
}
