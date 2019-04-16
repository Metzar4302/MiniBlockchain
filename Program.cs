using System;
using System.Collections.Generic;

namespace MiniBlockChain
{
    class Program{
        static void Main(string[] args){
            List<Transaction> new_transaction = new List<Transaction>(){
                new Transaction("Vasya", "50"),
                new Transaction("Alex", "21"),
                new Transaction("Ahmed", "777")
            };
            
            Blockchain bCh = new Blockchain();
            bCh.AddBlock(new_transaction);

            foreach (var item in bCh.chain){
                Console.WriteLine($"{item}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{new String('=', 80)}");
                Console.ResetColor();
            }
        }
    }
}
