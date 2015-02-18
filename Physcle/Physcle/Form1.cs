using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Physcle
{
    public partial class Form1 : Form
    {
        private Hrm Data;
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
                Data = new Hrm(data);
                SwitchView("overview");
            }
            catch (Exception em)
            {
                MessageBox.Show(@"Error: Could not read data from file. Original error: " + em.Message);
            }
        }
        #endregion

        private void SwitchView(string view)
        {
            switch (view)
            {
                case "overview":
                    overview.BackColor = Color.SlateGray;
                    overviewPanel.Visible = true;
                    versionText.Text = Data.Parameters.Version;
                    sModeText.Text = Data.Parameters.SMode;
                    monitorText.Text = Data.Parameters.Monitor;
                    intervalText.Text = Data.Parameters.Interval.ToString();

                    activeText.Text = Data.Parameters.ActiveLimit;
                    maxHrText.Text = Data.Parameters.MaxHr;
                    restHrText.Text = Data.Parameters.RestHr;
                    V02MaxText.Text = Data.Parameters.Vo2Max;
                    weightText.Text = Data.Parameters.Weight;
                    dateText.Text = Data.Parameters.Date;
                    startText.Text = Data.Parameters.StartTime;
                    lengthText.Text = Data.Parameters.Length;

                    upper1Text.Text = Data.Parameters.Upper1;
                    upper2Text.Text = Data.Parameters.Upper2;
                    upper3Text.Text = Data.Parameters.Upper3;

                    lower1Text.Text = Data.Parameters.Lower1;
                    lower2Text.Text = Data.Parameters.Lower2;
                    lower3Text.Text = Data.Parameters.Lower3;

                    timer1Text.Text = Data.Parameters.Timer1;
                    timer2Text.Text = Data.Parameters.Timer2;
                    timer3Text.Text = Data.Parameters.Timer3;
                    break;
                case "summary":
                    overviewPanel.Visible = false;
                    summary.BackColor = Color.SlateGray;
                    break;
            }
        }

        private void summary_Click(object sender, EventArgs e)
        {
            SwitchView("summary");
        }

        private void overview_Click(object sender, EventArgs e)
        {
            SwitchView("overview");
        }

    }
}
