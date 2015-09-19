using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;


namespace toWideScr
{
    public partial class toWideScr : Form
    {
        public toWideScr()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string input; //= "C:/Users/Thomas/Videos/test.mp4";
        string output; //= "C:/Users/Thomas/Videos/testc.mp4";
        string rotation;
        double nullscrWidth; //= 1920;
        double nullscrHeight; //= 1080;
        double inputWidth; //= 320;
        double inputHeight; //= 240;
        double brightness; //= -0.05;
        double boxblur; //= 45;
        double framrate; //= 30;

        private void button_run_click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            input = textBox_Input.Text;

            if (input == "")
            {
                DialogResult noInput = MessageBox.Show("No input source selected.", "Please insert working path.",MessageBoxButtons.OK);
                return;
            }

            output = textBox_Output.Text;
            nullscrWidth = Convert.ToInt16(textBox_nullscrWidth.Text);
            nullscrHeight = Convert.ToInt16(textBox_nullscrHeight.Text);
            framrate = Convert.ToInt16(textBox_fps.Text);
            boxblur = Convert.ToInt16(textBox_boxblur.Text);
            brightness = Convert.ToDouble(textBox_brightness.Text) / 100;

            Process cmdStartInfo = new Process();
            cmdStartInfo.StartInfo.CreateNoWindow = true;
            cmdStartInfo.StartInfo.UseShellExecute = false;
            cmdStartInfo.StartInfo.RedirectStandardOutput = true;
            cmdStartInfo.StartInfo.FileName = "ffprobe.exe";
            cmdStartInfo.StartInfo.Arguments = "-i \"" + input + "\" -print_format json -show_streams";
            cmdStartInfo.Start();
            string streamInfo = cmdStartInfo.StandardOutput.ReadToEnd();
            cmdStartInfo.WaitForExit();

            //http://www.newtonsoft.com/json
            MovieInfo inf = JsonConvert.DeserializeObject<MovieInfo>(streamInfo);
            if (inf.streams == null)
            {
                DialogResult noInput = MessageBox.Show("Wrong input source selected.", "Please insert working file.", MessageBoxButtons.OK);
                return;
            }
            foreach(var value in inf.streams)
            {
                if (value.codec_type == "video")
                {
                    inputWidth = value.width;
                    inputHeight = value.height;
                }
            }

            switch (listBox_Rotation.SelectedIndex)
            {
                case 0:
                    rotation = "";
                    break;
                case 1:
                    rotation = "transpose=1,";
                    double tmpA = inputWidth;
                    inputWidth = inputHeight;
                    inputHeight = tmpA;
                    break;
                case 2:
                    rotation = "transpose=2,";
                    double tmpB = inputWidth;
                    inputWidth = inputHeight;
                    inputHeight = tmpB;
                    break;
                case 3:
                    rotation = "transpose=1,transpose=1,";
                    break;
                default:
                    break;
            }

            if (File.Exists(output))
            {
                DialogResult ask = MessageBox.Show("Would you like to replace the existing file?", "Confirm File Replace", MessageBoxButtons.YesNo);
                if (ask == DialogResult.No) return;
            }

            double middenWidth = ((inputWidth / inputHeight) * nullscrHeight);
            double middenHeight = nullscrHeight;
            double middenX = (nullscrWidth - middenWidth) / 2;
            double linrechWidth = nullscrWidth;
            double linrechHeight = ((inputHeight / inputWidth) * nullscrWidth);
            double linrechY = (linrechHeight - nullscrHeight) / 2;

            string exe =
                "-y -i \"" + input + "\" "
                + "-metadata:s:v:0 rotate=0 "
                + "-filter_complex \" "
                    + "nullsrc=size=" + nullscrWidth + "x" + nullscrHeight + " [base]; "
                    + "[0:v] setpts=PTS-STARTPTS, " + rotation + " scale=" + middenWidth + ":" + middenHeight + " [midden]; "
                    + "[0:v] setpts=PTS-STARTPTS, " + rotation + " scale=" + linrechWidth + ":" + linrechHeight
                    + ", crop=" + nullscrWidth + ":" + nullscrHeight + ":0:" + linrechY + ", boxblur=" + boxblur + ", eq=brightness=" + brightness + " [linksrechts]; "
                    + "[base][linksrechts] overlay=shortest=1 [tmp1]; "
                    + "[tmp1][midden] overlay=shortest=1:x=" + middenX + " "
                + " \" "
                + " -r " + framrate + " \"" + output + "\" ";

            Process cmdProcess = new Process();
            //cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.FileName = "ffmpeg.exe";
            cmdProcess.StartInfo.Arguments = exe;
            cmdProcess.Start();
            cmdStartInfo.WaitForExit();
        }

        private void button_input_click(object sender, EventArgs e)
        {
            if (openFileDialog_input.ShowDialog() == DialogResult.OK)
            {
                textBox_Input.Text = openFileDialog_input.FileName;
            }
        }

