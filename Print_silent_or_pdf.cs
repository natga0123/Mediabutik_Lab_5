using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Mediabutik_Lab4_1
{
    class Print_silent_or_pdf
    {

        private Font printFont;
        private StreamReader streamToPrint;
        public string FilePath;
            //static string filePath;

        public Print_silent_or_pdf()
        {
            //Printing(FilePath);
        }

            // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
                float linesPerPage = 0;
                float yPos = 0;
                int count = 0;
                float leftMargin = ev.MarginBounds.Left;
                float topMargin = ev.MarginBounds.Top;
                String line = null;

                // Calculate the number of lines per page.
                linesPerPage = ev.MarginBounds.Height /
                   printFont.GetHeight(ev.Graphics);

                // Iterate over the file, printing each line.
                while (count < linesPerPage &&
                   ((line = streamToPrint.ReadLine()) != null))
                {
                    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFont, Brushes.Black,
                       leftMargin, yPos, new StringFormat());
                    count++;
                }

                // If more lines exist, print another page.
                if (line != null)
                    ev.HasMorePages = true;
                else
                    ev.HasMorePages = false;
        }

            // Print the file.
        public void Printing(string FilePath)
        {
                try
                {
                    streamToPrint = new StreamReader(FilePath);
                    try
                    {
                        printFont = new Font("Arial", 10);
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                        // Print the document.
                        pd.Print();
                    }
                    finally
                    {
                        streamToPrint.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }


        
    }
}
