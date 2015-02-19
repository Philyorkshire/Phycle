using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Physcle
{
    public partial class Form1 : Form
    {
        private Hrm _data;
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
                _data = new Hrm(data);

                var fDir = ((FileStream) input.BaseStream).Name.Split('\\').Last();
                var fName = fDir.Substring(0, fDir.Length -4);
                _data.FileName = fName;

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
                    versionText.Text = _data.Parameters.Version;
                    sModeText.Text = _data.Parameters.SMode;
                    monitorText.Text = _data.Parameters.Monitor;
                    intervalText.Text = _data.Parameters.Interval.ToString();
                    dateText.Text = _data.Parameters.StartDateTime.ToString(CultureInfo.InvariantCulture);

                    activeText.Text = _data.Parameters.ActiveLimit;
                    maxHrText.Text = _data.Parameters.MaxHr;
                    restHrText.Text = _data.Parameters.RestHr;
                    V02MaxText.Text = _data.Parameters.Vo2Max;
                    weightText.Text = _data.Parameters.Weight;
                    upper1Text.Text = _data.Parameters.Upper1;
                    upper2Text.Text = _data.Parameters.Upper2;
                    upper3Text.Text = _data.Parameters.Upper3;
                    lower1Text.Text = _data.Parameters.Lower1;
                    lower2Text.Text = _data.Parameters.Lower2;
                    lower3Text.Text = _data.Parameters.Lower3;
                    timer1Text.Text = _data.Parameters.Timer1;
                    timer2Text.Text = _data.Parameters.Timer2;
                    timer3Text.Text = _data.Parameters.Timer3;
                    break;

                case "summary":
                    overviewPanel.Visible = false;
                    summaryPanel.Visible = true;

                    summary.BackColor=     Color.SlateGray;
                    aSpeedText.Text=       Math.Round(_data.GetAverage("speed"), 2).ToString(CultureInfo.InvariantCulture);
                    aAltitudeText.Text=    Math.Round(_data.GetAverage("altitude"), 2).ToString(CultureInfo.InvariantCulture);
                    aPressureText.Text=    Math.Round(_data.GetAverage("pressure"), 2).ToString(CultureInfo.InvariantCulture);
                    aPowerText.Text=       Math.Round(_data.GetAverage("power"), 2).ToString(CultureInfo.InvariantCulture);
                    aCadenceText.Text=     Math.Round(_data.GetAverage("cadence"), 2).ToString(CultureInfo.InvariantCulture);
                    aHeartText.Text=       Math.Round(_data.GetAverage("hr"), 2).ToString(CultureInfo.InvariantCulture);
                    tDistanceText.Text =   Math.Round(_data.Data[_data.Data.Count - 1].TotalDistance, 2).ToString(CultureInfo.InvariantCulture);
                    lengthText.Text =      _data.Parameters.Length;
                    tPowerText.Text =      _data.Data.Sum(row => row.Power).ToString(CultureInfo.InvariantCulture);
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

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveJson = new SaveFileDialog
            {
                Filter = @"Json (.json)|*.json",
                Title = @"Save JSON File",
                FileName = _data.FileName,
                InitialDirectory = string.Format(@"C:\Users\{0}\Desktop", Environment.UserName)
            };


            if ((saveJson.FileName == "") || (saveJson.ShowDialog() != DialogResult.OK)) return;

            using (FileStream fs = (FileStream)saveJson.OpenFile())
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(jw, _data);
            }
        }

    }
}
