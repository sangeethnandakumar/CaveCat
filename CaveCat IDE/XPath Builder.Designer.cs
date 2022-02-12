namespace CaveCat_IDE
{
    partial class XPath_Builder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UNode = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AttributeList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HTMLIn = new System.Windows.Forms.RichTextBox();
            this.XPathOut = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XPathInsert = new System.Windows.Forms.Button();
            this.InnerText = new System.Windows.Forms.TextBox();
            this.UAttr = new System.Windows.Forms.CheckBox();
            this.UText = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DecodeInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecodeInfo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // UNode
            // 
            this.UNode.AutoSize = true;
            this.UNode.Checked = true;
            this.UNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UNode.Location = new System.Drawing.Point(20, 28);
            this.UNode.Name = "UNode";
            this.UNode.Size = new System.Drawing.Size(108, 17);
            this.UNode.TabIndex = 5;
            this.UNode.Text = "Unique by NODE";
            this.UNode.UseVisualStyleBackColor = true;
            this.UNode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Re Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttributeList
            // 
            this.AttributeList.FormattingEnabled = true;
            this.AttributeList.Location = new System.Drawing.Point(39, 74);
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.Size = new System.Drawing.Size(271, 124);
            this.AttributeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HTML Node";
            // 
            // HTMLIn
            // 
            this.HTMLIn.BackColor = System.Drawing.Color.White;
            this.HTMLIn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLIn.ForeColor = System.Drawing.Color.Black;
            this.HTMLIn.Location = new System.Drawing.Point(15, 37);
            this.HTMLIn.Name = "HTMLIn";
            this.HTMLIn.Size = new System.Drawing.Size(1031, 120);
            this.HTMLIn.TabIndex = 1;
            this.HTMLIn.Text = "";
            this.HTMLIn.TextChanged += new System.EventHandler(this.HTMLIn_TextChanged);
            // 
            // XPathOut
            // 
            this.XPathOut.BackColor = System.Drawing.Color.White;
            this.XPathOut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPathOut.ForeColor = System.Drawing.Color.Black;
            this.XPathOut.Location = new System.Drawing.Point(16, 29);
            this.XPathOut.Name = "XPathOut";
            this.XPathOut.Size = new System.Drawing.Size(610, 136);
            this.XPathOut.TabIndex = 3;
            this.XPathOut.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.XPathInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 44);
            this.panel1.TabIndex = 6;
            // 
            // XPathInsert
            // 
            this.XPathInsert.Location = new System.Drawing.Point(905, 7);
            this.XPathInsert.Name = "XPathInsert";
            this.XPathInsert.Size = new System.Drawing.Size(135, 30);
            this.XPathInsert.TabIndex = 3;
            this.XPathInsert.Text = "Insert";
            this.XPathInsert.UseVisualStyleBackColor = true;
            this.XPathInsert.Click += new System.EventHandler(this.XPathInsert_Click);
            // 
            // InnerText
            // 
            this.InnerText.Location = new System.Drawing.Point(39, 227);
            this.InnerText.Multiline = true;
            this.InnerText.Name = "InnerText";
            this.InnerText.Size = new System.Drawing.Size(271, 59);
            this.InnerText.TabIndex = 6;
            // 
            // UAttr
            // 
            this.UAttr.AutoSize = true;
            this.UAttr.Checked = true;
            this.UAttr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UAttr.Location = new System.Drawing.Point(20, 51);
            this.UAttr.Name = "UAttr";
            this.UAttr.Size = new System.Drawing.Size(145, 17);
            this.UAttr.TabIndex = 7;
            this.UAttr.Text = "Unique by ATTRIBUTES";
            this.UAttr.UseVisualStyleBackColor = true;
            // 
            // UText
            // 
            this.UText.AutoSize = true;
            this.UText.Location = new System.Drawing.Point(20, 204);
            this.UText.Name = "UText";
            this.UText.Size = new System.Drawing.Size(142, 17);
            this.UText.TabIndex = 8;
            this.UText.Text = "Unique by INNER TEXT";
            this.UText.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AttributeList);
            this.groupBox2.Controls.Add(this.UText);
            this.groupBox2.Controls.Add(this.UNode);
            this.groupBox2.Controls.Add(this.UAttr);
            this.groupBox2.Controls.Add(this.InnerText);
            this.groupBox2.Location = new System.Drawing.Point(18, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 308);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Constrains";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.XPathOut);
            this.groupBox3.Location = new System.Drawing.Point(368, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 189);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generated XPath";
            // 
            // DecodeInfo
            // 
            this.DecodeInfo.Location = new System.Drawing.Point(735, 234);
            this.DecodeInfo.Name = "DecodeInfo";
            this.DecodeInfo.Size = new System.Drawing.Size(135, 30);
            this.DecodeInfo.TabIndex = 11;
            this.DecodeInfo.Text = "Decode Info";
            this.DecodeInfo.UseVisualStyleBackColor = true;
            this.DecodeInfo.Click += new System.EventHandler(this.DecodeInfo_Click);
            // 
            // XPath_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HTMLIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "XPath_Builder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPath_Builder";
            this.Load += new System.EventHandler(this.XPath_Builder_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox HTMLIn;
        private System.Windows.Forms.RichTextBox XPathOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button XPathInsert;
        private System.Windows.Forms.CheckedListBox AttributeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox UNode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox UText;
        private System.Windows.Forms.CheckBox UAttr;
        private System.Windows.Forms.TextBox InnerText;
        private System.Windows.Forms.Button DecodeInfo;
    }
}