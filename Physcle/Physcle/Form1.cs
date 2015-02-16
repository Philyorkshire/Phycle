using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Physcle
{
    public partial class Form1 : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Controls

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openState = new OpenFileDialog
            {
                Filter = @"HRM (*.hrm)|*.HRM",
                Title = @"Load cycle data",
                InitialDirectory = @"C:\"
            };

            if (openState.ShowDialog() != DialogResult.OK) return;

            try
            {
                var input = new StreamReader(openState.FileName);
                var data = input.ReadToEnd();
                var ld = new Hrm(data);

            }
            catch (Exception em)
            {
                MessageBox.Show(@"Error: Could not read data from file. Original error: " + em.Message);
            }
        }
        #endregion




    }
}
