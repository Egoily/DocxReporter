using System.IO;
using System.Text;
using System.Xml;

namespace DocxSearcher
{
    class DocxToStringConverter : DocxReader
    {
        private StringBuilder text;

        public DocxToStringConverter(Stream stream)
            : base(stream)
        {
        }

        protected override void ReadDocument(XmlReader reader)
        {
            this.text = new StringBuilder();

            base.ReadDocument(reader);
        }

        protected override void ReadParagraph(XmlReader reader)
        {
            base.ReadParagraph(reader);

            this.text.AppendLine().AppendLine();
        }

        protected override void ReadBreak(XmlReader reader)
        {
            this.text.AppendLine();
        }

        protected override void ReadTabCharacter(XmlReader reader)
        {
            this.text.Append('\t');
        }

        protected override void ReadText(XmlReader reader)
        {
            this.text.Append(reader.ReadString());
        }

        public string Convert()
        {
            this.Read();
            return this.text != null ? this.text.ToString() : string.Empty;
        }
    }
}
