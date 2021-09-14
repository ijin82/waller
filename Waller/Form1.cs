using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            INIManager manager = new INIManager(".\\Waller.ini");

            try
            {
                textBox_path.Text = manager.GetPrivateString("main", "path");
                TextBox_mask.Text = manager.GetPrivateString("main", "mask");
                NumericUpDown_minutes.Value = Convert.ToDecimal(manager.GetPrivateString("main", "minutes"));
                this.SetStatus(".ini Config loaded");
            } catch (Exception e) {
                this.SetStatus(".ini Config NOT loaded");
                this.textBox_path.Text = "C:\\";
                this.TextBox_mask.Text = "*.jpg";
            }

        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            _ = folderBrowserDialog1.ShowDialog();
            textBox_path.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            INIManager manager = new INIManager(".\\Waller.ini");

            manager.WritePrivateString("main", "path", textBox_path.Text);
            manager.WritePrivateString("main", "mask", TextBox_mask.Text);
            manager.WritePrivateString("main", "minutes", Convert.ToString(NumericUpDown_minutes.Value));

            this.SetStatus(".ini Config saved");
        }

        private void button_task_down_Click(object sender, EventArgs e)
        {

        }

        private void button_task_up_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown_minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_mask_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void SetStatus(String statusText)
        {
            this.label_status.Text = statusText;

            // set timer interval
            this.timer_status.Interval = 3000;
            this.timer_status.Enabled = true;
        }

        private void timer_status_Tick(Object sender, EventArgs e)
        {
            this.label_status.Text = "";
            this.timer_status.Enabled = false;
        }
    }
}
