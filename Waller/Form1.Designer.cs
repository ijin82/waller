
namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.TextBox_mask = new System.Windows.Forms.TextBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_task_up = new System.Windows.Forms.Button();
            this.button_task_down = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.NumericUpDown_minutes = new System.Windows.Forms.NumericUpDown();
            this.label_status = new System.Windows.Forms.Label();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Another simple wallpaper rotator for Windows 2021";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wallpapers folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Files mask (Ex.: *.jpg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rotation timer (minutes)";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 42);
            this.textBox_path.Name = "textBox_path";
            //this.textBox_path.PlaceholderText = "C:\\Some\\Folder\\With\\Wallpapers";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(404, 35);
            this.textBox_path.TabIndex = 4;
            // 
            // TextBox_mask
            // 
            this.TextBox_mask.Location = new System.Drawing.Point(13, 114);
            this.TextBox_mask.Name = "TextBox_mask";
            //this.TextBox_mask.PlaceholderText = "*.jpg";
            this.TextBox_mask.Size = new System.Drawing.Size(174, 35);
            this.TextBox_mask.TabIndex = 1;
            this.TextBox_mask.Text = "*.jpg";
            this.TextBox_mask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_mask.TextChanged += new System.EventHandler(this.TextBox_mask_TextChanged);
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(423, 42);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(149, 35);
            this.btn_folder.TabIndex = 4;
            this.btn_folder.Text = "Choose";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(13, 175);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(257, 39);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save Settings";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_task_up
            // 
            this.button_task_up.Location = new System.Drawing.Point(13, 237);
            this.button_task_up.Name = "button_task_up";
            this.button_task_up.Size = new System.Drawing.Size(258, 39);
            this.button_task_up.TabIndex = 5;
            this.button_task_up.Text = "Create task in scheduler";
            this.button_task_up.UseVisualStyleBackColor = true;
            this.button_task_up.Click += new System.EventHandler(this.button_task_up_Click);
            // 
            // button_task_down
            // 
            this.button_task_down.Location = new System.Drawing.Point(314, 237);
            this.button_task_down.Name = "button_task_down";
            this.button_task_down.Size = new System.Drawing.Size(258, 39);
            this.button_task_down.TabIndex = 6;
            this.button_task_down.Text = "Remove task in scheduler";
            this.button_task_down.UseVisualStyleBackColor = true;
            this.button_task_down.Click += new System.EventHandler(this.button_task_down_Click);
            // 
            // NumericUpDown_minutes
            // 
            this.NumericUpDown_minutes.Location = new System.Drawing.Point(262, 114);
            this.NumericUpDown_minutes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown_minutes.Name = "NumericUpDown_minutes";
            this.NumericUpDown_minutes.Size = new System.Drawing.Size(154, 35);
            this.NumericUpDown_minutes.TabIndex = 3;
            this.NumericUpDown_minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_minutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumericUpDown_minutes.ValueChanged += new System.EventHandler(this.NumericUpDown_minutes_ValueChanged);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(314, 179);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 30);
            this.label_status.TabIndex = 12;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // timer_status
            // 
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.NumericUpDown_minutes);
            this.Controls.Add(this.button_task_down);
            this.Controls.Add(this.button_task_up);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.TextBox_mask);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waller";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox TextBox_mask;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_task_up;
        private System.Windows.Forms.Button button_task_down;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown NumericUpDown_minutes;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Timer timer_status;
    }
}

