namespace EmployeeApp
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            FullNameCol = new DataGridViewTextBoxColumn();
            BirthDateCol = new DataGridViewTextBoxColumn();
            GenderCol = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(447, 48);
            label1.TabIndex = 0;
            label1.Text = "Список сотрудников";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FullNameCol, BirthDateCol, GenderCol });
            dataGridView1.Location = new Point(0, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1083, 429);
            dataGridView1.TabIndex = 1;
            // 
            // FullNameCol
            // 
            FullNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullNameCol.HeaderText = "ФИО";
            FullNameCol.MinimumWidth = 6;
            FullNameCol.Name = "FullNameCol";
            FullNameCol.ReadOnly = true;
            // 
            // BirthDateCol
            // 
            BirthDateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BirthDateCol.HeaderText = "Дата рождения";
            BirthDateCol.MinimumWidth = 6;
            BirthDateCol.Name = "BirthDateCol";
            BirthDateCol.ReadOnly = true;
            // 
            // GenderCol
            // 
            GenderCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GenderCol.HeaderText = "Пол";
            GenderCol.MinimumWidth = 6;
            GenderCol.Name = "GenderCol";
            GenderCol.ReadOnly = true;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.BackColor = Color.FromArgb(66, 245, 129);
            AddButton.Location = new Point(720, 585);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(107, 48);
            AddButton.TabIndex = 2;
            AddButton.Text = "Новый";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.BackColor = Color.FromArgb(66, 173, 245);
            EditButton.Location = new Point(840, 585);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(107, 48);
            EditButton.TabIndex = 3;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.BackColor = Color.FromArgb(245, 66, 66);
            DeleteButton.Location = new Point(960, 585);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 48);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 645);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Список сотрудников";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FullNameCol;
        private DataGridViewTextBoxColumn BirthDateCol;
        private DataGridViewTextBoxColumn GenderCol;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
    }
}