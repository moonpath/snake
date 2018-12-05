using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Media;

namespace Snake
{
    public partial class SnakeMainForm : Form
    {
        const int MAPSIZE = 25;
        const int SHOWSIZE = 20;
        const int OFFSET = 0;
        const int INITIALLENGTH=2;
        Color SNAKECOLOR = Color.Blue;
        Color BACKGROUNDCOLOR = Color.Gainsboro;
        SoundPlayer bgm = new SoundPlayer(Snake.Properties.Resources.BGM);
        Random foodIndex = new Random();
        Queue body = new Queue();
        Queue direction = new Queue();
        int currentDirection = 0;
        int nextDirection = -1;
        int food;
        int head = MAPSIZE / 2 * 100 + MAPSIZE / 2;
        int suspandTimes = 2;

        PictureBox[,] map = new PictureBox[MAPSIZE, MAPSIZE];
        public SnakeMainForm()
        {
            InitializeComponent();
        }

        private void SnakeMainForm_Load(object sender, EventArgs e)
        {
            System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            for (int i = 0; i < MAPSIZE; i++)
                for (int j = 0; j < MAPSIZE; j++)
                {
                    map[i, j] = new PictureBox();
                    map[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    //map[i, j].BorderStyle = BorderStyle.Fixed3D;
                    map[i, j].BackColor = BACKGROUNDCOLOR;
                    map[i, j].Top = i * SHOWSIZE + OFFSET;
                    map[i, j].Left = j * SHOWSIZE + OFFSET;
                    map[i, j].Width = SHOWSIZE;
                    map[i, j].Height = SHOWSIZE;
                    MainPanel.Controls.Add(map[i, j]);
                }
            HighestScoreBox.Text = GetRecord().ToString();
            CurrentScoreBox.Text = "0";
            LevelBox.Text = "1";
            body.Enqueue(head);
            map[head/100, head%100].BackColor = SNAKECOLOR;
            body.Enqueue(++head);
            map[head / 100, head % 100].BackColor = SNAKECOLOR;
            SetFood();
        }
        private int GetRecord()
        {
            int scoreRecord = 0;
            try
            {
                StreamReader scoreRecordFile = new StreamReader(@"Record.rec");
                scoreRecord = int.Parse(scoreRecordFile.ReadLine());
                scoreRecordFile.Close();
            }
            catch
            {
            }
            return scoreRecord;
        }
        private void SetRecord(int score)
        {
            try
            {
                StreamWriter scoreRecordFile = new StreamWriter(@"Record.rec");
                scoreRecordFile.Write(score);
                scoreRecordFile.Close();
            }
            catch
            {
            }
        }

        private void run_Tick(object sender, EventArgs e)
        {
            if(direction.Count!=0)
                currentDirection = (int)direction.Dequeue();
            int head_i = head / 100;
            int head_j = head % 100;
            if (currentDirection == 0)//right
            {
                ++head_j;
            }
            else if(currentDirection == 1)//down
            {
                ++head_i;
            }
            else if (currentDirection == 2)//left
            {
                --head_j;
            }
            else if (currentDirection == 3)//up
            {
                --head_i;
            }
            if (!Judge(head_i, head_j))
            {
                InitializeGame();
                return;
            }
            map[head_i, head_j].BackColor = SNAKECOLOR;
            head = head_i * 100 + head_j;
            body.Enqueue(head);
            if (head != food)
            {
                int tail = (int)body.Dequeue();
                map[tail / 100, tail % 100].BackColor = BACKGROUNDCOLOR;
            }
            else if (!SetFood())
            {
                run.Enabled = false;
                MessageBox.Show("恭喜，你已经达到最高分数！", "梦蛇", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeGame();
                return;
            }
            else
            {
                CurrentScoreBox.Text = (body.Count - INITIALLENGTH).ToString();
                if ((body.Count - INITIALLENGTH) % 8 == 0 && body.Count- INITIALLENGTH < 64)
                {
                    LevelBox.Text = (int.Parse(LevelBox.Text) + 1).ToString();
                    run.Interval = run.Interval * 5 / 6;
                }
                else if (body.Count- INITIALLENGTH >= 64 && run.Interval != 200)
                {
                    LevelBox.Text = "MAX";
                    run.Interval = 200;
                }
                System.Media.SystemSounds.Beep.Play();
            }

            //MessageBox.Show("OK");
        }
        private bool SetFood()
        {
            int[] foodInterval = new int[MAPSIZE * MAPSIZE];
            int validLength = 0;
            for (int i = 0; i < MAPSIZE; i++)
                for (int j = 0; j < MAPSIZE; j++)
                {
                    int coordinate = i * 100 + j;
                    if (!body.Contains(coordinate))
                        foodInterval[validLength++] = coordinate;
                }
            if (validLength <= MAPSIZE * MAPSIZE / 2)
                return false;
            food = foodInterval[foodIndex.Next(0, validLength)];
            map[food / 100, food % 100].BackColor = Color.Red;
            return true;
        }
        private bool Judge(int coordinate_i, int coordinate_j)
        {
            if (coordinate_i < 0 || coordinate_i >= MAPSIZE || coordinate_j < 0 || coordinate_j >= MAPSIZE || body.Contains(coordinate_i * 100 + coordinate_j))
            {
                run.Enabled = false;
                bgm.Stop();
                int scoreRecord = GetRecord();
                if(scoreRecord< body.Count- INITIALLENGTH)
                {
                    SetRecord(body.Count- INITIALLENGTH);
                    MessageBox.Show("新纪录！您的得分为："+ (body.Count- INITIALLENGTH), "梦蛇", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(FailShow() + System.Environment.NewLine + "游戏结束！您的得分为：" + (body.Count- INITIALLENGTH), "梦蛇", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                    if (currentDirection != 2 && direction.Count == 0)
                    {
                        direction.Enqueue(0);
                        nextDirection = 0;
                    }
                    else if(nextDirection!= 2 && direction.Count == 1)
                    {
                        direction.Enqueue(0);
                        nextDirection = 0;
                    }
                    break;
                case Keys.Down:
                    if (currentDirection != 3 && direction.Count == 0)
                    {
                        direction.Enqueue(1);
                        nextDirection = 1;
                    }
                    else if (nextDirection != 3 && direction.Count == 1)
                    {
                        direction.Enqueue(1);
                        nextDirection = 1;
                    }
                    break;
                case Keys.Left:
                    if (currentDirection != 0 && direction.Count == 0)
                    {
                        direction.Enqueue(2);
                        nextDirection = 2;
                    }
                    else if (nextDirection != 0 && direction.Count == 1)
                    {
                        direction.Enqueue(2);
                        nextDirection = 2;
                    }
                    break;
                case Keys.Up:
                    if (currentDirection != 1 && direction.Count == 0)
                    {
                        direction.Enqueue(3);
                        nextDirection = 3;
                    }
                    else if (nextDirection != 1 && direction.Count == 1)
                    {
                        direction.Enqueue(3);
                        nextDirection = 3;
                    }
                    break;
                case Keys.Space:
                    if (StartButton.Enabled != false)
                        StartToolStripMenuItem_Click(null, null);
                    break;
                case Keys.Enter:
                    if(StartButton.Enabled!=false)
                        StartToolStripMenuItem_Click(null, null);
                    break;
            }
            return true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartToolStripMenuItem_Click(null, null);
        }
        private void InitializeGame()
        {
            StartButton.Text = "开始";
            StartToolStripMenuItem.Text = "开始";
            StartButton.Enabled = true;
            StartToolStripMenuItem.Enabled = true;
            suspandTimes = 2;
            run.Interval = 200;
            HighestScoreBox.Text = GetRecord().ToString();
            CurrentScoreBox.Text = "0";
            LevelBox.Text = "1";
            for (int i = 0; i < MAPSIZE; i++)
                for (int j = 0; j < MAPSIZE; j++)
                {
                    map[i, j].BackColor = BACKGROUNDCOLOR;
                }
            head = MAPSIZE / 2 * 100 + MAPSIZE / 2;
            body.Clear();
            body.Enqueue(head);
            map[head / 100, head % 100].BackColor = SNAKECOLOR;
            body.Enqueue(++head);
            map[head / 100, head % 100].BackColor = SNAKECOLOR;
            direction.Clear();
            currentDirection =0;
            SetFood();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (run.Enabled)
            {
                StartButton.Text = "开始";
                StartToolStripMenuItem.Text = "开始";
                run.Enabled = false;
                bgm.Stop();
            }
            else
            {
                StartButton.Text = "暂停";
                StartToolStripMenuItem.Text = "暂停";
                if (suspandTimes-- <= 0)
                {
                    StartButton.Enabled = false;
                    StartToolStripMenuItem.Enabled = false;
                }
                run.Enabled = true;
                bgm.Load();
                bgm.PlayLooping();
            }
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IntroductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("操控方向键让梦蛇吃到更多的食物，游戏中避免撞到障碍物。", "梦蛇", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此游戏为送给妹妹张梦宇的生日礼物。", "梦蛇", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string FailShow()
        {
            string[] failShowArray = { "那个蛇快的没法！", "拿个小水喝杯子。", "妈剖呢？", "思蒙斯，思蒙斯，思蒙斯！", "那我呢？" ,"开着水，烧着门！", "捧捧脸，洗洗水！" , "谁不吃病谁有菜！", "干了一蒙子觉，睡了一蒙子活！", "一冰箱袜子，一洗衣机菜！" };
            Random failShowIndex = new Random();
            return failShowArray[failShowIndex.Next(0, failShowArray.Length)];
        }
    }
}
