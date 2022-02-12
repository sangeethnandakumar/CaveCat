namespace CaveCat_IDE
{
    partial class ScriptInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptInterface));
            this.CLIRunner = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Run = new System.Windows.Forms.Button();
            this.StatusPane = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.XPath = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Logs = new System.Windows.Forms.ListBox();
            this.ScriptIDE = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StatusPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CLIRunner
            // 
            this.CLIRunner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CLIRunner_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.executeToolStripMenuItem.Text = "Run";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.XPath);
            this.panel1.Controls.Add(this.Run);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 44);
            this.panel1.TabIndex = 5;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(12, 6);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(108, 30);
            this.Run.TabIndex = 2;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // StatusPane
            // 
            this.StatusPane.BackColor = System.Drawing.Color.SeaGreen;
            this.StatusPane.Controls.Add(this.Status);
            this.StatusPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusPane.Location = new System.Drawing.Point(0, 780);
            this.StatusPane.Name = "StatusPane";
            this.StatusPane.Size = new System.Drawing.Size(1224, 30);
            this.StatusPane.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(12, 7);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(42, 16);
            this.Status.TabIndex = 0;
            this.Status.Text = "Ready";
            // 
            // XPath
            // 
            this.XPath.Location = new System.Drawing.Point(126, 6);
            this.XPath.Name = "XPath";
            this.XPath.Size = new System.Drawing.Size(135, 30);
            this.XPath.TabIndex = 3;
            this.XPath.Text = "XPath Builder";
            this.XPath.UseVisualStyleBackColor = true;
            this.XPath.Click += new System.EventHandler(this.XPath_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ScriptIDE);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Logs);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 742);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 3;
            // 
            // Logs
            // 
            this.Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Logs.FormattingEnabled = true;
            this.Logs.ItemHeight = 16;
            this.Logs.Location = new System.Drawing.Point(0, 0);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(1224, 471);
            this.Logs.TabIndex = 2;
            // 
            // ScriptIDE
            // 
            this.ScriptIDE.BackColor = System.Drawing.Color.White;
            this.ScriptIDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptIDE.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptIDE.ForeColor = System.Drawing.Color.Black;
            this.ScriptIDE.Location = new System.Drawing.Point(0, 0);
            this.ScriptIDE.Name = "ScriptIDE";
            this.ScriptIDE.Size = new System.Drawing.Size(1224, 267);
            this.ScriptIDE.TabIndex = 0;
            this.ScriptIDE.Text = resources.GetString("ScriptIDE.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 742);
            this.panel2.TabIndex = 6;
            // 
            // ScriptInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 810);
            this.Controls.Add(this.StatusPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScriptInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaveCat IDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.StatusPane.ResumeLayout(false);
            this.StatusPane.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker CLIRunner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Panel StatusPane;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button XPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox ScriptIDE;
        private System.Windows.Forms.ListBox Logs;
        private System.Windows.Forms.Panel panel2;
    }
}

