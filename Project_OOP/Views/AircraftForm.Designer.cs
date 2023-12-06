using System.Windows.Forms;

namespace Project_OOP.Forms
{
    partial class AircraftForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txbNumber = new TextBox();
            dataGridView1 = new DataGridView();
            PersonName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            DisplayRole = new DataGridViewTextBoxColumn();
            txbModel = new TextBox();
            txbNumberOfSeats = new TextBox();
            cbxAircraftTypes = new ComboBox();
            label1 = new Label();
            cbxPersonTypes = new ComboBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txbNumber
            // 
            txbNumber.Location = new Point(153, 253);
            txbNumber.Margin = new Padding(5);
            txbNumber.Name = "txbNumber";
            txbNumber.PlaceholderText = "Номер";
            txbNumber.Size = new Size(467, 38);
            txbNumber.TabIndex = 0;
            txbNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PersonName, Age, DisplayRole });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(58, 71);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(892, 540);
            dataGridView1.TabIndex = 1;
            // 
            // PersonName
            // 
            PersonName.HeaderText = "Ім'я";
            PersonName.MinimumWidth = 6;
            PersonName.Name = "PersonName";
            PersonName.Width = 200;
            // 
            // Age
            // 
            Age.HeaderText = "Вік";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 120;
            // 
            // DisplayRole
            // 
            DisplayRole.HeaderText = "Роль";
            DisplayRole.MinimumWidth = 6;
            DisplayRole.Name = "DisplayRole";
            DisplayRole.Width = 250;
            // 
            // txbModel
            // 
            txbModel.Location = new Point(153, 168);
            txbModel.Margin = new Padding(5);
            txbModel.Name = "txbModel";
            txbModel.PlaceholderText = "Модель";
            txbModel.Size = new Size(467, 38);
            txbModel.TabIndex = 2;
            txbModel.TextAlign = HorizontalAlignment.Center;
            // 
            // txbNumberOfSeats
            // 
            txbNumberOfSeats.Location = new Point(153, 336);
            txbNumberOfSeats.Margin = new Padding(5);
            txbNumberOfSeats.Name = "txbNumberOfSeats";
            txbNumberOfSeats.PlaceholderText = "Кількість місць";
            txbNumberOfSeats.Size = new Size(467, 38);
            txbNumberOfSeats.TabIndex = 3;
            txbNumberOfSeats.TextAlign = HorizontalAlignment.Center;
            txbNumberOfSeats.KeyPress += txbNumberOfSeats_KeyPress;
            // 
            // cbxAircraftTypes
            // 
            cbxAircraftTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAircraftTypes.FormattingEnabled = true;
            cbxAircraftTypes.Location = new Point(153, 82);
            cbxAircraftTypes.Name = "cbxAircraftTypes";
            cbxAircraftTypes.Size = new Size(467, 39);
            cbxAircraftTypes.TabIndex = 4;
            cbxAircraftTypes.SelectedIndexChanged += cbxAircraftTypes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(153, 47);
            label1.Name = "label1";
            label1.Size = new Size(467, 32);
            label1.TabIndex = 5;
            label1.Text = "Тип літака";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxPersonTypes
            // 
            cbxPersonTypes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPersonTypes.FormattingEnabled = true;
            cbxPersonTypes.Location = new Point(321, 699);
            cbxPersonTypes.Name = "cbxPersonTypes";
            cbxPersonTypes.Size = new Size(408, 39);
            cbxPersonTypes.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(321, 761);
            button1.Name = "button1";
            button1.Size = new Size(408, 55);
            button1.TabIndex = 7;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreatePerson;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cbxPersonTypes);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(846, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 934);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пасажирський склад";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(99, 242, 99);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(153, 866);
            button2.Name = "button2";
            button2.Size = new Size(467, 113);
            button2.TabIndex = 9;
            button2.Text = "Створити літак";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CreateAircraft;
            // 
            // AircraftForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1901, 1032);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cbxAircraftTypes);
            Controls.Add(txbNumberOfSeats);
            Controls.Add(txbModel);
            Controls.Add(txbNumber);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AircraftForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додання літаку";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNumber;
        private DataGridView dataGridView1;
        private TextBox txbModel;
        private TextBox txbNumberOfSeats;
        private ComboBox cbxAircraftTypes;
        private Label label1;
        private ComboBox cbxPersonTypes;
        private Button button1;
        private DataGridViewTextBoxColumn PersonName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn DisplayRole;
        private GroupBox groupBox1;
        private Button button2;
    }
}