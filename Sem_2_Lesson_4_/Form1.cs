using NLog;

namespace Sem_2_Lesson_4_
{
    public partial class HotelManager : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        System.Windows.Forms.Timer _timer;
        string line = string.Empty;
        string[,] infoAboutGuests = new string[100, 6];
        int peopleAmount = 0;
        int index = 0;


        public HotelManager()
        {
            InitializeComponent();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();


            StreamReader sr = new StreamReader("GuestsList.txt");
            int i = 0;
            while (true)
            {
                line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                var values = line.Split(", ");
                for (int j = 0; j < 6; j++)
                {
                    infoAboutGuests[i, j] = values[j];
                }
                i++;
            }
            peopleAmount = i;
            sr.Close();
            logger.Trace("Файл успешно сохранен");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void registeredRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (registeredRadioButton.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < peopleAmount; i++)
                {
                    if (infoAboutGuests[i, 3] == "зарезервировал")
                    {
                        guestsListBox.Items.Add(infoAboutGuests[i, 1]);

                    }
                }
            }
        }

        private void freeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (freeRadioButton.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < peopleAmount; i++)
                {
                    if (infoAboutGuests[i, 3] == "свободный")
                    {
                        guestsListBox.Items.Add(infoAboutGuests[i, 1]);

                    }
                }
            }
        }

        private void busyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (busyRadioButton.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < peopleAmount; i++)
                {
                    if (infoAboutGuests[i, 3] == "занятый")
                    {
                        guestsListBox.Items.Add(infoAboutGuests[i, 1]);

                    }
                }
            }

        }

        private void movingOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (movingOutRadioButton.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < peopleAmount; i++)
                {
                    if (infoAboutGuests[i, 3] == "выписывается")
                    {
                        guestsListBox.Items.Add(infoAboutGuests[i, 1]);

                    }
                }
            }
        }

        private void ShowInfoAboutGuest(object sender, EventArgs e)
        {
            infoCardPanel.Visible = true;

            for (int i = 0; i < peopleAmount; i++)
            {
                if (infoAboutGuests[i, 1] == guestsListBox.SelectedItem.ToString())
                {
                    NumberLabel.Text = $"Номер: {(int.Parse(infoAboutGuests[i, 0]) + 1).ToString()}";
                    FIOLable.Text = infoAboutGuests[i, 1];
                    RealTimeStatusLabel.Text = infoAboutGuests[i, 3];
                    Check_in_dataLabel.Text = infoAboutGuests[i, 4];
                    Check_out_dataLabel.Text = infoAboutGuests[i, 5];
                    index = i;
                }

            }
        }

        private void GuestViewButton(object sender, EventArgs e)
        {
            GuestCard form2 = new GuestCard(infoAboutGuests, index);
            form2.Show();
        }
    }
}