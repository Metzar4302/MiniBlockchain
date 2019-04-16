﻿using System;
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

            List<Transaction> new_transaction_2 = new List<Transaction>(){
                new Transaction("Vasya", "228"),
                new Transaction("Ahmed", "1488")
            };
            
            Blockchain bCh = new Blockchain();
            bCh.AddBlock(new_transaction);
            bCh.AddBlock(new_transaction_2);

            // ViewBlocks(bCh);

            // //! Test
            // System.Console.WriteLine(bCh.chain[2].transactions[1].Value);
            // bCh.chain[2].transactions[1].Value = "FAKE";
            // System.Console.WriteLine(bCh.chain[2].transactions[1].Value);
            // bCh.ValidateChain();
            // ViewBlocks(bCh);
            
        }

        static void BlockSplit(int len = 80, ConsoleColor color = ConsoleColor.White){
            Console.ForegroundColor = color;
            Console.WriteLine($"{new String('=', len)}");
            Console.ResetColor();
        }

        static void ViewBlocks(Blockchain blockChain){
            foreach (var item in blockChain.chain){
                Console.WriteLine($"{item}");
                BlockSplit(80, ConsoleColor.Green);
            }
        }
    }
}
