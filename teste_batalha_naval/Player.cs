using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_batalha_naval
{
    internal class Player
    {
        public string _name { get; set; }
        public int _life { get; set; }
        public Submarine _submarine { get; set; }
        public Destroyer _destroyer { get; set; }
        public AircraftCarrier _aircraftCarrier { get; set; }
        Board _board;

        public Player()
        {
            this._life = 9;
            this._submarine = new Submarine();
            this._destroyer = new Destroyer();
            this._aircraftCarrier = new AircraftCarrier();
            this._board = new Board();
        }

        public void TakeLife()
        {
            this._life--;
        }

        public int Shot(int row, int col)
        {
            return this._board.VerifyShot(row, col);

            /*for(int i = 0; i < this._submarine._positions.GetLength(0); i++)
            {
                if (this._submarine._positions[i, 0] == row)
                {
                    if (this._submarine._positions[i, 1] == col)
                    {
                        TakeLife();
                        return true;
                    }
                }
            }

            for (int i = 0; i < this._destroyer._positions.GetLength(0); i++)
            {
                if (this._destroyer._positions[i, 0] == row)
                {
                    if (this._destroyer._positions[i, 1] == col)
                    {
                        TakeLife();
                        return true;
                    }
                }
            }

            for (int i = 0; i < this._aircraftCarrier._positions.GetLength(0); i++)
            {
                if (this._aircraftCarrier._positions[i, 0] == row)
                {
                    if (this._aircraftCarrier._positions[i, 1] == col)
                    {
                        TakeLife();
                        return true;
                    }
                }
            }*/
        }

        public void InsertOnShipBoard(int[] positions, Ship ship, Player player, string orientation, int direction){
            int row = positions[0];
            int column = positions[1];
            if (ship._name == "AircraftCarrier")
            {
                if(orientation == "horizontal" && direction == 1)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        column++;
                    }
                    
                }
                else if(orientation == "horizontal" && direction == 2)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        column--;
                    }
                }
                else if(orientation == "vertical" && direction == 1)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        row++;
                    }
                }
                else if(orientation == "vertical" && direction == 2)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        row--;
                    }
                }
            }
            else if (ship._name == "Destroyer")
            {
                if(orientation == "horizontal" && direction == 1)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        column++;
                    }
                    
                }
                else if(orientation == "horizontal" && direction == 2)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        column--;
                    }
                }
                else if(orientation == "vertical" && direction == 1)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        row++;
                    }
                }
                else if(orientation == "vertical" && direction == 2)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        row--;
                    }
                }
            }
            else if (ship._name == "Submarine")
            {
                if(orientation == "horizontal" && direction == 1)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        column++;
                    }
                    
                }
                else if(orientation == "horizontal" && direction == 2)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        column--;
                    }
                }
                else if(orientation == "vertical" && direction == 1)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        row++;
                    }
                }
                else if(orientation == "vertical" && direction == 2)
                {
                    for(int i = 0; i < player._aircraftCarrier._positions.GetLength(0); i++)
                    {
                        int j = 0;
                        player._aircraftCarrier._positions[i, j] = row;
                        j++;
                        player._aircraftCarrier._positions[i, j] = column;
                        row--;
                    }
                }
            }
        }
    }
}
