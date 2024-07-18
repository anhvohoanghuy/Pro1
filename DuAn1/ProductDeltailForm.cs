using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class ProductDeltailForm : Form
    {
        public ProductDeltailForm()
        {
            InitializeComponent();
            PositionFormWithMargins(220, 20, 80, 5);
        }
        private void PositionFormWithMargins(int marginLeft, int marginRight, int marginTop, int marginBottom)
        {
            
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            
            int x = marginLeft;
            int y = marginTop;
            int width = screen.Width - marginLeft - marginRight;
            int height = screen.Height - marginTop - marginBottom;

            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
        }
        private void ProductDeltailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
