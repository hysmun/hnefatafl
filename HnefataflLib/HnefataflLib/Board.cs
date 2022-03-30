using System.Text;

namespace HnefataflLib
{
    public class Board
    {

        public static int Size = 11;

        public static string PlacementPiece =  
            "NNNBBBBBNNN" +
            "NNNNNBNNNNN" +
            "NNNNNNNNNNN" +
            "BNNNNWNNNNB" +
            "BNNNWWWNNNB" +
            "BBNWWKWWNBB"  +
            "BNNNWWWNNNB" +
            "BNNNNWNNNNB" +
            "NNNNNNNNNNN" +
            "NNNNNBNNNNN" + 
            "NNNBBBBBNNN" +
            "";

        public int[][] Boards;

        public Board()
        {
            InitBoard();
        }

        public void InitBoard()
        {
            Boards = new int[Size][];

            for (var index = 0; index < Boards.Length; index++)
            {
                Boards[index] = new int[Size];
            }
        }

        public void PlacePiece()
        {
            FromData(PlacementPiece);
        }

        public string GetData()
        {
            var sb = new StringBuilder();
            foreach (var board in Boards)
            {
                foreach (var i in board)
                {
                    sb.Append((PieceType)i);
                }
            }

            return sb.ToString();
        }

        public void FromData(string s)
        {
            if (s.Length != Size * Size)
                throw new IndexOutOfRangeException();
            InitBoard();
            int iter = 0;

            for (var i = 0; i < Boards.Length; i++)
            {
                var board = Boards[i];

                for (var j = 0; j < board.Length; j++)
                {
                    board[j] = (int)s[iter].ToPieceType();
                    iter++;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var board in Boards)
            {
                foreach (var i in board)
                {
                    var piece = (PieceType)i;
                    if(piece != PieceType.N)
                        sb.Append(piece);
                    else
                        sb.Append(" ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}