using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Traffic_Light_Uc.uc_Traffic_Light;


namespace Traffic_Light_Uc
{
    public partial class uc_Traffic_Light : UserControl
    {

        public event EventHandler<TrafficLightEventArgs> OnRed;
        public event EventHandler<TrafficLightEventArgs> OnOrange;
        public event EventHandler<TrafficLightEventArgs> OnGreen;
        public enum enTrafficColours { Red = 1, Green = 2, Orange = 3 };

        private enTrafficColours _CurrentLight = enTrafficColours.Red;

        public enTrafficColours CurrentLight
        {
            get { return _CurrentLight; }

            set
            {

                _CurrentLight = value;

                switch (_CurrentLight)
                {
                    case enTrafficColours.Green:

                        using (MemoryStream ms = new MemoryStream(Properties.Resources.Green))
                        {
                            picTaffic.Image = Image.FromStream(ms);
                        }
                        labTimer.ForeColor = Color.Green;
                        break;
                    case enTrafficColours.Red:

                        using (MemoryStream ms = new MemoryStream(Properties.Resources.Red))
                        {
                            picTaffic.Image = Image.FromStream(ms);
                        }
                        labTimer.ForeColor = Color.Red;
                        break;
                    case enTrafficColours.Orange:

                        using (MemoryStream ms = new MemoryStream(Properties.Resources.Orange))
                        {
                            picTaffic.Image = Image.FromStream(ms);
                        }
                        labTimer.ForeColor = Color.Orange;
                        break;

                }
            }
        }

        private int _GreenTime;
        private int _RedTime;
        private int _OrangeTime;

        public int GreenTime
        {
            get
            {
                return _GreenTime;
            }
            set
            {
                _GreenTime = value;
            }
        }
        public int RedTime
        {
            get
            {
                return _RedTime;
            }
            set
            {
                _RedTime = value;
            }
        }
        public int OrangeTime
        {
            get
            {
                return _OrangeTime;
            }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case enTrafficColours.Red:
                    return RedTime;

                case enTrafficColours.Orange:
                    return OrangeTime;

                case enTrafficColours.Green:
                    return GreenTime;
                default:
                    return 0;
            }
        }

        private int _CurrentCountDownValue;
        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            timer1.Start();
        }
        public void Stop()
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labTimer.Text = _CurrentCountDownValue.ToString();
            if (_CurrentCountDownValue == 0)
            {
                //timer1.Stop();
                ChangeLight();
            }
            else
            {
                --_CurrentCountDownValue;
            }
        }
        private enTrafficColours _LightAfterOrangeRedOrGreen;
        public void RaiseGreenLightOn()
        {
            OnGreen.Invoke(this, new TrafficLightEventArgs(enTrafficColours.Green, GreenTime));
        }
        public void RaiseRedLightOn()
        {
            OnRed.Invoke(this, new TrafficLightEventArgs(enTrafficColours.Red, RedTime));
        }
        public void RaiseOrangeLightOn()
        {
            OnOrange.Invoke(this, new TrafficLightEventArgs(enTrafficColours.Orange, OrangeTime));
        }
        public void ChangeLight()
        {
            switch (_CurrentLight)
            {
                case enTrafficColours.Red:
                    _LightAfterOrangeRedOrGreen = enTrafficColours.Green;
                    CurrentLight = enTrafficColours.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    labTimer.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

                case enTrafficColours.Orange:
                    if (_LightAfterOrangeRedOrGreen == enTrafficColours.Green)
                    {
                        CurrentLight = enTrafficColours.Green;
                        _CurrentCountDownValue = GreenTime;
                        labTimer.Text = _CurrentCountDownValue.ToString();
                        RaiseGreenLightOn();
                        break;
                    }
                    else
                    {
                        CurrentLight = enTrafficColours.Red;
                        _CurrentCountDownValue = RedTime;
                        labTimer.Text = _CurrentCountDownValue.ToString();
                        RaiseRedLightOn();
                        break;
                    }

                case enTrafficColours.Green:
                    _LightAfterOrangeRedOrGreen = enTrafficColours.Red;
                    CurrentLight = enTrafficColours.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    labTimer.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

            }

        }
        public uc_Traffic_Light()
        {
            InitializeComponent();
        }



        //private Image LoadEmbeddedImage(string resourceName)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();
        //    string resourcePath = "Traffic_Light.Properties.Resources." + resourceName;

        //    using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
        //    {
        //        return stream != null ? Image.FromStream(stream) : null;
        //    }
        //}

    }

    public class TrafficLightEventArgs : EventArgs
    {
        public enTrafficColours CurrentLight { get; }
        public int LightDuration { get; }

        public TrafficLightEventArgs(enTrafficColours colour, int lightDuration)
        {
            this.CurrentLight = colour;
            this.LightDuration = lightDuration;
        }
    }
}
