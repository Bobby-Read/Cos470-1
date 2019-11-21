﻿using Model;
using Model.Pieces;

using System;
using System.Text;

namespace ChessConsoleApp
{
    class ChessConsoleApp
    {
       
        public Game SetUp()
        {
            Game Game = new Game() { Board = new Piece[100][,] };

            Game.Board[0] = new Piece[8, 8];

            Game.Board[0][0, 1] = new Knight() { Color = Color.White, Location = new Vector(0, 1) };
            Game.Board[0][0, 6] = new Knight() { Color = Color.White, Location = new Vector(0, 6) };
            Game.Board[0][7, 1] = new Knight() { Color = Color.Black, Location = new Vector(7, 1) };
            Game.Board[0][7, 6] = new Knight() { Color = Color.Black, Location = new Vector(7, 6) };

            Game.Board[0][0, 2] = new Bishop() {Color = Color.White, Location = new Vector(0, 2) };
            Game.Board[0][0, 5] = new Bishop() { Color = Color.White, Location = new Vector(0, 5) };
            Game.Board[0][7, 2] = new Bishop() { Color = Color.Black, Location = new Vector(7, 2) };
            Game.Board[0][7, 5] = new Bishop() { Color = Color.Black, Location = new Vector(7, 5) };

            Game.Board[0][0, 0] = new Rook() { Color = Color.White, Location = new Vector(0, 0) };
            Game.Board[0][0, 7] = new Rook() { Color = Color.White, Location = new Vector(0, 7) };
            Game.Board[0][7, 0] = new Rook() { Color = Color.Black, Location = new Vector(7, 0) };
            Game.Board[0][7, 7] = new Rook() { Color = Color.Black, Location = new Vector(7, 7) };


            Game.Board[0][0, 4] = new King() { Color = Color.White, Location = new Vector(0, 4) };
            Game.Board[0][7, 4] = new King() { Color = Color.Black, Location = new Vector(7, 4) };


            for (int i = 0; i < 8; i++)
            {
                Game.Board[0][1, i] = new Pawn() { Color = Color.White, Location = new Vector(1, i) };
                Game.Board[0][6, i] = new Pawn() { Color = Color.Black, Location = new Vector(6, i) };
            }

            return Game;
        }

        static void Main(string[] args)
        {
            ChessConsoleApp app = new ChessConsoleApp();
            Game game = app.SetUp();

            Console.OutputEncoding = Encoding.Unicode;

            Console.Write( Render.AsAscii(game.Board[0]));
            Console.ReadKey(true);
        }
    }
}