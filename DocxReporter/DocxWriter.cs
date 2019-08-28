using Aspose.Words;
using Aspose.Words.Fields;
using System;
using System.Collections;
using System.IO;

namespace DocxSearcher
{
    public class DocxWriter : IDisposable
    {

        private Document _Document;


        /// <summary>
        /// 模板文件名
        /// </summary>
        public string TemplateFileName { get; protected set; }
        /// <summary>
        /// 保存文件名
        /// </summary>
        public string SaveFileName { get; protected set; }



        private void InitDocument()
        {
            if (File.Exists(TemplateFileName))
            {
                _Document = new Document(TemplateFileName);
            }
            else
            {
                _Document = new Document();
            }
        }

        public DocxWriter(string fileName)
        {
            SaveFileName = fileName;
            InitDocument();
        }

        public DocxWriter(string fileName, string templateFileName)
        {
            SaveFileName = fileName;
            TemplateFileName = templateFileName;
            InitDocument();
        }



        public void AppendDocuments(string[] files)
        {

            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    var appendDoc = new Document(file);
                    foreach (var section in appendDoc.Sections)
                    {
                        ((Section)section).HeadersFooters.Clear();
                    }
                    RemovePage(appendDoc);
                    RemoveTableOfContents(appendDoc);
                    // Set the appended document to start on a new page.
                    appendDoc.FirstSection.PageSetup.SectionStart = SectionStart.NewPage;
                    _Document.AppendDocument(appendDoc, ImportFormatMode.KeepSourceFormatting);
                }

            }

            DocumentBuilder builder = new DocumentBuilder(_Document);

            SetupCatalog(builder);


            // Specify that we want headers and footers different for first, even and odd pages.
            builder.PageSetup.DifferentFirstPageHeaderFooter = true;
            //builder.PageSetup.OddAndEvenPagesHeaderFooter = true;