        private void button_output_click(object sender, EventArgs e)
        {
            if (openFileDialog_output.ShowDialog() == DialogResult.OK)
            {
                textBox_Output.Text = openFileDialog_output.FileName;
            }
        }

        private void textBox_Input_DragEnter(object sender, DragEventArgs e)
        {
            var data = e.Data as DataObject;

            foreach (string item in data.GetFileDropList())
            {
                textBox_Input.Text = item;
            }
        }

        private void textBox_Output_DragEnter(object sender, DragEventArgs e)
        {
            /*var data = e.Data as DataObject;

            foreach (string item in data.GetFileDropList())
            {
                textBox_Output.Text = item;
            }*/
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Input.Text.LastIndexOf('.') != -1)
            {
                textBox_Output.Text =
                    textBox_Input.Text.Substring(0, textBox_Input.Text.LastIndexOf('.'))
                    + "_1"
                    + textBox_Input.Text.Substring(textBox_Input.Text.LastIndexOf('.'));
            }
        }

        private void textBox_nullscrWidth_TextChanged(object sender, EventArgs e)
        {
            //Find and extract a number from a string
            textBox_nullscrWidth.Text = System.Text.RegularExpressions.Regex.Match(textBox_nullscrWidth.Text, @"\d+").Value;
        }

        private void textBox_nullscrHeight_TextChanged(object sender, EventArgs e)
        {
            //Find and extract a number from a string
            textBox_nullscrHeight.Text = System.Text.RegularExpressions.Regex.Match(textBox_nullscrHeight.Text, @"\d+").Value;
        }

        private void linkLabel_720P_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_nullscrWidth.Text = "1280";
            textBox_nullscrHeight.Text = "720";
        }

        private void linkLabel_1080P_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_nullscrWidth.Text = "1920";
            textBox_nullscrHeight.Text = "1080";
        }

        private void linkLabel_4K_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_nullscrWidth.Text = "4096";
            textBox_nullscrHeight.Text = "2160";
        }

        private void textBox_brightness_TextChanged(object sender, EventArgs e)
        {
            //Find and extract a number from a string
            if (textBox_brightness.Text != "-")
            {
                textBox_brightness.Text = System.Text.RegularExpressions.Regex.Match(textBox_brightness.Text, @"-?\d+").Value;
            }
        }

        private void textBox_boxblur_TextChanged(object sender, EventArgs e)
        {
            //Find and extract a number from a string
            textBox_boxblur.Text = System.Text.RegularExpressions.Regex.Match(textBox_boxblur.Text, @"\d+").Value;
        }

        private void textBox_fps_TextChanged(object sender, EventArgs e)
        {
            //Find and extract a number from a string
            textBox_fps.Text = System.Text.RegularExpressions.Regex.Match(textBox_fps.Text, @"\d+").Value;
        }
    }

    //http://json2csharp.com/ 
    public class Disposition
    {
        public int @default { get; set; }
        public int dub { get; set; }
        public int original { get; set; }
        public int comment { get; set; }
        public int lyrics { get; set; }
        public int karaoke { get; set; }
        public int forced { get; set; }
        public int hearing_impaired { get; set; }
        public int visual_impaired { get; set; }
        public int clean_effects { get; set; }
        public int attached_pic { get; set; }
    }

    public class Tags
    {
        public string creation_time { get; set; }
        public string language { get; set; }
        public string handler_name { get; set; }
    }

    public class Stream
    {
        public int index { get; set; }
        public string codec_name { get; set; }
        public string codec_long_name { get; set; }
        public string profile { get; set; }
        public string codec_type { get; set; }
        public string codec_time_base { get; set; }
        public string codec_tag_string { get; set; }
        public string codec_tag { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int coded_width { get; set; }
        public int coded_height { get; set; }
        public int has_b_frames { get; set; }
        public string sample_aspect_ratio { get; set; }
        public string display_aspect_ratio { get; set; }
        public string pix_fmt { get; set; }
        public int level { get; set; }
        public string chroma_location { get; set; }
        public int refs { get; set; }
        public string is_avc { get; set; }
        public string nal_length_size { get; set; }
        public string r_frame_rate { get; set; }
        public string avg_frame_rate { get; set; }
        public string time_base { get; set; }
        public int start_pts { get; set; }
        public string start_time { get; set; }
        public int duration_ts { get; set; }
        public string duration { get; set; }
        public string bit_rate { get; set; }
        public string bits_per_raw_sample { get; set; }
        public string nb_frames { get; set; }
        public Disposition disposition { get; set; }
        public Tags tags { get; set; }
        public string sample_fmt { get; set; }
        public string sample_rate { get; set; }
        public int? channels { get; set; }
        public string channel_layout { get; set; }
        public int? bits_per_sample { get; set; }
    }

    public class MovieInfo
    {
        public List<Stream> streams { get; set; }
    }

}
