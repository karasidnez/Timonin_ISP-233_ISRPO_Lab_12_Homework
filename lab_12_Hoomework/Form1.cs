namespace lab_12_Hoomework
{
    public partial class Form1 : Form
    {
        int clikcount = 0;
        int timecount = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clikcount++;
            Clicki1.Text = $"Количество кликов {clikcount}";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timecount++;
            Time1.Text = $"Время:{timecount}";


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            clikcount = 0;
            Clicki1.Text = $"Количество кликов {clikcount}";
            timecount = 0;
            Time1.Text = $"Время:{timecount}";
            timer1.Stop();
        }
    }
}
