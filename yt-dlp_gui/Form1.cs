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

namespace yt_dlp_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string url = String.Empty;

        private void Search_Button_Click(object sender, EventArgs e)
        {
            url = Search_TextBox.Text;
            //label1.Text = GetTitle(url);
            Search(url);
        }

        private void Search(string url)
        {
            radioButton_best.Checked = true;
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "C:\\Users\\hsu86\\yt-dlp.exe";
                p.StartInfo.Arguments = url + " --no-playlist -F --encoding \"UTF-8\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                p.WaitForExit();
                List<String> opt_list = new List<string>();
                int count = 0;
                while (!p.StandardOutput.EndOfStream)
                {
                    String tmp = p.StandardOutput.ReadLine();
                    if (++count > 8)
                    {
                        Search_listBox.Items.Add(tmp);
                        //Search_comboBox.Items.Add(tmp);
                        //opt_list.Add(p.StandardOutput.ReadLine());
                    }
                }
            }
        }

        private void Download_Button_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                String para = Search_TextBox.Text;
                if (radioButton_best.Checked)
                {
                    para += " -f bestaudio+bestvideo --merge-output-format mkv";
                }
                else if (radioButton_bestAudio.Checked)
                {
                    para += " -f bestaudio -x --audio-format best --audio-quality 0";

                }
                else
                {
                    para += " -f " + Search_listBox.SelectedItem.ToString().Split(' ')[0];
                }
                para += " --encoding \"UTF-8\" --throttled-rate 100 -N 14 --embed-thumbnail --output D:\\Downloads\\%(title)s.%(ext)s";
                p.StartInfo.FileName = "C:\\Users\\hsu86\\yt-dlp.exe";
                p.StartInfo.Arguments = para;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.StartInfo.RedirectStandardOutput = true;
                //p.OutputDataReceived += OutputDataReceived;
                p.Start();
                //p.BeginOutputReadLine();
                //p.WaitForExit();
                while (!p.StandardOutput.EndOfStream)
                {
                    para += "\n" + p.StandardOutput.ReadLine();
                }
                cmd_richTextBox.Text = para;
            }
        }

        private void Search_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                radioButton_others.Checked = true;
        }
    }
}
