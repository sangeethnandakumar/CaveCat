using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CaveCat_IDE
{
    public partial class XPath_Builder : Form
    {
        public string XPath { get; set; }
        string nodeName = "";

        public XPath_Builder()
        {
            InitializeComponent();
        }

        private void XPath_Builder_Load(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText(TextDataFormat.Text);
            HTMLIn.Text = clipboardText;
            ParseHTML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var start = "(//";
            var content = "";
            var end = ")";
            if (UNode.Checked)
            {
                content += nodeName;
            }
            if (UAttr.Checked)
            {
                var selectedItems = AttributeList.CheckedItems;
                foreach (var item in selectedItems)
                {
                    var aName = item.ToString().Split('=')[0];
                    var aValue = item.ToString().Split('=')[1];
                    content += $"[@{aName}='{aValue}']";
                }
            }
            if (UText.Checked)
            {
                content += $"[contains(text(),'{InnerText.Text}')]";
            }
            XPath = start + content + end;
            XPathOut.Text = XPath;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ParseHTML()
        {
            try
            {
                AttributeList.Items.Clear();
                InnerText.Text = "";
                XPathOut.Text = "";
                var xml = HTMLIn.Text;
                var html = XElement.Parse(xml);
                nodeName = html.Name.LocalName;
                foreach (var attribute in html.Attributes())
                {
                    string value = $"{attribute.Name.LocalName}={attribute.Value}";
                    AttributeList.Items.Add(value);
                }
                InnerText.Text = html.Value;
            }
            catch (Exception ex) { }
        }

        private void DecodeInfo_Click(object sender, EventArgs e)
        {
            ParseHTML();
        }

        private void HTMLIn_TextChanged(object sender, EventArgs e)
        {            
            if(HTMLIn.Text.ToLower().StartsWith("<input"))
            {
                if(!HTMLIn.Text.EndsWith("/>"))
                {
                    HTMLIn.Text = HTMLIn.Text.Replace(">", "/>");
                }
            }
            ParseHTML();
        }

        private void XPathInsert_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
