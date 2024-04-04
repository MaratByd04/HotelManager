namespace Sem_2_Lesson_4_
{
    partial class GuestCard
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
            label1 = new Label();
            FIOforCardLabel = new Label();
            BirthDayForCardLabel = new Label();
            PaymentLabel = new Label();
            AnimalAvailabilityCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 57);
            label1.TabIndex = 0;
            label1.Text = "Карточка гостя";
            // 
            // FIOforCardLabel
            // 
            FIOforCardLabel.BorderStyle = BorderStyle.FixedSingle;
            FIOforCardLabel.Location = new Point(20, 96);
            FIOforCardLabel.Name = "FIOforCardLabel";
            FIOforCardLabel.Size = new Size(320, 48);
            FIOforCardLabel.TabIndex = 1;
            FIOforCardLabel.Text = "label2";
            // 
            // BirthDayForCardLabel
            // 
            BirthDayForCardLabel.BorderStyle = BorderStyle.FixedSingle;
            BirthDayForCardLabel.Location = new Point(20, 170);
            BirthDayForCardLabel.Name = "BirthDayForCardLabel";
            BirthDayForCardLabel.Size = new Size(320, 48);
            BirthDayForCardLabel.TabIndex = 2;
            BirthDayForCardLabel.Text = "label2";
            // 
            // PaymentLabel
            // 
            PaymentLabel.BorderStyle = BorderStyle.FixedSingle;
            PaymentLabel.Location = new Point(20, 241);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(320, 48);
            PaymentLabel.TabIndex = 3;
            PaymentLabel.Text = "label2";
            // 
            // AnimalAvailabilityCheckBox
            // 
            AnimalAvailabilityCheckBox.Location = new Point(23, 368);
            AnimalAvailabilityCheckBox.Name = "AnimalAvailabilityCheckBox";
            AnimalAvailabilityCheckBox.Size = new Size(312, 29);
            AnimalAvailabilityCheckBox.TabIndex = 4;
            AnimalAvailabilityCheckBox.Text = "С животными";
            AnimalAvailabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 450);
            Controls.Add(AnimalAvailabilityCheckBox);
            Controls.Add(PaymentLabel);
            Controls.Add(BirthDayForCardLabel);
            Controls.Add(FIOforCardLabel);
            Controls.Add(label1);
            Name = "GuestCard";
            Text = "Карточка гостя";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label FIOforCardLabel;
        private Label BirthDayForCardLabel;
        private Label PaymentLabel;
        private CheckBox AnimalAvailabilityCheckBox;
    }
}