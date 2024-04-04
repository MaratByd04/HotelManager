using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_2_Lesson_4_
{
    public partial class GuestCard : Form
    {
        public GuestCard(string[,] infoAboutGuests, int index)
        {
            InitializeComponent();
            FIOforCardLabel.Text = infoAboutGuests[index, 1];
            BirthDayForCardLabel.Text = infoAboutGuests[index, 2];
            PaymentLabel.Text = "Оплата: Очень много";
        }
    }
}
