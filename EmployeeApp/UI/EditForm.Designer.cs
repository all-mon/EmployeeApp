namespace EmployeeApp
{
    partial class EditForm
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
            panel1 = new Panel();
            label1 = new Label();
            FullNameTextBox = new TextBox();
            birthDateTimePicker = new DateTimePicker();
            genderComboBox = new ComboBox();
            SaveButton = new Button();
            EmployeeIdLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "Редактирование";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(12, 117);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "ФИО";
            FullNameTextBox.Size = new Size(378, 27);
            FullNameTextBox.TabIndex = 1;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(13, 164);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(115, 27);
            birthDateTimePicker.TabIndex = 2;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Мужской", "Женский" });
            genderComboBox.Location = new Point(13, 213);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(182, 28);
            genderComboBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(66, 245, 129);
            SaveButton.Location = new Point(283, 390);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(107, 48);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // EmployeeIdLabel
            // 
            EmployeeIdLabel.AutoSize = true;
            EmployeeIdLabel.Location = new Point(18, 280);
            EmployeeIdLabel.Name = "EmployeeIdLabel";
            EmployeeIdLabel.Size = new Size(52, 20);
            EmployeeIdLabel.TabIndex = 5;
            EmployeeIdLabel.Text = "EmpId";
            EmployeeIdLabel.Visible = false;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(EmployeeIdLabel);
            Controls.Add(SaveButton);
            Controls.Add(genderComboBox);
            Controls.Add(birthDateTimePicker);
            Controls.Add(FullNameTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditForm";
            Text = "Редактирование";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button SaveButton;
        public TextBox FullNameTextBox;
        public DateTimePicker birthDateTimePicker;
        public ComboBox genderComboBox;
        public Label EmployeeIdLabel;
    }
}