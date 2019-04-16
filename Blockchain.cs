using System;
using System.Collections.Generic;

namespace MiniBlockChain
{
    public class Blockchain
    {
        public List<Block> chain = new List<Block>();
        public List<Block> unverTransacts = new List<Block>();
        public List<Block> allTransactions = new List<Block>();
        
        public Blockchain(){
            GenesisBlock();
        }

        private void GenesisBlock(){
            Block block = new Block(new List<Transaction>(), new String('0', 64));
            this.chain.Add(block);
        }

        public void AddBlock(List<Transaction> transactions){
            Block block = new Block(transactions, chain[chain.Count - 1].hash);
            this.chain.Add(block);
        }

        public bool ValidateChain(){
            for (int i = 1; i < this.chain.Count; i++){
                Block current = this.chain[i];
                Block previous = this.chain[i-1];
                if (current.hash != current.GenerateHash()){
                    System.Console.WriteLine("The current hash of the block does not equal the generated hash of the block");
                    return false;
                }
                if (previous.hash != previous.GenerateHash()){
                    System.Console.WriteLine("The previous block's hash does not equal the previous hash value stored in the current block");
                    return false;
                }
            }
            return true;
        }
    }
}