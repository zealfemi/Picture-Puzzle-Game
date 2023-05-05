using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Picture_Puzzle_Game
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int inNullSliceIndex, inNullSliceIndex1, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        List<Bitmap> lstOriginalPictureList1 = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        string val;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startform));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources.m1, Properties.Resources.m2, Properties.Resources.m3, Properties.Resources.m4, Properties.Resources.m5, Properties.Resources.m6, Properties.Resources.m7, Properties.Resources.m8, Properties.Resources.m9, Properties.Resources._null });

            lstOriginalPictureList1.AddRange(new Bitmap[] { Properties.Resources.a, Properties.Resources.b, Properties.Resources.c, Properties.Resources.d, Properties.Resources.e, Properties.Resources.f, Properties.Resources.g, Properties.Resources.h, Properties.Resources.i, Properties.Resources._null });
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
            lblLabel.Text = "LEVEL 1";
        }
        public void startform()
        {
            Application.Run(new Loading());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
            lblPaused.Hide();
            group2.Hide();
            val = "";
            btnRestart.Enabled = false;
        }
        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (val == "")
            {
                if (lblTimeElapsed.Text != "00:00:00")
                {
                    YesOrNo = MessageBox.Show("Are You Sure To Restart?", "PICTURE PUZZLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    lblPaused.Hide();
                    gbPuzzleBox.Enabled = true;
                    gbPuzzleBox2.Enabled = true;
                    btnPause.Text = "PAUSE";
                }
                if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
                {
                    timer.Reset();
                    lblMovesMade.Text = "Moves: 0";
                    lblTimeElapsed.Text = "00:00:00";
                    inmoves = 0;
                    btnPause.Enabled = false;
                    Shuffle();
                    group2.Hide();
                    group1.Show();
                    val = "";
                }
            }
            if (val == "minion")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves: 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                Shuffle();
                group2.Hide();
                group1.Show();
                val = "";
            }
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (val == "")
            {
                if (lblTimeElapsed.Text != "00:00:00")
                {
                    YesOrNo = MessageBox.Show("Are You Sure To Shuffle?", "PICTURE PUZZLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    lblPaused.Hide();
                    gbPuzzleBox.Enabled = true;
                    gbPuzzleBox2.Enabled = true;
                    btnPause.Text = "PAUSE";
                }
                if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
                {
                    Shuffle();
                    timer.Reset();
                    lblTimeElapsed.Text = "00:00:00";
                    inmoves = 0;
                    lblMovesMade.Text = "Moves: 0";
                }
            }
            if (val == "minion")
            {
                YesOrNo = MessageBox.Show("Are You Sure To Shuffle?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                lblPaused.Hide();
                gbPuzzleBox2.Enabled = true;
                btnPause.Text = "PAUSE";
                if (YesOrNo == DialogResult.Yes)
                {
                    Shuffle2();
                    timer.Reset();
                    lblTimeElapsed.Text = "00:00:00";
                    inmoves = 0;
                    lblMovesMade.Text = "Moves: 0";
                }
            }
        }
        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                    if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }
        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "2")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves: 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up\nTry Again", "Picture Puzzle");
                Shuffle();
                group2.Hide();
                group1.Show();
                val = "";
            }
        }

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "PAUSE")
            {
                timer.Stop();
                gbPuzzleBox.Enabled = false;
                gbPuzzleBox2.Enabled = false;
                btnPause.Text = "RESUME";
                lblPaused.Show();
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Enabled = true;
                gbPuzzleBox2.Enabled = true;
                btnPause.Text = "PAUSE";
                lblPaused.Hide();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }

        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Moves: " + (++inmoves);
                    if (CheckWin())
                    {
                        val = "minion";
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MetroFramework.MetroMessageBox.Show(this, "Level Completed!\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves: " + inmoves, "PICTURE PUZZLE", 250);
                        inmoves = 0;
                        lblMovesMade.Text = "Moves: 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle2();
                        group1.Hide();
                        group2.Show();
                        lblLabel.Text = "LEVEL 2";
                    }
                }
            }
        }
        private void SwitchPictureBox2(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
            {
                timer.Start();
                btnRestart.Enabled = true;
            }
            int inPictureBoxIndex = gbPuzzleBox2.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex1 != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex1))
                {
                    ((PictureBox)gbPuzzleBox2.Controls[inNullSliceIndex1]).Image = ((PictureBox)gbPuzzleBox2.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox2.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList1[9];
                    inNullSliceIndex1 = inPictureBoxIndex;
                    lblMovesMade.Text = "Moves: " + (++inmoves);
                    if (CheckWin2())
                    {
                        timer.Stop();
                        (gbPuzzleBox2.Controls[8] as PictureBox).Image = lstOriginalPictureList1[8];
                        MetroFramework.MetroMessageBox.Show(this, "Completed!\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves: " + inmoves, "PICTURE PUZZLE", 250);
                        inmoves = 0;
                        lblMovesMade.Text = "Moves: 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle2();
                        Shuffle();
                        group2.Hide();
                        group1.Show();
                        val = "";
                        btnRestart.Enabled = false;
                        lblLabel.Text = "LEVEL 1";
                    }
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {  
            MetroFramework.MetroMessageBox.Show(this, "Designed and Developed by Oluwafemi Akinola (Mackie),\na student of Joseph Ayo Babalola University (JABU).\n\nFor support, please email zealfemi@gmail.com\nTwitter: zf_mackie\nGithub: zealfemi\n\nPicture and Logo Credits:\niconfinder.com", "PICTURE PUZZLE", 300);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "The goal of the game is to arrange the blocks in the correct order.\n\nThe board has one hole (an empty slot which is for the last block of the original picture).\nYou need to use this slot to move other blocks.\n\nTo move one or more blocks, click any block that is present in the row or column containing the hole.\n\nTo solve, correct the first block, and then go in order, row by row.", "PICTURE PUZZLE", 300);
        }

        void Shuffle2()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox2.Controls[i]).Image = lstOriginalPictureList1[j];
                    if (j == 9) inNullSliceIndex1 = i;//store empty picture box index
                }
            } while (CheckWin2());
        }
        bool CheckWin2()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox2.Controls[i] as PictureBox).Image != lstOriginalPictureList1[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }
    }
}
