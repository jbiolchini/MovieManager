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
    public partial class FormAddMovie : Form
    {
        public FormAddMovie()
        {
            InitializeComponent();
        }

        private void btCloseAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
