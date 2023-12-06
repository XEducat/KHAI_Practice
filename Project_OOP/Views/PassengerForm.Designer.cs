namespace Project_OOP.Views
{
    partial class PassengerForm
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
            button1 = new Button();
            txTicketNumber = new TextBox();
            txbAge = new TextBox();
            txbName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(242, 278);
            button1.Name = "button1";
            button1.Size = new Size(284, 46);
            button1.TabIndex = 9;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCreatePassanger_Pressed;
            // 
            // txTicketNumber
            // 
            txTicketNumber.Location = new Point(187, 208);
            txTicketNumber.Name = "txTicketNumber";
            txTicketNumber.PlaceholderText = "Номер білету";
            txTicketNumber.Size = new Size(401, 27);
            txTicketNumber.TabIndex = 7;
            // 
            // txbAge
            // 
            txbAge.Location = new Point(187, 160);
            txbAge.Name = "txbAge";
            txbAge.PlaceholderText = "Вік";
            txbAge.Size = new Size(401, 27);
            txbAge.TabIndex = 6;
            // 
            // txbName
            // 
            txbName.Location = new Point(187, 112);
            txbName.Name = "txbName";
            txbName.PlaceholderText = "Ім'я";
            txbName.Size = new Size(401, 27);
            txbName.TabIndex = 5;
            // 
            // PassengerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txTicketNumber);
            Controls.Add(txbAge);
            Controls.Add(txbName);
            Name = "PassengerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PassangerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txTicketNumber;
        private TextBox txbAge;
        private TextBox txbName;
    }
}