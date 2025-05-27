using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace TypingSpeedTester
{
    public partial class Form1 : Form
    {
        // Add a list of possible test sentences
        private readonly List<string> testSentences = new()
        {
          "The quick brown fox jumps over the lazy dog.",
          "Typing fast and accurately takes practice and patience.",
          "She sells seashells by the seashore every summer.",
          "Can you believe how quickly time flies when you're focused?",
          "A sudden storm rolled in, darkening the skies without warning.",
          "Please verify your email address before continuing to the next step.",
          "Every developer should learn how to write clean, efficient code.",
          "\"Don’t forget to save your work,\" the teacher reminded us.",
          "Life is 10% what happens to us and 90% how we react to it.",
          "In 2025, technology continues to shape the way we live and work."
        };

        private string testText;
        private Stopwatch stopwatch;
        private bool testStarted = false;
        private readonly Random random = new();

        public Form1()
        {
            InitializeComponent();
            SetRandomTestText();
            btnReset.Enabled = false;
            btnStart.Click += btnStart_Click;

            // Removed rounded corners setup
        }

        // Method to set a random sentence as the test text
        private void SetRandomTestText()
        {
            int idx = random.Next(testSentences.Count);
            testText = testSentences[idx];
            lblTestText.Text = testText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            // Center lblTestText at the top
            lblTestText.Left = (ClientSize.Width - lblTestText.Width) / 2;
            lblTestText.Top = 19;

            // Center txtInput below lblTestText
            txtInput.Left = (ClientSize.Width - txtInput.Width) / 2;
            txtInput.Top = lblTestText.Bottom + 3;

            // Center btnStart and btnReset below txtInput, with spacing between them
            int buttonsWidth = btnStart.Width + 10 + btnReset.Width;
            int buttonsLeft = (ClientSize.Width - buttonsWidth) / 2;
            btnStart.Left = buttonsLeft;
            btnStart.Top = txtInput.Bottom + 6;
            btnReset.Left = btnStart.Right + 10;
            btnReset.Top = btnStart.Top;

            // Center lblResult below the buttons
            lblResult.Left = (ClientSize.Width - lblResult.Width) / 2;
            lblResult.Top = btnStart.Bottom + 10;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Enabled = true;
            txtInput.Focus();
            stopwatch = Stopwatch.StartNew();
            testStarted = true;
            btnStart.Enabled = false;
            btnReset.Enabled = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (testStarted && txtInput.Text == testText)
            {
                stopwatch.Stop();
                testStarted = false;
                double timeTaken = stopwatch.Elapsed.TotalSeconds;
                double wordsPerMinute = (testText.Split(' ').Length / timeTaken) * 60;

                lblResult.Text = $"Test completed! Time taken: {timeTaken:F2} seconds, WPM: {wordsPerMinute:F2}";
                txtInput.Enabled = false;
                btnStart.Enabled = true;

                // Set a new random sentence for the next test
                SetRandomTestText();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblResult.Text = "";
            btnReset.Enabled = false;
            btnStart.Enabled = true;
            testStarted = false;
        }
    }
}
