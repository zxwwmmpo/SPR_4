namespace SPR_4
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            numericUpDownCount = new NumericUpDown();
            numericUpDownYear = new NumericUpDown();
            numericUpDownYearDown = new NumericUpDown();
            numericUpDownMinCount = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinCount).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dataGridView1.Location = new Point(6, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(679, 432);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "год";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "кол-во (A)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "изменение на (+15% - B)";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "A-C";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "A>C ?";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(714, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(814, 14);
            numericUpDownCount.Maximum = new decimal(new int[] { 14999, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(91, 27);
            numericUpDownCount.TabIndex = 2;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(814, 113);
            numericUpDownYear.Maximum = new decimal(new int[] { 14999, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(91, 27);
            numericUpDownYear.TabIndex = 3;
            numericUpDownYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // numericUpDownYearDown
            // 
            numericUpDownYearDown.Location = new Point(814, 47);
            numericUpDownYearDown.Maximum = new decimal(new int[] { 14999, 0, 0, 0 });
            numericUpDownYearDown.Name = "numericUpDownYearDown";
            numericUpDownYearDown.Size = new Size(91, 27);
            numericUpDownYearDown.TabIndex = 4;
            // 
            // numericUpDownMinCount
            // 
            numericUpDownMinCount.Location = new Point(814, 80);
            numericUpDownMinCount.Maximum = new decimal(new int[] { 14999, 0, 0, 0 });
            numericUpDownMinCount.Name = "numericUpDownMinCount";
            numericUpDownMinCount.Size = new Size(91, 27);
            numericUpDownMinCount.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(921, 18);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 6;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(922, 47);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 7;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(922, 80);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 8;
            label3.Text = "C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownMinCount);
            Controls.Add(numericUpDownYearDown);
            Controls.Add(numericUpDownYear);
            Controls.Add(numericUpDownCount);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private NumericUpDown numericUpDownCount;
        private NumericUpDown numericUpDownYear;
        private NumericUpDown numericUpDownYearDown;
        private NumericUpDown numericUpDownMinCount;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}