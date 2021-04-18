using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            // Format Text in RichTextBox RTBAbout
            // Row 1: title
            int rowIndex = 0;
            RTBAbout.Select(RTBAbout.GetFirstCharIndexFromLine(rowIndex),
                RTBAbout.Lines[rowIndex].Length);
            RTBAbout.SelectionFont = new Font("Times New Roman", 20, FontStyle.Bold);
            RTBAbout.SelectionColor = Color.DarkBlue;
            // Row 5: author
            // headingLength = length of "Author:", "Date:", "Version:"
            rowIndex = 4;
            int headingLength = 7;
            RTBAbout.Select(RTBAbout.GetFirstCharIndexFromLine(rowIndex) + headingLength,
                RTBAbout.Lines[rowIndex].Length - headingLength);
            RTBAbout.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            // Row 6: date
            rowIndex = 5;
            headingLength = 5;
            RTBAbout.Select(RTBAbout.GetFirstCharIndexFromLine(rowIndex) + headingLength,
                RTBAbout.Lines[rowIndex].Length - headingLength);
            RTBAbout.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            // Row 7: version
            rowIndex = 6;
            headingLength = 8;
            RTBAbout.Select(RTBAbout.GetFirstCharIndexFromLine(rowIndex) + headingLength,
                RTBAbout.Lines[rowIndex].Length - headingLength);
            RTBAbout.SelectionFont = new Font("Times New Roman", 12, FontStyle.Italic);
        }

        //Method Closes the About Form when the close button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
