namespace Project_OOP
{
    partial class AirportForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblAirportName = new Label();
            dataGridView = new DataGridView();
            Model = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            NumberOfSeats = new DataGridViewTextBoxColumn();
            Buttons = new DataGridViewButtonColumn();
            Type = new DataGridViewTextBoxColumn();
            lblAirportInfoAboout = new Label();
            button2 = new Button();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 851);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(280, 88);
            button1.TabIndex = 1;
            button1.Text = "Додати літак";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddAircraft;
            // 
            // lblAirportName
            // 
            lblAirportName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblAirportName.Location = new Point(387, 26);
            lblAirportName.Name = "lblAirportName";
            lblAirportName.Size = new Size(1131, 46);
            lblAirportName.TabIndex = 8;
            lblAirportName.Text = "Назва аеропорту";
            lblAirportName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Model, Number, NumberOfSeats, Buttons, Type });
            dataGridView.Location = new Point(87, 250);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(789, 459);
            dataGridView.TabIndex = 9;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // Model
            // 
            Model.HeaderText = "Модель";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.Width = 125;
            // 
            // Number
            // 
            Number.HeaderText = "Номер";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
            // 
            // NumberOfSeats
            // 
            NumberOfSeats.HeaderText = "Кількість місць";
            NumberOfSeats.MinimumWidth = 6;
            NumberOfSeats.Name = "NumberOfSeats";
            NumberOfSeats.Width = 125;
            // 
            // Buttons
            // 
            Buttons.HeaderText = "Пасажирський склад";
            Buttons.MinimumWidth = 6;
            Buttons.Name = "Buttons";
            Buttons.Resizable = DataGridViewTriState.True;
            Buttons.Text = "Переглянути";
            Buttons.UseColumnTextForButtonValue = true;
            Buttons.Width = 175;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 230;
            // 
            // lblAirportInfoAboout
            // 
            lblAirportInfoAboout.AutoSize = true;
            lblAirportInfoAboout.Location = new Point(61, 38);
            lblAirportInfoAboout.Name = "lblAirportInfoAboout";
            lblAirportInfoAboout.Size = new Size(154, 124);
            lblAirportInfoAboout.TabIndex = 10;
            lblAirportInfoAboout.Text = "[Координати]\r\n[Адреса]\r\n[Код]\r\n\r\n";
            // 
            // button2
            // 
            button2.Location = new Point(501, 851);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(280, 88);
            button2.TabIndex = 11;
            button2.Text = "Видалити літак";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RemoveAircraft;
            // 
            // Column5
            // 
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // AirportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(lblAirportInfoAboout);
            Controls.Add(dataGridView);
            Controls.Add(lblAirportName);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AirportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += AirportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lblAirportName;
        private DataGridView dataGridView;
        private Label lblAirportInfoAboout;
        private Button button2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn NumberOfSeats;
        private DataGridViewButtonColumn Buttons;
        private DataGridViewTextBoxColumn Type;
    }
}