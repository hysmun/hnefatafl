using System.ComponentModel;

namespace HnefataflLib;

public enum PieceType
{
    N = 0,

    [Description("White")]
    W = 1,

    [Description("White")]
    B = 2,

    [Description("White")]
    K = 4

}

public static class PieceTypeExtension
{

    public static PieceType ToPieceType(this char s)
    {
        switch (s)
        {
            case 'N':
                return PieceType.N;
            case 'B':
                return PieceType.B;
            case 'K':
                return PieceType.K;
            case 'W':
                return PieceType.W;
        }

        return PieceType.N;
    }

}
