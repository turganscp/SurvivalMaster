using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    public class SurvivalController
    {
        private Board b; //specifikt board
        public SurvivalController()
        {
                b = new Board();
        }

        public void PlaceOneAnimal(Animal animal, int row, int col)
        {
            b.PlaceAnimal(animal, row,col);
        }
        public Tile[,] GetBoardTiles()
        {
            return b.GetTiles(); //referer tilbage til arrayet tidligere
        }





    }
}
