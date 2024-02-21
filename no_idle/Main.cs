namespace no_idle
{
    public partial class Main : Form
    {
        private const int ONE_SECOND = 1000;
        private readonly Random rand = new();
        private bool moving = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                return;
            }

            Hide();
            notifyIcon.Visible = true;
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var text = "Stop";
            var enabled = false;


            moving = !moving;

            if (moving)
            {
                StartInterval();
            }
            else
            {
                StopInterval();

                text = "Start";
                enabled = true;
            }

            button.Text = text;
            intervalInput.Enabled = enabled;
        }

        private void TimerPointer_Tick(object sender, EventArgs e)
        {
            if (!moving) return;

            SetMousePosition();

            resetProgressBar();
        }

        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            if (!moving) return;

            progressBar.PerformStep();
        }

        private void StartInterval()
        {
            var interval = (int)intervalInput.Value * ONE_SECOND;

            progressBar.Minimum = 0;
            progressBar.Maximum = interval;
            progressBar.Step = ONE_SECOND;

            timerProgress.Interval = ONE_SECOND;
            timerProgress.Enabled = true;
            timerProgress.Start();

            timerPointer.Interval = interval;
            timerPointer.Enabled = true;
            timerPointer.Start();
        }

        private void StopInterval()
        {
            timerProgress.Stop();
            timerProgress.Enabled = false;

            timerPointer.Stop();
            timerPointer.Enabled = false;

            resetProgressBar();
        }

        private void SetMousePosition()
        {
            var x = rand.Next(0, this.Size.Width);
            var y = rand.Next(0, this.Size.Height);
            var p = new Point(x, y);

            Cursor.Position = PointToScreen(p);

            statusLabel.Text = $"{x}, {y}";
        }

        private void resetProgressBar()
        {
            progressBar.Value = 0;
        }
    }
}
