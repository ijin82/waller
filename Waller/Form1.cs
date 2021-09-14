using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private String taskName = "Waller_SetWallpaperTask";
        private decimal taskMinutes = 15;
        private string wallerIni = "\\Waller.ini";

        [DllImport("user32.dll", SetLastError = true)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        private string exeFilePath = "";
        private string exeFileFolderPath = "";

        public Form1()
        {
            InitializeComponent();

            this.exeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            this.exeFileFolderPath = System.IO.Path.GetDirectoryName(this.exeFilePath);
            this.wallerIni = this.exeFileFolderPath + this.wallerIni;

            INIManager manager = new INIManager(this.wallerIni);

            try
            {
                textBox_path.Text = manager.GetPrivateString("main", "path");
                TextBox_mask.Text = manager.GetPrivateString("main", "mask");
                NumericUpDown_minutes.Value = Convert.ToDecimal(manager.GetPrivateString("main", "minutes"));
                this.SetStatus(".ini Config loaded");

                String randomWall = this.getRandomWallFile();
                if (randomWall == "")
                    this.toolStripStatusLabel1.Text = "Random wallpaper NOT found";
                else
                    this.toolStripStatusLabel1.Text = "Random wallpaper found: " + randomWall;
            } catch (Exception)
            {
                this.SetStatus(".ini Config NOT loaded");
                this.textBox_path.Text = "C:\\";
                this.TextBox_mask.Text = "*.jpg";
                this.toolStripStatusLabel1.Text = "Random wallpaper NOT found";
            }

        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            _ = folderBrowserDialog1.ShowDialog();
            textBox_path.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            INIManager manager = new INIManager(this.wallerIni);

            manager.WritePrivateString("main", "path", textBox_path.Text);
            manager.WritePrivateString("main", "mask", TextBox_mask.Text);
            manager.WritePrivateString("main", "minutes", Convert.ToString(NumericUpDown_minutes.Value));

            this.SetStatus(".ini Config saved");

            String randomWall = this.getRandomWallFile();
            if (randomWall == "")
                this.toolStripStatusLabel1.Text = "Random wallpaper NOT found";
            else
                this.toolStripStatusLabel1.Text = "Random wallpaper found: " + randomWall;
        }

        private void button_task_down_Click(object sender, EventArgs e)
        {
            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                try
                {
                    // Remove the task if exists
                    ts.RootFolder.DeleteTask(this.taskName);
                }
                catch (Exception) { }

                this.toolStripStatusLabel1.Text = "Removed task, named \""  + this.taskName + "\"";
            }
        }

        private void button_task_up_Click(object sender, EventArgs e)
        {
            // task is set status message
            this.toolStripStatusLabel1.Text = this.exeFilePath;

            INIManager manager = new INIManager(this.wallerIni);
            try
            {
                this.taskMinutes = Convert.ToDecimal(manager.GetPrivateString("main", "minutes"));
            }
            catch (Exception)
            {
                this.toolStripStatusLabel1.Text = "Can't set up task, save config first";
                return;
            }

            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                try
                {
                    // Remove the task if exists
                    ts.RootFolder.DeleteTask(this.taskName);
                }
                catch (Exception) { }

                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Sets random wallpaper from specified folder";

                DailyTrigger dt = new DailyTrigger { DaysInterval = 1 };
                dt.Repetition.Interval = TimeSpan.FromMinutes(Convert.ToDouble(this.taskMinutes));

                // Create a trigger that will fire the task at this time every other day
                td.Triggers.Add(dt);

                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction(this.exeFilePath, "--set-wall", this.exeFileFolderPath));

                //td.

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(this.taskName, td);

                this.toolStripStatusLabel1.Text = "Created task, named \"" + this.taskName + "\"";
            }
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

        private string getRandomWallFile()
        {
            INIManager manager = new INIManager(this.wallerIni);
            String path = "C:\\";
            String mask = "*.jpg";
            Random rnd = new Random();

            try
            {
                path = manager.GetPrivateString("main", "path");
                mask = manager.GetPrivateString("main", "mask");
            }
            catch (Exception e)
            {
                return "";
            }

            if (!Directory.Exists(path)) return "";

            string[] fileEntries = Directory.GetFiles(path, mask);
            if (fileEntries.Length < 1) return "";

            int index = rnd.Next(fileEntries.Length);

            return fileEntries[index];
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        public string setRandomWallpaper()
        {
            String randomWall = this.getRandomWallFile();

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, randomWall, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            return randomWall;
        }

        private void button_set_rand_Click(object sender, EventArgs e)
        {
            String randomWall = this.setRandomWallpaper();

            this.toolStripStatusLabel1.Text = "Wallpaper set: " + randomWall;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
