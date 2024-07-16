namespace MGR
{
    partial class Redactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redactor));
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            trackBar1 = new TrackBar();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(251, 398);
            button1.Name = "button1";
            button1.Size = new Size(127, 30);
            button1.TabIndex = 0;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 398);
            button2.Name = "button2";
            button2.Size = new Size(239, 30);
            button2.TabIndex = 0;
            button2.Text = "Применить изменения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 435);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Location = new Point(6, 338);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(372, 54);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Когда это произошло?";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(3, 19);
            dateTimePicker1.MaxDate = new DateTime(2024, 7, 15, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(366, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2024, 7, 15, 0, 0, 0, 0);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Location = new Point(6, 279);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(372, 53);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Сколько в минутах длилась мигрень? ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 30);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "минут";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "часов";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(199, 22);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(123, 23);
            numericUpDown2.TabIndex = 0;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 22);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(142, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Location = new Point(6, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 183);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Что предшествовало вашей боли?";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(366, 161);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(trackBar1);
            groupBox2.Location = new Point(6, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выразите в баллах от 1 до 10, насколько боль была сильной";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(3, 22);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(366, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 1;
            // 
            // Redactor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 457);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Redactor";
            Text = "Редактор";
            Load += Redactor_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private TrackBar trackBar1;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBox5;
        private DateTimePicker dateTimePicker1;
    }
}