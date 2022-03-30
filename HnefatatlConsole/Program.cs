

using HnefataflLib;

namespace HnefatatlConsole
{
    public sealed class Program
    {

        private Program()
        {
        }

        internal static async Task Main(string[] args)
        {
            var b = new Board();
            b.PlacePiece();

            Console.WriteLine(b.ToString());
            Console.WriteLine();

            Console.WriteLine(b.GetData());
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}