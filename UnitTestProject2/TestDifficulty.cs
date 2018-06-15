using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using IPFSBlockchain.Block_Primatives;

namespace IPFSBlockchainUnitTests
{
    [TestClass]
    public class TestDifficulty
    {
        //Test Blocks
        Mock<Block> TestBlock1 = new Mock<Block>();
        Mock<Block> TestBlock2 = new Mock<Block>();
        Mock<Block> TestBlock3 = new Mock<Block>();
        Mock<Block> TestBlock4 = new Mock<Block>();
        Mock<Block> TestBlock5 = new Mock<Block>();
        Mock<Block> TestBlock6 = new Mock<Block>();
        Mock<Block> TestBlock7 = new Mock<Block>();
        Mock<Block> TestBlock8 = new Mock<Block>();
        Mock<Block> TestBlock9 = new Mock<Block>();
        Mock<Block> TestBlock10 = new Mock<Block>();
        Mock<Block> TestBlock11 = new Mock<Block>();

        //Test List
        Mock<List<string>> mockList = new Mock<List<string>>();



        //add string of items to the mocklist
        private void addData()
        {
            mockList.Object.Add("QmbKxNNCxBox7Cmv3jiUZbiG3zpzmtnYzVUuKHxfAjvpyH");
            mockList.Object.Add("QmUSgfC3RsXKzKJuUNtpzDK2Wm4ehPxhQ1SxJMcgUqStxg");
            mockList.Object.Add("QmcniBv7UQ4gGPQQW2BwbD4ZZHzN3o3tPuNLZCbBchd1zh");
            mockList.Object.Add("QmVBEScm197eQiqgUpstf9baFAaEnhQCgzHKiXnkCoED2c");
        }



    }
}
