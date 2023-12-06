namespace Project_OOP.Views
{
    partial class PilotForm
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
            txtPilotName = new TextBox();
            txtPilotAge = new TextBox();
            txtPilotExperience = new TextBox();
            cbxPilotRole = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPilotName
            // 
            txtPilotName.Location = new Point(201, 114);
            txtPilotName.MaxLength = 50;
            txtPilotName.Name = "txtPilotName";
            txtPilotName.PlaceholderText = "Ім'я";
            txtPilotName.Size = new Size(401, 27);
            txtPilotName.TabIndex = 0;
            // 
            // txtPilotAge
            // 
            txtPilotAge.Location = new Point(201, 162);
            txtPilotAge.Name = "txtPilotAge";
            txtPilotAge.PlaceholderText = "Вік";
            txtPilotAge.Size = new Size(401, 27);
            txtPilotAge.TabIndex = 1;
            txtPilotAge.KeyPress += txbAge_KeyPress;
            // 
            // txtPilotExperience
            // 
            txtPilotExperience.Location = new Point(201, 210);
            txtPilotExperience.Name = "txtPilotExperience";
            txtPilotExperience.PlaceholderText = "Досвід";
            txtPilotExperience.Size = new Size(401, 27);
            txtPilotExperience.TabIndex = 2;
            txtPilotExperience.KeyPress += txbExpirience_KeyPress;
            // 
            // cbxPilotRole
            // 
            cbxPilotRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPilotRole.FormattingEnabled = true;
            cbxPilotRole.Location = new Point(201, 258);
            cbxPilotRole.Name = "cbxPilotRole";
            cbxPilotRole.Size = new Size(401, 28);
            cbxPilotRole.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(258, 334);
            button1.Name = "button1";
            button1.Size = new Size(284, 46);
            button1.TabIndex = 4;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCreatePilot_Click;
            // 
            // PilotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 461);
            Controls.Add(button1);
            Controls.Add(cbxPilotRole);
            Controls.Add(txtPilotExperience);
            Controls.Add(txtPilotAge);
            Controls.Add(txtPilotName);
            Name = "PilotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PilotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPilotName;
        private TextBox txtPilotAge;
        private TextBox txtPilotExperience;
        private ComboBox cbxPilotRole;
        private Button button1;
    }
}