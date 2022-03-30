using System.ComponentModel;

namespace HnefataflLib;

public enum BoardCase
{

    [Description("Coin")]
    Coin = 1,
    [Description("BlackZone")]
    BlackZone = 2,
    [Description("WhiteZone")]
    WhiteZone = 4,
    [Description("KingCase")]
    KingCase = 8

}
