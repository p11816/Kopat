using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    class GameModel
    {
        enum State
        {
            X,
            O,
            none
        }

        public GameModel()
        {
            Field = new State[3, 3]; 
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); i++)
                {
                    Field[i, j] = State.none;
                }
            }
            CountStep = 0;
            Winner = State.none;
            GameOver = false;
            CurrentMove = State.X;
        }
        public State[,] Field { get; private set; }
        public int CountStep { get; private set; }
        public State Winner  { get; private set; }
        public bool GameOver { get; private set; }
        public State CurrentMove { get; private set; }
        public delegate void UpdateViewDelegate();
        public event UpdateViewDelegate UpdateView;
        public void MakeMove(int i, int j, State side)
        {
            if(GameOver)
            {
                throw new Exception("Game is already over!");
            }
            if (i < 0 || i > 2 || j < 0 || j > 2)
            {
                throw new IndexOutOfRangeException("Index out of view!");
            }
            if(side != CurrentMove)
            {
                throw new Exception("It is not your turn!");
            }
            if(Field[i,j] != State.none)
            {
                throw new Exception("Not empty field!");
            }

            Field[i, j] = side;
            CountStep++;
            CheckForGameOver();
            CurrentMove = side == State.O ? State.X : State.O;
        }
        private void CheckForGameOver()
        {
            if(CountStep < 5)
            {
                return;
            }
            //проверку на выстроенную линию и т.д.
 	        throw new NotImplementedException();
        }
    }
}
