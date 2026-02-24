using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace upgift_till_max
{
    public partial class Form1 : Form
    {
        List<PointF> snare = new List<PointF>(); // list att spara alla delar av ormen
        int score = 0; // variabel för att hålla koll på poängen
        string Direction = "right"; // variabel för att hålla koll på riktningen
        float MoveSpeed = 15; // variabel för att bestämma hur snabbt ormen rör sig
        float x = 300; // startposition för ormen i x axeln
        float y = 120; // startposition för ormen i y axeln
        float Foodsize = 15; // variabel för att bestämma storleken på maten
        int Foodx = 180; // startposition för maten i x axeln
        int Foody = 120; // startposition för maten i y axeln
        Random rand = new Random(); // en random generator för att slumpa fram positionen på maten

        public Form1()
        {
            InitializeComponent();
            KeyDown += form1_KeyDown;
            InitSnake(); // en funktion som skapar ormen med startlängd 4
        }

        private void InitSnake() // skapar ormen med startlängd 4
        {
            snare.Clear();
            snare.Add(new PointF(x - MoveSpeed, y));
            snare.Add(new PointF(x - MoveSpeed * 2, y));
            snare.Add(new PointF(x - MoveSpeed * 3, y));
        }

        protected override void OnPaint(PaintEventArgs draw)
        {
            draw.Graphics.FillEllipse(new SolidBrush(Color.DarkViolet), x, y, MoveSpeed, MoveSpeed);
            draw.Graphics.FillEllipse(new SolidBrush(Color.Red), Foodx, Foody, Foodsize, Foodsize);

            foreach (PointF part in snare) // loop för att rita ut alla delar av ormen
            {
                draw.Graphics.FillEllipse(new SolidBrush(Color.DarkViolet), part.X, part.Y, MoveSpeed, MoveSpeed);
            }
        }

        private void form1_KeyDown(object sender, KeyEventArgs e) // en funktion för alla knappar som styr ormen
        {
            if (e.KeyCode == Keys.W && Direction != "down")
                Direction = "up";

            if (e.KeyCode == Keys.S && Direction != "up")
                Direction = "down";

            if (e.KeyCode == Keys.A && Direction != "right")
                Direction = "left";

            if (e.KeyCode == Keys.D && Direction != "left")
                Direction = "right";
        }

        public void Death() // en funktion som kollar om ormen är i sig själv eller utanför gränserna och då dör den
        {
            if (x < 0 || x > 570 || y < 0 || y > 320)
            {
                ResetGame();
                return;
            }

            foreach (PointF part in snare)
            {
                if (part.X == x && part.Y == y)
                {
                    ResetGame();
                    return;
                }
            }
        }

        private void ResetGame() // startar om spelet och nollar alla variabler
        {
            Penistimer.Stop();
            MessageBox.Show("You died");
            x = 300;
            y = 120;
            score = 0;
            scorebord.Text = "Score: 0";
            Direction = "right";
            InitSnake();
            Penistimer.Start();
        }

        private void Penistimer_Tick(object sender, EventArgs e) // en timer :)
        {
            snare.Insert(0, new PointF(x, y));

            switch (Direction) // en switch som ändrar hur ormen rör sig beroende på vilken riktning den har
            {
                case "up":
                    y -= MoveSpeed;
                    break;
                case "down":
                    y += MoveSpeed;
                    break;
                case "left":
                    x -= MoveSpeed;
                    break;
                case "right":
                    x += MoveSpeed;
                    break;
            }

            if (Foody == y && Foodx == x) // en if som kollar om ormen äter äpplet
            {
                Foodx = rand.Next(0, 38) * 15;
                Foody = rand.Next(0, 20) * 15;
                score++;
                scorebord.Text = "Score: " + score.ToString();
            }
            else // om ormen inte äter så tar den bort den sista delen av ormen så att den inte växer
            {
                if (snare.Count > 0)
                    snare.RemoveAt(snare.Count - 1);
            }

            Death();
            Refresh();
        }

        private void updbtn_Click(object sender, EventArgs e) // en knapp som stänger ner spelet (bara för roligt)
        {
            this.Close();
        }
    }
}