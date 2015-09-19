namespace toWideScr
{
    partial class toWideScr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toWideScr));
            this.button_run = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.openFileDialog_input = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_output = new System.Windows.Forms.OpenFileDialog();
            this.textBox_nullscrWidth = new System.Windows.Forms.TextBox();
            this.textBox_nullscrHeight = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.linkLabel_720P = new System.Windows.Forms.LinkLabel();
            this.linkLabel_1080P = new System.Windows.Forms.LinkLabel();
            this.linkLabel_4K = new System.Windows.Forms.LinkLabel();
            this.textBox_brightness = new System.Windows.Forms.TextBox();
            this.textBox_boxblur = new System.Windows.Forms.TextBox();
            this.textBox_fps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Rotation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(462, 90);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 0;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_click);
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(462, 10);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 23);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_click);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(462, 39);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(75, 23);
            this.button_output.TabIndex = 2;
            this.button_output.Text = "Output";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.AllowDrop = true;
            this.textBox_Input.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Input.Location = new System.Drawing.Point(12, 12);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(444, 20);
            this.textBox_Input.TabIndex = 3;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            this.textBox_Input.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Input_DragEnter);
            // 
            // textBox_Output
            // 
            this.textBox_Output.AllowDrop = true;
            this.textBox_Output.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Output.Location = new System.Drawing.Point(12, 41);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(444, 20);
            this.textBox_Output.TabIndex = 4;
            this.textBox_Output.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Output_DragEnter);
            // 
            // openFileDialog_input
            // 
            this.openFileDialog_input.FileName = "openFileDialog_input";
            this.openFileDialog_input.Filter = resources.GetString("openFileDialog_input.Filter");
            // 
            // openFileDialog_output
            // 
            this.openFileDialog_output.DefaultExt = "mp4";
            this.openFileDialog_output.FileName = "openFileDialog_output";
            // 
            // textBox_nullscrWidth
            // 
            this.textBox_nullscrWidth.Location = new System.Drawing.Point(12, 67);
            this.textBox_nullscrWidth.Name = "textBox_nullscrWidth";
            this.textBox_nullscrWidth.Size = new System.Drawing.Size(49, 20);
            this.textBox_nullscrWidth.TabIndex = 5;
            this.textBox_nullscrWidth.Text = "1920";
            this.textBox_nullscrWidth.TextChanged += new System.EventHandler(this.textBox_nullscrWidth_TextChanged);
            // 
            // textBox_nullscrHeight
            // 
            this.textBox_nullscrHeight.Location = new System.Drawing.Point(87, 67);
            this.textBox_nullscrHeight.Name = "textBox_nullscrHeight";
            this.textBox_nullscrHeight.Size = new System.Drawing.Size(49, 20);
            this.textBox_nullscrHeight.TabIndex = 6;
            this.textBox_nullscrHeight.Text = "1080";
            this.textBox_nullscrHeight.TextChanged += new System.EventHandler(this.textBox_nullscrHeight_TextChanged);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(67, 70);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 7;
            this.X.Text = "X";
            // 
            // linkLabel_720P
            // 
            this.linkLabel_720P.AutoSize = true;
            this.linkLabel_720P.Location = new System.Drawing.Point(142, 70);
            this.linkLabel_720P.Name = "linkLabel_720P";
            this.linkLabel_720P.Size = new System.Drawing.Size(32, 13);
            this.linkLabel_720P.TabIndex = 8;
            this.linkLabel_720P.TabStop = true;
            this.linkLabel_720P.Text = "720P";
            this.linkLabel_720P.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_720P_LinkClicked);
            // 
            // linkLabel_1080P
            // 
            this.linkLabel_1080P.AutoSize = true;
            this.linkLabel_1080P.Location = new System.Drawing.Point(180, 70);
            this.linkLabel_1080P.Name = "linkLabel_1080P";
            this.linkLabel_1080P.Size = new System.Drawing.Size(38, 13);
            this.linkLabel_1080P.TabIndex = 9;
            this.linkLabel_1080P.TabStop = true;
            this.linkLabel_1080P.Text = "1080P";
            this.linkLabel_1080P.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_1080P_LinkClicked);
            // 
            // linkLabel_4K
            // 
            this.linkLabel_4K.AutoSize = true;
            this.linkLabel_4K.Location = new System.Drawing.Point(224, 70);
            this.linkLabel_4K.Name = "linkLabel_4K";
            this.linkLabel_4K.Size = new System.Drawing.Size(20, 13);
            this.linkLabel_4K.TabIndex = 10;
            this.linkLabel_4K.TabStop = true;
            this.linkLabel_4K.Text = "4K";
            this.linkLabel_4K.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_4K_LinkClicked);
            // 
            // textBox_brightness
            // 
            this.textBox_brightness.Location = new System.Drawing.Point(122, 93);
            this.textBox_brightness.Name = "textBox_brightness";
            this.textBox_brightness.Size = new System.Drawing.Size(50, 20);
            this.textBox_brightness.TabIndex = 11;
            this.textBox_brightness.Text = "-5";
            this.textBox_brightness.TextChanged += new System.EventHandler(this.textBox_brightness_TextChanged);
            // 
            // textBox_boxblur
            // 
            this.textBox_boxblur.Location = new System.Drawing.Point(230, 92);
            this.textBox_boxblur.Name = "textBox_boxblur";
            this.textBox_boxblur.Size = new System.Drawing.Size(50, 20);
            this.textBox_boxblur.TabIndex = 12;
            this.textBox_boxblur.Text = "45";
            this.textBox_boxblur.TextChanged += new System.EventHandler(this.textBox_boxblur_TextChanged);
            // 
            // textBox_fps
            // 
            this.textBox_fps.Location = new System.Drawing.Point(277, 67);
            this.textBox_fps.Name = "textBox_fps";
            this.textBox_fps.Size = new System.Drawing.Size(47, 20);
            this.textBox_fps.TabIndex = 13;
            this.textBox_fps.Text = "30";
            this.textBox_fps.TextChanged += new System.EventHandler(this.textBox_fps_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Brightness [-100,100]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Box Blur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "fps";
            // 
            // listBox_Rotation
            // 
            this.listBox_Rotation.FormattingEnabled = true;
            this.listBox_Rotation.Items.AddRange(new object[] {
            "No rotation",
            "90° Clockwise",
            "90° Counterclockwise",
            "180° Rotation"});
            this.listBox_Rotation.Location = new System.Drawing.Point(330, 67);
            this.listBox_Rotation.Name = "listBox_Rotation";
            this.listBox_Rotation.Size = new System.Drawing.Size(126, 43);
            this.listBox_Rotation.TabIndex = 17;
            this.listBox_Rotation.SelectedIndex = 0;
            // 
            // toWideScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 125);
            this.Controls.Add(this.listBox_Rotation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_fps);
            this.Controls.Add(this.textBox_boxblur);
            this.Controls.Add(this.textBox_brightness);
            this.Controls.Add(this.linkLabel_4K);
            this.Controls.Add(this.linkLabel_1080P);
            this.Controls.Add(this.linkLabel_720P);
            this.Controls.Add(this.X);
            this.Controls.Add(this.textBox_nullscrHeight);
            this.Controls.Add(this.textBox_nullscrWidth);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button_run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "toWideScr";
            this.Text = "toWideScr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.OpenFileDialog openFileDialog_input;
        private System.Windows.Forms.OpenFileDialog openFileDialog_output;
        private System.Windows.Forms.TextBox textBox_nullscrWidth;
        private System.Windows.Forms.TextBox textBox_nullscrHeight;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.LinkLabel linkLabel_720P;
        private System.Windows.Forms.LinkLabel linkLabel_1080P;
        private System.Windows.Forms.LinkLabel linkLabel_4K;
        private System.Windows.Forms.TextBox textBox_brightness;
        private System.Windows.Forms.TextBox textBox_boxblur;
        private System.Windows.Forms.TextBox textBox_fps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Rotation;
    }
}

