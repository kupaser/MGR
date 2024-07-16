using MGR.sets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGR
{
    public partial class Redactor : Form
    {
        public Headache Headache;
        public Redactor(Headache headache)
        {
            InitializeComponent();
            this.Headache = headache;
            richTextBox1.Text = headache.Description;
            trackBar1.Value = headache.goals;
            numericUpDown1.Value = headache.Timecount / 60;
            numericUpDown2.Value = headache.Timecount % 60;
            dateTimePicker1.Value = headache.Date;
        }
        public Redactor()
        {
            InitializeComponent();
            this.Headache = new();
        }

        private void Redactor_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == string.Empty)
                {
                    throw new Exception("Поле \"что предшествовало боли\" не может быть пустым");
                }
                Headache.Description = richTextBox1.Text;
                
                Headache.goals = trackBar1.Value;
                Headache.Timecount = (int)(numericUpDown1.Value * 60 + numericUpDown2.Value);
                Headache.Date = dateTimePicker1.Value;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
            }
        }
    }
}
