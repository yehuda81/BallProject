using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopBall
{
    public partial class Form1 : Form
    {
        List<PictureBox> balls = new List<PictureBox>();
        int ballNumber1;
        bool key;        
        int ballBomb;
        Label label2 = new Label();     
        public Form1()
        {
            InitializeComponent();
        }        
        int sleepBall = 2;
        int sizeX = 100;
        int sizeY = 100;
        Random randomX = new Random();
        Random randomY = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {            
            button1.Hide();
            label1.Hide();
        }
        private void StartGame()
        {
            new Task(() =>
            {                
                button1.BackColor = Color.Firebrick;
                button1.Text = "Pop Ball";
                button1.Location = new Point((Form1.ActiveForm.Width - 60) / 2, Form1.ActiveForm.Height - 160);
                label1.Location = new Point((Form1.ActiveForm.Width - 20) / 2, Form1.ActiveForm.Height - 130);
            }).Start();
            button2.Hide();                    
            button1.Show();
            label1.Hide();
            this.Controls.Add(label2);
            label2.Hide();
            key = true;
        }

        private void BallMove(int ballNumber)
        { 
                int dx = 1;
                int dy = 1;
            key = !key;
            ballNumber1++;
            while (balls[ballNumber] != null)
            {
                balls[ballNumber].Location = new Point(balls[ballNumber].Location.X + dx, balls[ballNumber].Location.Y + dy);
                Thread.Sleep(sleepBall);
                if (balls[ballNumber].Location.X == Form1.ActiveForm.Width - 150)
                {
                    dx = -dx;
                }
                if (balls[ballNumber].Location.Y == Form1.ActiveForm.Height - 150)
                {
                    dy = -dy;
                }
                if (balls[ballNumber].Location.X == 0)
                {
                    dx = -dx;
                }
                if (balls[ballNumber].Location.Y == 0)
                {
                    dy = -dy;
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ballBomb == 10)
            {
                button1.Text = "Pop Ball";
                ballBomb = 0;
                label1.Text = $"Score: {ballBomb}";                           
            }
            if (key)
            {                
                key = !key;
                balls.Add(NewBall());                
                {
                    new Task(() =>
                    {
                        BallMove(ballNumber1);                        
                    }).Start();
                }
            }
        }
        
        private PictureBox NewBall()
        {
            
                int a = randomX.Next(Form1.ActiveForm.Width - 150);
                int b = randomY.Next(Form1.ActiveForm.Height - 150);
                PictureBox ball = new PictureBox()
                {
                    Image = Image.FromFile("C:\\Users\\yudal\\source\\repos\\popBall\\PopBall\\Resources\\BasketBall.jpg"),
                    Location = new Point(a, b),
                    Size = new Size(sizeX, sizeY),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                this.Controls.Add(ball);                
                ball.Click += new EventHandler(ball_Click);
           
            return ball;
        }

        private void ball_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Image.FromFile("C:\\Users\\yudal\\source\\repos\\popBall\\PopBall\\Resources\\Boom.jpg");
            new Task(() =>
            {
                Thread.Sleep(50);
                this.Controls.Remove(picture);
            }).Start();
            ballBomb++;
            label1.Show();
            if (ballBomb < 10)
            {
                label1.Text = $"Score: {ballBomb}";
            }
            else
            {
                label1.Text = $"Score: {ballBomb}";                
                label2.Text = "You Win!";
                label2.Size = new Size(150, 150);
                label2.Font = new Font("Arial", 20, FontStyle.Bold);
                label2.ForeColor = Color.Blue;
                label2.Location = new Point(590, 100);                             
                label2.Show();
                label1.Hide();
                button1.Hide();
                foreach (PictureBox ball in balls)
                {
                    this.Controls.Remove(ball);
                }               
                button2.Show();
            }
            
        }
        
        private void Ball_Mouse_Click(object sender, EventArgs e)
        {
           
        }

        private void ballPB_MouseClick(object sender, MouseEventArgs e)
        {            
            
        }
       

        private void ballPB2_MouseClick_1(object sender, MouseEventArgs e)
        {
           
        }
        
        private void ballPB3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ballPB4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ballPB5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        
        private void Form1_MouseClick(Object sender, MouseEventArgs e)
            
        {
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            StartGame();
        }
    }
}
