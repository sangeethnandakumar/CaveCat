using CaveCat.Interpreter.Components;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CaveCat_IDE
{
    public partial class ScriptInterface : Form
    {
        public string TempFile { get; set; } = AppDomain.CurrentDomain.BaseDirectory + @"\temp.cat";

        public ScriptInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var text = File.ReadAllText(TempFile);
                ScriptIDE.Text = text;
            }
            catch (Exception ex)
            {
            }
        }

        public void HighlightLine(string code, Color color)
        {
            ResetEditor();
            ScriptIDE.Invoke((Action)(() =>
            {
                var startIndex = ScriptIDE.Text.IndexOf(code);
                if (startIndex != -1)
                {
                    ScriptIDE.Select(startIndex, code.Length);
                    ScriptIDE.SelectionBackColor = color;
                    ScriptIDE.Select(0, 0);
                }
            }));
        }

        public void WriteLog(Output log)
        {
            switch (log.Type)
            {
                case MessageType.STARTED:
                    Logs.ForeColor = Color.Green;
                    Logs.Items.Add(log.Message);
                    Status.Text = "Started";
                    Logs.BackColor = Color.LightGreen;
                    StatusPane.BackColor = Color.Orange;
                    break;
                case MessageType.COMPLETE:
                    Logs.ForeColor = Color.Green;
                    Logs.Items.Add(log.Message);
                    Status.Text = "Completed";
                    StatusPane.BackColor = Color.SeaGreen;
                    Logs.BackColor = Color.White;
                    ResetEditor();
                    break;
                case MessageType.ACTION:
                    HighlightLine(log.ExecutionInfo.Code, Color.Yellow);
                    Logs.ForeColor = Color.Black;
                    Logs.BackColor = Color.White;
                    Logs.Items.Add(log.Message);
                    break;

                case MessageType.INFO:
                    HighlightLine(log.ExecutionInfo.Code, Color.Yellow);
                    Logs.ForeColor = Color.Aqua;
                    Logs.BackColor = Color.White;
                    Logs.Items.Add(log.Message);
                    break;
                case MessageType.WARNING:
                    HighlightLine(log.ExecutionInfo.Code, Color.DarkGoldenrod);
                    Logs.ForeColor = Color.Gold;
                    Logs.BackColor = Color.White;
                    Logs.Items.Add(log.Message);
                    break;
                case MessageType.ERROR:
                    HighlightLine(log.ExecutionInfo.Code, Color.PaleVioletRed);
                    Logs.ForeColor = Color.Red;
                    Logs.BackColor = Color.White;
                    Logs.Items.Add(log.Message);
                    break;
            }
            int visibleItems = Logs.ClientSize.Height / Logs.ItemHeight;
            Logs.TopIndex = Math.Max(Logs.Items.Count - visibleItems + 1, 0);
        }

        public void ResetEditor()
        {
            ScriptIDE.Invoke((Action)(() =>
            {
                ScriptIDE.Select(0, ScriptIDE.TextLength);
                ScriptIDE.SelectionBackColor = Color.White;
                ScriptIDE.Select(0, 0);
            }));
        }


        private void CLIRunner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = @"D:\Sources\CaveCat\CaveCat IDE\CaveCat.CLI\bin\Debug\net6.0\CaveCat.CLI.exe";
                myProcess.StartInfo.Arguments = $"\"{TempFile}\"";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.Start();

                string log;
                while ((log = myProcess.StandardOutput.ReadLine()) != null)
                {
                    try
                    {
                        var output = JsonConvert.DeserializeObject<Output>(log);
                        Logs.Invoke((Action)(() =>
                        {
                            WriteLog(output);
                        }));
                    }
                    catch (Exception ex)
                    {

                    }
                }
                myProcess.WaitForExit();
            }
            catch (Exception ex)
            {

            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Status.Text = "Ready";
            StatusPane.BackColor = Color.SeaGreen;

            Logs.Items.Clear();
            //Create a local CatCave script (*cat)
            TempFile = AppDomain.CurrentDomain.BaseDirectory + @"\temp.cat";
            File.WriteAllText(TempFile, ScriptIDE.Text);
            CLIRunner.RunWorkerAsync();
        }

        private void XPath_Click(object sender, EventArgs e)
        {
            var xPathBuilder = new XPath_Builder();
            xPathBuilder.ShowDialog();
            var xPath = xPathBuilder.XPath;
            try
            {
                ScriptIDE.SelectionStart += ScriptIDE.SelectionLength;
                ScriptIDE.SelectionLength = 0;
                ScriptIDE.SelectedText = xPath;
            }
            catch (Exception ex) { }         
        }
    }
}
