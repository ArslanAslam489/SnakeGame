using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class Snake : Form
    {
        private List<Position_snake>Snake_game=new List<Position_snake>();
        private Position_snake FoodItem = new Position_snake();
        SnakeSettings Attribute = new SnakeSettings();
        //SnakeSettings SnakeSettings = new SnakeSettings();
        public Snake()
        {
            MessageBox.Show("Start");
            InitializeComponent();
             new SnakeSettings();
            GameTimer.Interval = 1000 / Attribute.speed;
            GameTimer.Tick += new EventHandler(UpdateScreen);
            GameTimer.Start();
            
            StartGame();

        }

        private  void UpdateScreen(object sender,EventArgs e)
        {
            if (SnakeSettings.GameOver == true)
            {
                
                if (Button_Detector.ButtonPressed(Keys.Enter))
                {
                    StartGame();
                }

            }
            else
            {
                if (Button_Detector.ButtonPressed(Keys.Left) && Attribute.Move != Movement.Right)
                {
                    Attribute.Move = Movement.Left;

                }
                else if (Button_Detector.ButtonPressed(Keys.Right) && Attribute.Move != Movement.Left)
                {
                    Attribute.Move = Movement.Right;
                }
                else if (Button_Detector.ButtonPressed(Keys.Up) && Attribute.Move != Movement.Bottom)
                {
                    Attribute.Move = Movement.Up;
                }
                else if (Button_Detector.ButtonPressed(Keys.Down) && Attribute.Move != Movement.Up)
                {
                    Attribute.Move = Movement.Bottom;
                }
                SnakeMoving();
            }
            GameScreen.Invalidate();
        }

        //private EventHandler UpdateScreen()
        //{
           
        //}

        //private void UpdateScreen(object sender, EventArgs e)
        //{
            
        //}

        //private EventHandler ScreenShow(object sender, EventArgs e)
        //{
            //throw new NotImplementedException();
       // }

       // private EventHandler ScreenShow()
       // {
            
       // }


        private void pictureBox1_Click(object sender, EventArgs e)
        { 

        }
        private void StartGame()
        {
            label2.Visible = false;
            speed.Visible = false;
           new SnakeSettings();
            //Attribute.GameOver = true;
            Snake_game.Clear();
           // MessageBox.Show("LL");
            Position_snake Face = new Position_snake();
            Face.Horizontal = 24;
            Face.Vertical = 20;
            Snake_game.Add(Face);
            FoodShow();
           
     

        }
        private void FoodShow()
        {
            //Attribute Attribute = new Attribute();
            int HorizontalSnakePosition = GameScreen.Size.Width /Attribute.width;
            int VerticalSnakePosition = GameScreen.Size.Height / Attribute.height;
            Random FoodObjects = new Random();
            FoodItem = new Position_snake();

            FoodItem.Horizontal = FoodObjects.Next(0,HorizontalSnakePosition);
            FoodItem.Vertical = FoodObjects.Next(0,VerticalSnakePosition);
            //MessageBox.Show("LL");
        }
        //private void UpdateScreen(object sender, EventArgs e)
        //{
           

        //}
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Graphics convas = e.Graphics;
            //MessageBox.Show("Paint");
            
            if(SnakeSettings.GameOver==false)
            {
                //e.Graphics.FillRectangle(Brushes.Green,10,1000,100,100);
               // MessageBox.Show("ssss");
                Brush SnakeColor;
                for (int i = 0; i < Snake_game.Count;i++ )
                {
                    if (i == 0)
                    {
                        SnakeColor = Brushes.LightCyan;
                    }
                    else
                        SnakeColor = Brushes.Green;
                    e.Graphics.FillRectangle(SnakeColor, new Rectangle(Snake_game[i].Horizontal*Attribute.width,Snake_game[i].Vertical*Attribute.height,Attribute.width,Attribute.height));
                    e.Graphics.FillRectangle(Brushes.YellowGreen,new Rectangle(FoodItem.Horizontal*Attribute.width,FoodItem.Vertical*Attribute.height,Attribute.width,Attribute.height));
                }
                    

            }
            else
            {
                string gameover = "game Over";
                Attribute.Move = Movement.Up;
                label2.Text = gameover;
                label2.Visible = true;
                speed.Visible = true;
            }
        }
        private void SnakeMoving()
        {
            for(int i=Snake_game.Count -1; i>=0; i--)
            {
                if(i==0)
                {
                    switch (Attribute.Move)
                    {
                        case Movement.Left:
                            Snake_game[i].Horizontal--;
                            break;
                        case Movement.Up:
                            Snake_game[i].Vertical--;
                            break;
                        case Movement.Right:
                            Snake_game[i].Horizontal++;
                            break;
                        case Movement.Bottom:
                            Snake_game[i].Vertical++;
                            break;
                    }
                    int HorizontalSnakePosition = GameScreen.Size.Width / Attribute.width;
                    int VerticalSnakePosition = GameScreen.Size.Height / Attribute.height;
                    if(Snake_game[i].Horizontal>=HorizontalSnakePosition||Snake_game[i].Horizontal<0||Snake_game[i].Vertical>=VerticalSnakePosition||Snake_game[i].Vertical<0)
                    {
                        SnakeSettings.GameOver = true;
                    }
                    if(Snake_game[0].Horizontal==FoodItem.Horizontal&& Snake_game[0].Vertical==FoodItem.Vertical)
                    {
                        Snake_game.Add(FoodItem);
                        FoodShow();
                    }
                }
                else
                {
                    Snake_game[i].Horizontal=Snake_game[i-1].Horizontal;
                    Snake_game[i].Vertical = Snake_game[i - 1].Vertical;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            Button_Detector.ButtonChanged(e.KeyCode,true);
        }

        private void Snake_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Detector.ButtonChanged(e.KeyCode,false);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
  
    }

    
}