            // Go to the primary footer
            builder.MoveToHeaderFooter(HeaderFooterType.FooterPrimary);
            // Add fields for current page number
            builder.InsertField("PAGE", "");
            // Add any custom text
            builder.Write(" / ");
            // Add field for total page numbers in document
            builder.InsertField("NUMPAGES", "");
            // Align this text to the center.
            builder.CurrentParagraph.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            _Document.UpdateFields();
            _Document.UpdateListLabels();
            _Document.UpdatePageLayout();
            _Document.UpdateTableLayout();
            _Document.UpdateWordCount();
            _Document.Save(SaveFileName);

        }


        public void AppendDocumentsWithTemplate(string[] files)
        {
            DocumentBuilder builder = new DocumentBuilder(_Document);

            if (builder.MoveToBookmark("Year"))
            {
                builder.Write(DateTime.Now.Year.ToString());
            }
            if (builder.MoveToBookmark("Month"))
            {
                builder.Write(DateTime.Now.Month.ToString());
            }

            if (builder.MoveToBookmark("Day"))
            {
                builder.Write(DateTime.Now.Day.ToString());
            }


            builder.MoveToBookmark("MainBody");

            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    var appendDoc = new Document(file);
                    foreach (var section in appendDoc.Sections)
                    {
                        ((Section)section).HeadersFooters.Clear();
                    }
                    RemovePage(appendDoc);
                    RemoveTableOfContents(appendDoc);
                    // Set the appended document to start on a new page.
                    //appendDoc.FirstSection.PageSetup.SectionStart = SectionStart.NewPage;
                    _Document.AppendDocument(appendDoc, ImportFormatMode.KeepSourceFormatting);
                }

            }

            _Document.UpdateFields();
            _Document.UpdateListLabels();
            _Document.UpdatePageLayout();
            _Document.UpdateTableLayout();
            _Document.UpdateWordCount();
            _Document.Save(SaveFileName);

        }


        public void CombineDocuments(string[] files)
        {
            DocumentBuilder builder = new DocumentBuilder(_Document);

            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    var appendDoc = new Document(file);
                    RemovePage(appendDoc);
                    RemoveTableOfContents(appendDoc);
                    builder.MoveToDocumentEnd();
                    var curParagraph = builder.CurrentParagraph;

                    appendDoc.FirstSection.PageSetup.SectionStart = SectionStart.NewPage;
                    _Document.FirstSection.PageSetup.SectionStart = SectionStart.NewPage;
                    InsertDocument(curParagraph, appendDoc);

                }

            }

            SetupCatalog(builder);
            SetupHeaderFooter(builder, "");

            _Document.UpdateFields();
            _Document.UpdateListLabels();
            _Document.UpdatePageLayout();
            _Document.UpdateTableLayout();
            _Document.UpdateWordCount();
            _Document.Save(SaveFileName);

        }


        public void RemoveTableOfContents(string fileName)
        {
            if (File.Exists(fileName))
            {
                var doc = new Document(fileName);
                foreach (var section in doc.Sections)
                {
                    ((Section)section).HeadersFooters.Clear();
                }

                RemoveTableOfContents(doc);

                doc.Save(SaveFileName);
            }
        }


        public static void RemoveTableOfContents(Document doc, int index = 0)
        {
            // Store the FieldStart nodes of TOC fields in the document for quick access.
            ArrayList fieldStarts = new ArrayList();
            // This is a list to store the nodes found inside the specified TOC. They will be removed
            // At the end of this method.
            ArrayList nodeList = new ArrayList();

            foreach (FieldStart start in doc.GetChildNodes(NodeType.FieldStart, true))
            {
                if (start.FieldType == FieldType.FieldTOC)
                {
                    // Add all FieldStarts which are of type FieldTOC.
                    fieldStarts.Add(start);
                }
            }

            // Ensure the TOC specified by the passed index exists.
            if (index > fieldStarts.Count - 1)
            {
                return;
            }

            bool isRemoving = true;
            // Get the FieldStart of the specified TOC.
            Node currentNode = (Node)fieldStarts[index];

            while (isRemoving)
            {
                // It is safer to store these nodes and delete them all at once later.
                nodeList.Add(currentNode);
                currentNode = currentNode.NextPreOrder(doc);

                // Once we encounter a FieldEnd node of type FieldTOC then we know we are at the end
                // Of the current TOC and we can stop here.
                if (currentNode.NodeType == NodeType.FieldEnd)
                {
                    FieldEnd fieldEnd = (FieldEnd)currentNode;
                    if (fieldEnd.FieldType == FieldType.FieldTOC)
                    {
                        isRemoving = false;
                    }
                }
            }

            // Remove all nodes found in the specified TOC.
            foreach (Node node in nodeList)
            {
                node.Remove();
            }
        }

        public static void RemovePage(Document doc)
        {
            RemovePageBreaks(doc);
            RemoveSectionBreaks(doc);
        }


        private static void RemovePageBreaks(Document doc)
        {
            // Retrieve all paragraphs in the document.
            NodeCollection paragraphs = doc.GetChildNodes(NodeType.Paragraph, true);

            // Iterate through all paragraphs
            foreach (Paragraph para in paragraphs)
            {
                // If the paragraph has a page break before set then clear it.
                if (para.ParagraphFormat.PageBreakBefore)
                {
                    para.ParagraphFormat.PageBreakBefore = false;
                }

                // Check all runs in the paragraph for page breaks and remove them.
                foreach (Run run in para.Runs)
                {
                    if (run.Text.Contains(ControlChar.PageBreak))
                    {
                        run.Text = run.Text.Replace(ControlChar.PageBreak, string.Empty);
                    }
                }

            }

        }

        private static void RemoveSectionBreaks(Document doc)
        {
            // Loop through all sections starting from the section that precedes the last one 
            // And moving to the first section.
            for (int i = doc.Sections.Count - 2; i >= 0; i--)
            {
                // Copy the content of the current section to the beginning of the last section.
                doc.LastSection.PrependContent(doc.Sections[i]);
                // Remove the copied section.
                doc.Sections[i].Remove();
            }
        }


        private static void SetupCatalog(DocumentBuilder builder)
        {
            builder.MoveToSection(0);
            builder.MoveToDocumentStart();
            // Insert a table of contents at the beginning of the document.
            builder.InsertTableOfContents("\\o \"1-3\" \\h \\z \\u");
        }

        private static void SetupHeaderFooter(DocumentBuilder builder, string text)
        {
            // Specify that we want headers and footers different for first, even and odd pages.
            builder.PageSetup.DifferentFirstPageHeaderFooter = true;
            //builder.PageSetup.OddAndEvenPagesHeaderFooter = true;

            // --- Create footer for pages other than first. ---
            builder.MoveToHeaderFooter(HeaderFooterType.FooterPrimary);

            // We use table with two cells to make one part of the text on the line (with page numbering)
            // to be aligned left, and the other part of the text (with copyright) to be aligned right.
            builder.StartTable();

            Section currentSection = builder.CurrentSection;
            PageSetup pageSetup = currentSection.PageSetup;

            // Calculate table width as total page width with left and right marins subtracted.
            double tableWidth = pageSetup.PageWidth - pageSetup.LeftMargin - pageSetup.RightMargin;

            builder.InsertCell();

            // Set first cell to 1/3 of the page width.
            builder.CellFormat.Width = tableWidth / 3;

            // Insert page numbering text here.
            // It uses PAGE and NUMPAGES fields to autocalculate current page number and total number of pages.

            builder.Write("Page ");
            builder.InsertField("PAGE", "");
            builder.Write(" of ");
            builder.InsertField("NUMPAGES", "");



            // Align this text to the left.
            builder.CurrentParagraph.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            builder.InsertCell();

            // Set the second cell to 2/3 of the page width.
            builder.CellFormat.Width = tableWidth * 2 / 3;
            builder.Write(text);

            // Align this text to the right.
            builder.CurrentParagraph.ParagraphFormat.Alignment = ParagraphAlignment.Right;

            builder.EndRow();
            builder.EndTable();
            builder.MoveToDocumentEnd();
        }

        /// <summary>
        /// Inserts content of the external document after the specified node.
        /// Section breaks and section formatting of the inserted document are ignored.
        /// </summary>
        /// <param name="insertAfterNode">Node in the destination document after which the content
        /// should be inserted. This node should be a block level node (paragraph or table).</param>
        /// <param name="srcDoc">The document to insert.</param>
        private static void InsertDocument(Node insertAfterNode, Document srcDoc)
        {
            // Make sure that the node is either a pargraph or table.
            if ((!insertAfterNode.NodeType.Equals(NodeType.Paragraph)) & (!insertAfterNode.NodeType.Equals(NodeType.Table)))
            {
                throw new ArgumentException("The destination node should be either a paragraph or table.");
            }

            // We will be inserting into the parent of the destination paragraph.
            CompositeNode dstStory = insertAfterNode.ParentNode;

            // This object will be translating styles and lists during the import.
            NodeImporter importer = new NodeImporter(srcDoc, insertAfterNode.Document, ImportFormatMode.KeepSourceFormatting);

            // Loop through all sections in the source document.
            foreach (Section srcSection in srcDoc.Sections)
            {
                // Loop through all block level nodes (paragraphs and tables) in the body of the section.
                foreach (Node srcNode in srcSection.Body)
                {
                    // Let's skip the node if it is a last empty paragarph in a section.
                    if (srcNode.NodeType.Equals(NodeType.Paragraph))
                    {
                        Paragraph para = (Paragraph)srcNode;
                        if (para.IsEndOfSection && !para.HasChildNodes)
                        {
                            continue;
                        }
                    }
                    // This creates a clone of the node, suitable for insertion into the destination document.
                    Node newNode = importer.ImportNode(srcNode, true);

                    // Insert new node after the reference node.
                    dstStory.InsertAfter(newNode, insertAfterNode);
                    insertAfterNode = newNode;
                }
            }
        }


        public void Dispose()
        {
        }
    }
}
