using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimicoGameLibrary.Objects.Levels;
using TimicoGameLibrary.Objects.Characters;
using TimicoGameLibrary.Objects.Players;

namespace TimicoGameForm
{
    public partial class GameArea : UserControl
    {
        List<List<GameSquare>> gameSquares = new List<List<GameSquare>>();
        private readonly Color DefaultSquareColor = Color.White;
        Level currentLevel;
        Player player;

        public GameArea()
        {
            InitializeComponent();
        }

        public void InitialiseLevel(Level level, Player player)
        {
            this.currentLevel = level;
            this.player = player;
            DrawGrid();
            SetPlayerLocations();
            UpdateGridColours();
        }

        private void SetPlayerLocations()
        {
            foreach(Character character in currentLevel.GetEnemies())
            {
                gameSquares[character.GetLocation().X][character.GetLocation().Y].populatedBy = character;
            }
            player.SetLocation(currentLevel.GetPlayerStartLocation().X, currentLevel.GetPlayerStartLocation().Y);
            gameSquares[player.GetLocation().X][player.GetLocation().Y].populatedBy = player;
        }

        private void UpdateGridColours()
        {
            gameSquares.ForEach(x => x.ForEach(y =>
                y.BackColor = (y.populatedBy == null) ?(DefaultSquareColor) :(y.populatedBy.GetColour())            
            ));
        }

        private void ClearGrid()
        {
            this.Controls.Clear();
            this.gameSquares.Clear();
        }

        public void DrawGrid()
        {
            ClearGrid();
            int squareSizeX = this.Width / currentLevel.GetScale().X;
            int squareSizeY = this.Height / currentLevel.GetScale().Y;
            for(int x = 0; x < currentLevel.GetScale().X; x++)
            {
                List<GameSquare> gameSquareListX = new List<GameSquare>();
                for (int y = 0; y < currentLevel.GetScale().Y; y++)
                {
                    GameSquare square = CreateSquare(squareSizeX, squareSizeY);
                    square.Location = new Point(x * squareSizeX, y * squareSizeY);
                    this.Controls.Add(square);
                    gameSquareListX.Add(square);
                }
                gameSquares.Add(gameSquareListX);
            }
        }

        private GameSquare CreateSquare(int sizeX, int sizeY)
        {
            GameSquare gameSquare = new GameSquare();
            gameSquare.Width = sizeX;
            gameSquare.Height = sizeY;
            gameSquare.BorderStyle = BorderStyle.FixedSingle;
            return gameSquare;
        }
    }
}
