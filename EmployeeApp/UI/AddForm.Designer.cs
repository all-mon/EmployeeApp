namespace EmployeeApp
{
    partial class AddForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            FullNameTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            genderComboBox = new ComboBox();
            genderBindingSource = new BindingSource(components);
            SaveButton = new Button();
            employeesBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).BeginInit();
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
            label1.Size = new Size(351, 38);
            label1.TabIndex = 0;
            label1.Text = "Добавление сотрудника";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(12, 117);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "ФИО";
            FullNameTextBox.Size = new Size(378, 27);
            FullNameTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(13, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(13, 213);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(182, 28);
            genderComboBox.TabIndex = 3;
            // 
            // genderBindingSource
            // 
            genderBindingSource.DataSource = typeof(Models.Gender);
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
            // employeesBindingSource
            // 
            employeesBindingSource.DataMember = "Employees";
            employeesBindingSource.DataSource = genderBindingSource;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(SaveButton);
            Controls.Add(genderComboBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(FullNameTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddForm";
            Text = "Добавление";
            Load += AddForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox FullNameTextBox;
        private DateTimePicker dateTimePicker1;
        private ComboBox genderComboBox;
        private Button SaveButton;
        private BindingSource genderBindingSource;
        private BindingSource employeesBindingSource;
    }
}