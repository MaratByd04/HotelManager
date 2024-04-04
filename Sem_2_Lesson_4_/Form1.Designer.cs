namespace Sem_2_Lesson_4_
{
    partial class HotelManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelManager));
            Timer = new System.Timers.Timer();
            splitter1 = new Splitter();
            panel1 = new Panel();
            panel2 = new Panel();
            StatusLabel = new Label();
            TimeLabel = new Label();
            ClockPicture = new PictureBox();
            SearchTextBox = new RichTextBox();
            LupaPictureBox = new PictureBox();
            ListLabel = new Label();
            registeredRadioButton = new RadioButton();
            freeRadioButton = new RadioButton();
            movingOutRadioButton = new RadioButton();
            busyRadioButton = new RadioButton();
            NumberLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            StatusLabelRight = new Label();
            RealTimeStatusLabel = new Label();
            FIOLable = new Label();
            Check_in_dataLabel = new Label();
            Check_out_dataLabel = new Label();
            CardViewButton = new Button();
            guestsListBox = new ListBox();
            infoCardPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)Timer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClockPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LupaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            infoCardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.SynchronizingObject = this;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 4, 3, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 563);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlText;
            panel1.Location = new Point(221, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 479);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ControlText;
            panel2.Location = new Point(511, 68);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 480);
            panel2.TabIndex = 2;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.BorderStyle = BorderStyle.FixedSingle;
            StatusLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabel.Location = new Point(31, 68);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.RightToLeft = RightToLeft.No;
            StatusLabel.Size = new Size(146, 44);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Статус\r\n";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            StatusLabel.UseMnemonic = false;
            // 
            // TimeLabel
            // 
            TimeLabel.BorderStyle = BorderStyle.FixedSingle;
            TimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TimeLabel.Location = new Point(35, 11);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(120, 34);
            TimeLabel.TabIndex = 4;
            TimeLabel.Text = "\r\n\r\n";
            // 
            // ClockPicture
            // 
            ClockPicture.BorderStyle = BorderStyle.FixedSingle;
            ClockPicture.Image = (Image)resources.GetObject("ClockPicture.Image");
            ClockPicture.Location = new Point(154, 11);
            ClockPicture.Margin = new Padding(3, 4, 3, 4);
            ClockPicture.Name = "ClockPicture";
            ClockPicture.Size = new Size(25, 34);
            ClockPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ClockPicture.TabIndex = 5;
            ClockPicture.TabStop = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(255, 11);
            SearchTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(484, 33);
            SearchTextBox.TabIndex = 7;
            SearchTextBox.Text = "Поиск...";
            // 
            // LupaPictureBox
            // 
            LupaPictureBox.BorderStyle = BorderStyle.FixedSingle;
            LupaPictureBox.Image = (Image)resources.GetObject("LupaPictureBox.Image");
            LupaPictureBox.Location = new Point(736, 11);
            LupaPictureBox.Margin = new Padding(3, 4, 3, 4);
            LupaPictureBox.Name = "LupaPictureBox";
            LupaPictureBox.Size = new Size(22, 33);
            LupaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LupaPictureBox.TabIndex = 8;
            LupaPictureBox.TabStop = false;
            // 
            // ListLabel
            // 
            ListLabel.BorderStyle = BorderStyle.FixedSingle;
            ListLabel.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            ListLabel.Location = new Point(235, 68);
            ListLabel.Name = "ListLabel";
            ListLabel.Size = new Size(269, 55);
            ListLabel.TabIndex = 9;
            ListLabel.Text = "Список гостей";
            // 
            // registeredRadioButton
            // 
            registeredRadioButton.Location = new Point(31, 165);
            registeredRadioButton.Margin = new Padding(3, 4, 3, 4);
            registeredRadioButton.Name = "registeredRadioButton";
            registeredRadioButton.Size = new Size(159, 29);
            registeredRadioButton.TabIndex = 10;
            registeredRadioButton.TabStop = true;
            registeredRadioButton.Text = "Зарегистрировано";
            registeredRadioButton.UseVisualStyleBackColor = true;
            registeredRadioButton.CheckedChanged += registeredRadioButton_CheckedChanged;
            // 
            // freeRadioButton
            // 
            freeRadioButton.Location = new Point(31, 213);
            freeRadioButton.Margin = new Padding(3, 4, 3, 4);
            freeRadioButton.Name = "freeRadioButton";
            freeRadioButton.Size = new Size(159, 29);
            freeRadioButton.TabIndex = 11;
            freeRadioButton.TabStop = true;
            freeRadioButton.Text = "Свободные";
            freeRadioButton.UseVisualStyleBackColor = true;
            freeRadioButton.CheckedChanged += freeRadioButton_CheckedChanged;
            // 
            // movingOutRadioButton
            // 
            movingOutRadioButton.Location = new Point(31, 317);
            movingOutRadioButton.Margin = new Padding(3, 4, 3, 4);
            movingOutRadioButton.Name = "movingOutRadioButton";
            movingOutRadioButton.Size = new Size(159, 29);
            movingOutRadioButton.TabIndex = 12;
            movingOutRadioButton.TabStop = true;
            movingOutRadioButton.Text = "Выписываются";
            movingOutRadioButton.UseVisualStyleBackColor = true;
            movingOutRadioButton.CheckedChanged += movingOutRadioButton_CheckedChanged;
            // 
            // busyRadioButton
            // 
            busyRadioButton.Location = new Point(31, 265);
            busyRadioButton.Margin = new Padding(3, 4, 3, 4);
            busyRadioButton.Name = "busyRadioButton";
            busyRadioButton.Size = new Size(159, 29);
            busyRadioButton.TabIndex = 13;
            busyRadioButton.TabStop = true;
            busyRadioButton.Text = "Заняты";
            busyRadioButton.UseVisualStyleBackColor = true;
            busyRadioButton.CheckedChanged += busyRadioButton_CheckedChanged;
            // 
            // NumberLabel
            // 
            NumberLabel.BorderStyle = BorderStyle.FixedSingle;
            NumberLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLabel.Location = new Point(13, 9);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(117, 31);
            NumberLabel.TabIndex = 14;
            NumberLabel.Text = "Номер №";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(434, -259);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 56);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // StatusLabelRight
            // 
            StatusLabelRight.BorderStyle = BorderStyle.FixedSingle;
            StatusLabelRight.Location = new Point(13, 190);
            StatusLabelRight.Name = "StatusLabelRight";
            StatusLabelRight.Size = new Size(58, 25);
            StatusLabelRight.TabIndex = 17;
            StatusLabelRight.Text = "Статус:";
            // 
            // RealTimeStatusLabel
            // 
            RealTimeStatusLabel.BorderStyle = BorderStyle.FixedSingle;
            RealTimeStatusLabel.Location = new Point(77, 190);
            RealTimeStatusLabel.Name = "RealTimeStatusLabel";
            RealTimeStatusLabel.Size = new Size(167, 26);
            RealTimeStatusLabel.TabIndex = 18;
            RealTimeStatusLabel.Text = ".....";
            // 
            // FIOLable
            // 
            FIOLable.BorderStyle = BorderStyle.FixedSingle;
            FIOLable.Location = new Point(13, 230);
            FIOLable.Name = "FIOLable";
            FIOLable.Size = new Size(231, 47);
            FIOLable.TabIndex = 19;
            FIOLable.Text = "ФИО:";
            // 
            // Check_in_dataLabel
            // 
            Check_in_dataLabel.BorderStyle = BorderStyle.FixedSingle;
            Check_in_dataLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Check_in_dataLabel.Location = new Point(13, 301);
            Check_in_dataLabel.Name = "Check_in_dataLabel";
            Check_in_dataLabel.Size = new Size(231, 53);
            Check_in_dataLabel.TabIndex = 20;
            Check_in_dataLabel.Text = ".....";
            // 
            // Check_out_dataLabel
            // 
            Check_out_dataLabel.BorderStyle = BorderStyle.FixedSingle;
            Check_out_dataLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Check_out_dataLabel.Location = new Point(13, 376);
            Check_out_dataLabel.Name = "Check_out_dataLabel";
            Check_out_dataLabel.Size = new Size(231, 53);
            Check_out_dataLabel.TabIndex = 21;
            Check_out_dataLabel.Text = ".....";
            // 
            // CardViewButton
            // 
            CardViewButton.Location = new Point(60, 458);
            CardViewButton.Name = "CardViewButton";
            CardViewButton.Size = new Size(139, 28);
            CardViewButton.TabIndex = 22;
            CardViewButton.Text = "Просмотр карточки";
            CardViewButton.UseVisualStyleBackColor = true;
            CardViewButton.Click += GuestViewButton;
            // 
            // guestsListBox
            // 
            guestsListBox.FormattingEnabled = true;
            guestsListBox.ItemHeight = 20;
            guestsListBox.Location = new Point(237, 141);
            guestsListBox.Name = "guestsListBox";
            guestsListBox.Size = new Size(268, 404);
            guestsListBox.TabIndex = 23;
            guestsListBox.DoubleClick += ShowInfoAboutGuest;
            // 
            // infoCardPanel
            // 
            infoCardPanel.Controls.Add(CardViewButton);
            infoCardPanel.Controls.Add(Check_out_dataLabel);
            infoCardPanel.Controls.Add(Check_in_dataLabel);
            infoCardPanel.Controls.Add(FIOLable);
            infoCardPanel.Controls.Add(RealTimeStatusLabel);
            infoCardPanel.Controls.Add(StatusLabelRight);
            infoCardPanel.Controls.Add(pictureBox2);
            infoCardPanel.Controls.Add(NumberLabel);
            infoCardPanel.Location = new Point(538, 55);
            infoCardPanel.Name = "infoCardPanel";
            infoCardPanel.Size = new Size(252, 495);
            infoCardPanel.TabIndex = 24;
            infoCardPanel.Visible = false;
            // 
            // HotelManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(infoCardPanel);
            Controls.Add(guestsListBox);
            Controls.Add(pictureBox1);
            Controls.Add(busyRadioButton);
            Controls.Add(movingOutRadioButton);
            Controls.Add(freeRadioButton);
            Controls.Add(registeredRadioButton);
            Controls.Add(ListLabel);
            Controls.Add(LupaPictureBox);
            Controls.Add(SearchTextBox);
            Controls.Add(ClockPicture);
            Controls.Add(TimeLabel);
            Controls.Add(StatusLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(splitter1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelManager";
            Text = "Гостиница";
            ((System.ComponentModel.ISupportInitialize)Timer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClockPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)LupaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            infoCardPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label NumberLabel;

        private PictureBox pictureBox2;

        private PictureBox pictureBox1;

        private Label StatusLabelRight;

        private RadioButton registeredRadioButton;
        private RadioButton freeRadioButton;
        private RadioButton movingOutRadioButton;
        private RadioButton busyRadioButton;

        private Label ListLabel;

        private PictureBox LupaPictureBox;

        private RichTextBox SearchTextBox;

        private PictureBox ClockPicture;

        private Label TimeLabel;

        private Label StatusLabel;

        private Panel panel2;

        private Panel panel1;

        private Splitter splitter1;

        private System.Timers.Timer Timer;

        #endregion

        private Label RealTimeStatusLabel;
        private Label Check_in_dataLabel;
        private Label FIOLable;
        private Button CardViewButton;
        private Label Check_out_dataLabel;
        private ListBox guestsListBox;
        private Panel infoCardPanel;
    }
}