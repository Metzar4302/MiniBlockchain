using System;

namespace MiniBlockChain
{
    class Program{
        static void Main(string[] args){
            Blockchain bCh = new Blockchain();
            bCh.AddBlock();

            foreach (var item in bCh.chain){
                Console.WriteLine($"{item}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{new String('=', 80)}");
                Console.ResetColor();
            }
        }
    }
}
