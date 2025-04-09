using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pool_Club
{
    public partial class uc_Table : UserControl
    {
        public uc_Table()
        {
            InitializeComponent();
        }
        public class GameCompletedEventArgs : EventArgs
        {
            public string GamingTimeText { get; }
            public decimal RatePerMinute { get; }
            public decimal TotalFees { get; }


            public GameCompletedEventArgs(string GamingTimeText, decimal RatePerMinute, decimal TotalFees)
            {

                this.TotalFees = TotalFees;
                this.GamingTimeText = GamingTimeText;
                this.RatePerMinute = RatePerMinute;
            }
        }

        public event EventHandler<GameCompletedEventArgs> GameOverForSpecificTable;

        public void RaiseEventGameOverForSpecificTable()
        {
            GameOverForSpecificTable.Invoke(this, new GameCompletedEventArgs(labTimeTable.Text, RatePerMinute, GetPriceForTable()));
        }


        private byte _Seconds;

        private string _nameTable;
        public string NameTable
        {
            get { return _nameTable; }
            set { _nameTable = value; }
        }


        private string _playerName;
        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                _playerName = value;
                labPlayerName.Text = _playerName;
                btnStart.Enabled = true;

            }
        }

        private decimal _ratePerMinute;
        public decimal RatePerMinute
        {
            get
            {
                return _ratePerMinute;
            }
            set
            {
                _ratePerMinute = value;
            }
        }
        public decimal GetPriceForTable()
        {
            return Convert.ToDecimal(btnEnd.Tag.ToString()) * RatePerMinute;
        }

        private void StartTimer(Label lab, Button btnEnd)
        {

            //Seconds++;
            //if (Seconds == 60)
            //{
            //    Seconds = 0;
            //    Minutes++;
            //}
            //lab.Text = $"{Minutes:D2}:{Seconds:D2}";
            //btnEnd.Tag = Minutes;
            _Seconds++;

            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            btnEnd.Tag = time.Minutes;
            string str = time.ToString(@"hh\:mm\:ss");
            labTimeTable.Text = str;

            labTimeTable.Refresh();

        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            StartTimer(labTimeTable, btnEnd);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            if (btnStart.Text == "Resume")
            {
                btnStart.Text = "Start";
            }

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnEnd.Enabled = true;
            groupBox1.BackColor = Color.Gray;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer.Stop();

            RaiseEventGameOverForSpecificTable();
            if (btnStart.Text == "Resume")
            {
                btnStart.Text = "Start";
            }

            btnPause.Enabled = false;
            btnStart.Enabled = false;
            btnEnd.Enabled = false;
            groupBox1.BackColor = Color.Transparent;
            labPlayerName.Text = string.Empty;
            labTimeTable.Text = "00:00";


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Text = "Resume";
            groupBox1.BackColor = Color.Yellow;
            timer.Enabled = false;
        }
    }
}