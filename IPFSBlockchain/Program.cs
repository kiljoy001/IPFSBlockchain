using IPFSBlockchain.Block_Primatives;
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

            Console.WriteLine($"Test Block 1:{testblock1.Hash} \nTest Block 2:{testblock2.Hash} \nTest Block 3:{testblock3.Hash}");
            Console.ReadLine();

        }
    }
}
