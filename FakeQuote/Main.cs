using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FakeQuote
{
    public partial class Main : Form
    {
        private readonly DateTime epoch;


        public Main()
        {
            InitializeComponent();

            epoch = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        }

        private void copyToClipboad_Click(object sender, EventArgs e)
        {
            SaveToClipboard();
        }     


        private void SaveToClipboard()
        {
            DateTime time;
            Clipboard.SetText(" ");
            if (DateTime.TryParse(uxTimestamp.Text, out time))
            {
                string name = uxName.Text;
                string message = uxMessage.Text;
                object[] quote = new object[1];
                object[] authorAndName = new object[4];

                authorAndName[0] = new XAttribute("author", name);
                authorAndName[1] = new XAttribute("authorname", name);
                TimeSpan timeSpan = time.ToUniversalTime() - epoch;
                authorAndName[2] = new XAttribute("timestamp", timeSpan.TotalSeconds);
                authorAndName[3] = message;
                quote[0] = new XElement("quote", authorAndName);
                string quoteToString = new XDocument(quote).ToString();

                DataObject dataObject = new DataObject();
                dataObject.SetData("System.String", message);
                dataObject.SetData("Text", message);
                dataObject.SetData("UnicodeText", message);
                dataObject.SetData("OEMText", message);
                dataObject.SetData("SkypeMessageFragment", new MemoryStream(Encoding.UTF8.GetBytes(quoteToString)));
                dataObject.SetData("Locale", new MemoryStream(BitConverter.GetBytes(CultureInfo.CurrentCulture.LCID)));

                Clipboard.SetDataObject(dataObject);
            }
        }  

        private void UseCurrentDate()
        {
            uxTimestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void useCurrent_Click(object sender, EventArgs e)
        {
            UseCurrentDate();
        }
    }
}
