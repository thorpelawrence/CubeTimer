using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using cube.Properties;

namespace cube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateScramble();
            InputTimes();
        }

        #region Variables
        bool _timerRunning, _timerEnded, _inspectTimerRunning, _keyHeld;
        int _ms, _averageTime, _lowestTime, _highestTime;
        //TODO try to use int; convert to float if neccessary
        float _inspectTime;
        //TODO try to use Time for inspect; use int
        #endregion

        #region Key Events
        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            _keyHeld = false;
            if (e.KeyCode == Keys.Space)
            {
                if (!_timerEnded)
                {
                    switch (_timerRunning)
                    {
                        case false:
                            TimerStart();
                            break;
                        case true:
                            TimerStop();
                            break;
                    }
                }
                else if (_timerEnded) _timerEnded = false;
                if (_ms > 0 & !_timerRunning)
                {
                    TimerReset();
                }

            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_keyHeld)
            {
                e.Handled = true;
            }
            else
            {
                _keyHeld = true;
                if (e.KeyCode == Keys.Space & !_timerRunning)
                {
                    timerText.Text = Resources.time_0;
                    timerText.ForeColor = Color.Lime;
                    InspectTimerStart();
                    scrambleText.Visible = false;
                }
                else if (_timerRunning)
                {
                    TimerStop();
                }
            }
        }
        #endregion

        #region Timer
        void timer1_Tick(object sender, EventArgs e)
        {
            _ms++;
            timerText.Text = TimeSpan.FromMilliseconds(_ms * 1000).ToString();
        }

        void TimerStart()
        {
            timerText.ForeColor = Color.White;
            timer1.Start();
            _timerRunning = true;
            InspectTimerStop();
        }

        void TimerStop()
        {
            timer1.Stop();
            SaveTime();
            _timerRunning = false;
            _timerEnded = true;
            timerText.ForeColor = Color.Red;
            GenerateScramble();
        }

        void TimerReset()
        {
            _ms = 0;
        }
        #endregion

        #region InspectTimer
        void inspectTimer_Tick(object sender, EventArgs e)
        {
            if (_inspectTimerRunning)
            {
                if (_inspectTime > 0)
                {
                    _inspectTime = _inspectTime - 0.05f;
                    inspectTimerText.Text = (_inspectTime * 100).ToString("00:00:00");
                }
                else
                {
                    InspectTimerStop();
                    timerText.ForeColor = Color.DarkOrange;
                }
            }
        }

        void InspectTimerStart()
        {
            InspectTimerReset();
            inspectTimerText.Visible = true;
            inspectTimer.Start();
            _inspectTimerRunning = true;
        }

        void InspectTimerStop()
        {
            inspectTimerText.Visible = false;
            inspectTimer.Stop();
            _inspectTimerRunning = false;
        }

        void InspectTimerReset()
        {
            _inspectTime = 15;
        }
        #endregion

        #region Times
        void SaveTime()
        {
            savedTimes.Items.Add(timerText.Text);
            savedTimes.TopIndex = savedTimes.Items.Count - 1;
            GenerateTimeInfo();
        }

        void DeleteTime()
        {
            savedTimes.Items.Remove(savedTimes.SelectedItem);
            GenerateTimeInfo();
        }

        void DeleteAllTimes()
        {
            savedTimes.Items.Clear();
            GenerateTimeInfo();
        }

        void GenerateTimeInfo()
        {
            if (savedTimes.Items.Count > 0)
            {
                var timeList = (from string savedTime in savedTimes.Items select TimeSpan.Parse(savedTime).TotalMilliseconds).ToList();
                _averageTime = Math.Round((timeList.Average()) / 1000) * 1000;
                averageTimeText.Text = TimeSpan.FromMilliseconds(_averageTime).ToString();
                _lowestTime = timeList.Min();
                lowestTimeText.Text = TimeSpan.FromMilliseconds(_lowestTime).ToString();
                _highestTime = timeList.Max();
                highestTimeText.Text = TimeSpan.FromMilliseconds(_highestTime).ToString();
            }
            else if (savedTimes.Items.Count == 0)
            {
                averageTimeText.Text = Resources.time_0;
                lowestTimeText.Text = Resources.time_0;
                highestTimeText.Text = Resources.time_0;
            }
            OutputTimes();
            if (savedTimes.Items.Count == 0) DeleteTimesFile();
        }

        void delTimeButton_Click(object sender, EventArgs e)
        {
            DeleteTime();
        }

        void delAllTimesButton_Click(object sender, EventArgs e)
        {
            DeleteAllTimes();
            DeleteTimesFile();
        }

        private void savedTimes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteTime();
            }
        }
        #endregion

        #region IO
        void OutputTimes()
        {
            StreamWriter stWrite = new StreamWriter("cube-times.txt");
            foreach (string item in savedTimes.Items)
            {
                stWrite.WriteLine(item);
            }
            stWrite.Close();
        }

        void InputTimes()
        {
            if (File.Exists("cube-times.txt"))
            {
                savedTimes.Items.Clear();
                using (StreamReader stRead = new StreamReader("cube-times.txt"))
                {
                    while (!stRead.EndOfStream)
                    {
                        savedTimes.Items.Add(stRead.ReadLine());
                    }
                }
            }
            GenerateTimeInfo();
        }

        void DeleteTimesFile()
        {
            if (File.Exists("cube-times.txt"))
            {
                File.Delete("cube-times.txt");
            }
        }
        #endregion

        #region Scramble

        readonly Random _algGenerator = new Random();
        readonly string[] _faces = { "U", "D", "L", "R", "B", "F" };
        readonly string[] _types = { "2", "'", " " };
        readonly string[] _scramble = new string[25];

        void GenerateScramble()
        {
            scrambleText.Visible = true;
            string[] alg = new string[25];
            for (int i = 0; i < 25; i++)
            {
                string move = _generateMove();
                while ((i > 0) && (move.Contains(alg[i - 1])))
                {
                    move = _generateMove();
                }
                alg[i] = move.Substring(0, 1);
                _scramble[i] = (move);
            }
            scrambleText.Text = "";
            foreach (string s in _scramble)
            {
                scrambleText.Text = String.Format("{0}{1} ", scrambleText.Text, s);
            }
        }

        string _generateMove()
        {
            string face = _faces[_algGenerator.Next(_faces.Length)];
            string type = _types[_algGenerator.Next(_types.Length)];
            string move = face + type;
            return move;
        }

        #endregion
    }
}
