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

namespace yogurt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=EhJtZtGjWxQ&t=697s");
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            p.StartInfo.Arguments = @"/c start shell:AppsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
