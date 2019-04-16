using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MiniBlockChain {
    public class Block {
        public string transactions;
        public string previous_hash;
        public string hash;
        public int nonce;
        public DateTime timestamp = DateTime.Now;

        public override string ToString () {
            return $"{transactions}\n{timestamp}\nPrev hash:\t{previous_hash}\nHash:\t\t{hash}\nNonce: {nonce}";
        }

        public Block (string transactions, string previous_hash, int nonce = 0) {
            this.transactions = transactions;
            this.previous_hash = previous_hash;
            this.nonce = nonce;

            this.hash = GenerateHash();
        }

        public string GenerateHash() {
            using (SHA256 sha256Hash = SHA256.Create ()) {
                string blockData = this.transactions + this.previous_hash + this.nonce;
                string hash = GetHash (sha256Hash, blockData);
                return hash;
            }
        }

        private string GetHash (HashAlgorithm hashAlgorithm, string input) {
            byte[] data = hashAlgorithm.ComputeHash (Encoding.UTF8.GetBytes (input));

            var sBuilder = new StringBuilder ();

            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append (data[i].ToString("x2"));
            }

            return sBuilder.ToString ();
        }
    }
}