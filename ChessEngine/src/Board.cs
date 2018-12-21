using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static ChessEngine.Common.Singletons;
using ChessEngine.Extensions;
using ChessEngine.Interfaces;

namespace ChessEngine
{
    public class Board : IBoard
    {
        public Dictionary<string, ISquare> Squares { get; } = new Dictionary<string, ISquare>();
        public Board()
        {
            var rankIndex = 0;
            var fileIndex = 0;
            for (int i = 0; i < 64; i++)
            {
                if (i % 8 == 0 && i > 0)
                {
                    rankIndex++;
                    fileIndex = 0;
                }
                Squares.Add(File[fileIndex]+Rank[rankIndex], new Square(File[fileIndex], Rank[rankIndex]));
                fileIndex++;
            }
        }
    }
}