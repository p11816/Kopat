﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class GameField : Form, IControler, Iview
    {
        private GameModel model = new GameModel();
        private Button[,] field;
        Dictionary<GameModel.State, string> symbols = new Dictionary<GameModel.State,string>();
        public GameField()
        {
            InitializeComponent();
            symbols[GameModel.State.X] = "X";
            symbols[GameModel.State.O] = "O";
            symbols[GameModel.State.none] = "";

            field = new Button[3,3];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); i++)
                {
                    Button b = new Button();
                    b.Left = i * 50 + 10;
                    b.Top = j * 50 + 10;
                    b.Size = new Size(40, 40);
                    b.Tag = new Point(i, j);
                    b.Click += GameField_Click;
                    //добавляем кнопку на форму
                    this.Controls.Add(b);
                    //добавили кнопку в массив
                    field[i,j] = b;
                }
            }
            model.UpdateView += UpdateView;
        }
        //обработчик для кнопки
        void GameField_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //координаты кнопки
            Point p = (Point)b.Tag;
            try
            {
                this.MakeMove(p.X, p.Y, model.CurrentMove);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void UpdateView(GameModel model)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); i++)
                {

                    field[i, j].Text = symbols[model.Field[i, j]]; 
                }
            }
        }
        public void MakeMove(int i, int j, GameModel.State side)
        {
            model.MakeMove(i, j, side);
        }
    }
}
