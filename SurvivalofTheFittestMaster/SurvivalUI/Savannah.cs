using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurvivalBoard;

namespace SurvivalUI
{
    public partial class Savannah : Form
    {
        SurvivalController sc = new SurvivalController();
        Lion l = new Lion();
        Rabbit r = new Rabbit();
        PictureBox[,] pb = new PictureBox[20, 20];
        public Savannah()
        {
            InitializeComponent();
            sc.PlaceOneAnimal(l, 4, 4);
            sc.PlaceOneAnimal(r, 1, 1);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    pb[i, j] = new PictureBox();
                    pb[i, j].Location = new Point(i * 25 + 100, j * 25 + 100);
                    pb[i, j].Width = 25;
                    pb[i, j].Height = 25;
                    pb[i, j].Tag = null;
                    pb[i, j].Visible = true;
                    pb[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pb[i, j].BringToFront();
                    Controls.Add(pb[i, j]);
                }
            }

            FillBoard();
        }
        private void FillBoard()
        {
            foreach (Tile t in sc.GetBoardTiles())
            {
                if (t.Animal == null)
                {
                    pb[t.Row, t.Collum].BackColor = Color.LightGoldenrodYellow;
                    if (t.Grass == true)
                        pb[t.Row, t.Collum].BackColor = Color.Green;
                    
                }

                if (t.Animal != null)
                {
                    if (t.Animal.Species == 'L')
                    {
                        pb[t.Row, t.Collum].BackColor = Color.Red; //hvis et animal er en lion sker dette
                    }

                    if (t.Animal.Species == 'R')
                    {
                        pb[t.Row, t.Collum].BackColor = Color.Gray; //hvis et animal er en lion sker dette
                    }
                }
                //else //overskriver linje 46-52 cirka
                //{
                //    pb[t.Row, t.Collum].BackColor = Color.White;
                //}
            }
        }
    }
}
