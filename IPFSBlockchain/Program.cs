using IPFSBlockchain.Block_Primatives;
using IPFSBlockchain.Block_Primatives.Helpers;
using IPFSBlockchain.Block_Primitives;
using System;
using System.Collections.Generic;

namespace IPFSBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "QmbKxNNCxBox7Cmv3jiUZbiG3zpzmtnYzVUuKHxfAjvpyH" , "QmUSgfC3RsXKzKJuUNtpzDK2Wm4ehPxhQ1SxJMcgUqStxg" ,
            "QmcniBv7UQ4gGPQQW2BwbD4ZZHzN3o3tPuNLZCbBchd1zh","QmVBEScm197eQiqgUpstf9baFAaEnhQCgzHKiXnkCoED2c"};
            Block testblock1 = new Block(list, "0");
            Block testblock2 = new Block(list, testblock1.Hash);
            Block testblock3 = new Block(list, testblock2.Hash);
            Block firstTestBlock = new Block(list, "0");
            Console.WriteLine($"Test Block 1:{testblock1.Hash} \nTest Block 2:{testblock2.Hash} \nTest Block 3:{testblock3.Hash}");
            Console.ReadLine();
            ulong testSubstring = 123456789;
            string setup = testSubstring.ToString();
            Console.WriteLine(setup.Substring(0, testSubstring.ToString().Length));
            Console.ReadLine();
            int difficulty = 1;
            string test = new string (new char[difficulty]).Replace('\0', '0');
            Console.WriteLine($"{test}");
            Console.ReadLine();
            Blockchain chain = new Blockchain(firstTestBlock);
            Difficulty testDifficulty = new Difficulty(1, chain);
            firstTestBlock.MiningBlock(testDifficulty.calculateNext(), list);
            Console.WriteLine($"Chain height: {chain.Count}");
            Console.ReadLine();
        }

        private Header[] Create_headers(int arraySize)
        {
            Header[] headerArray = new Header[arraySize];
            for(int i = 0; i > arraySize; i++)
            {

            }
        }
    }
}
