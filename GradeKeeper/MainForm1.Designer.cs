namespace GradeKeeper
{
    partial class MainForm1
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
            this.components = new System.ComponentModel.Container();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextbox = new System.Windows.Forms.TextBox();
            this.gradeBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.studentsTabPage = new System.Windows.Forms.TabPage();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTabPage = new System.Windows.Forms.TabPage();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectedStudent = new System.Windows.Forms.GroupBox();
            this.studentName = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBookBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.studentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.selectedStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(13, 22);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(26, 13);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "&File:";
            this.FileNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FileNameTextbox
            // 
            this.FileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradeBookBindingSource, "FileName", true));
            this.FileNameTextbox.Location = new System.Drawing.Point(45, 19);
            this.FileNameTextbox.Name = "FileNameTextbox";
            this.FileNameTextbox.ReadOnly = true;
            this.FileNameTextbox.Size = new System.Drawing.Size(696, 20);
            this.FileNameTextbox.TabIndex = 1;
            // 
            // gradeBookBindingSource
            // 
            this.gradeBookBindingSource.DataSource = typeof(GradeKeeper.GradeBook);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileButton.Location = new System.Drawing.Point(747, 17);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(37, 23);
            this.SelectFileButton.TabIndex = 2;
            this.SelectFileButton.Text = "...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "JSON Files (.json)|*.json";
            this.OpenFileDialog.Title = "Select a Grade Keeper File";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.studentsTabPage);
            this.tabControl1.Controls.Add(this.coursesTabPage);
            this.tabControl1.Location = new System.Drawing.Point(16, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 381);
            this.tabControl1.TabIndex = 5;
            // 
            // studentsTabPage
            // 
            this.studentsTabPage.Controls.Add(this.selectedStudent);
            this.studentsTabPage.Controls.Add(this.studentsListBox);
            this.studentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.studentsTabPage.Name = "studentsTabPage";
            this.studentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsTabPage.Size = new System.Drawing.Size(768, 355);
            this.studentsTabPage.TabIndex = 0;
            this.studentsTabPage.Text = "Students";
            this.studentsTabPage.UseVisualStyleBackColor = true;
            this.studentsTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentsListBox.DataSource = this.studentsBindingSource1;
            this.studentsListBox.DisplayMember = "Name";
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(7, 7);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(153, 342);
            this.studentsListBox.TabIndex = 0;
            this.studentsListBox.ValueMember = "ID";
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.gradeBookBindingSource;
            // 
            // coursesTabPage
            // 
            this.coursesTabPage.Location = new System.Drawing.Point(4, 22);
            this.coursesTabPage.Name = "coursesTabPage";
            this.coursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.coursesTabPage.Size = new System.Drawing.Size(768, 355);
            this.coursesTabPage.TabIndex = 1;
            this.coursesTabPage.Text = "Courses";
            this.coursesTabPage.UseVisualStyleBackColor = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.gradeBookBindingSource;
            // 
            // selectedStudent
            // 
            this.selectedStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedStudent.Controls.Add(this.studentIDTextBox);
            this.selectedStudent.Controls.Add(this.studentIDLabel);
            this.selectedStudent.Controls.Add(this.studentNameTextBox);
            this.selectedStudent.Controls.Add(this.studentName);
            this.selectedStudent.Location = new System.Drawing.Point(167, 7);
            this.selectedStudent.Name = "selectedStudent";
            this.selectedStudent.Size = new System.Drawing.Size(597, 342);
            this.selectedStudent.TabIndex = 1;
            this.selectedStudent.TabStop = false;
            this.selectedStudent.Text = "groupBox1";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(6, 63);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(38, 13);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Name:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Name", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(5, 79);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(6, 24);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(21, 13);
            this.studentIDLabel.TabIndex = 2;
            this.studentIDLabel.Text = "ID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "ID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(7, 41);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.FileNameTextbox);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "MainForm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gradeBookBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.studentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.selectedStudent.ResumeLayout(false);
            this.selectedStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextbox;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage studentsTabPage;
        private System.Windows.Forms.TabPage coursesTabPage;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.BindingSource gradeBookBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.GroupBox selectedStudent;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label studentName;
    }
}

