using IPFSBlockchain.Block_Primatives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchainUnitTests
{
    [TestClass]
    public class TestHashing
    {
        Mock<List<string>> mockList = new Mock<List<string>>();
        Mock<Block> mockBlock = new Mock<Block>();

        [TestMethod]
        public void TestBlock()
        {
        //Arrange
            addData();
            LinkedList<Block> blockchain = new LinkedList<Block>();
            Block testBlock01 = new Block(mockList.Object, "0");
            blockchain.AddLast(testBlock01);
            Block testblock02 = new Block(mockList.Object, testBlock01.Hash);
            blockchain.AddLast(testblock02);
            Block testblock03 = new Block(mockList.Object, testblock02.Hash);

            foreach(Block item in blockchain)
            {
                Assert.AreEqual("7563AF9DBBED6E45941F422B85B43199EC03F709CCA4E996B6D5886097F90180D11CF05D978A2C4EFBAE154E43B0D456C2FA30EF79D4D80E2B5D731D84F6D53E",
                    testBlock01.Hash);

                Assert.AreEqual("BE8016723192F49EBCD71A538E54E3AE720D1D4C55381310FD55D9FA4416A217B74FC929B340FBD58D9D3F78D72B33AA26D8000E326EDAB6921211ED26A6DBDC",
                    testblock02.Hash);

                Assert.AreEqual("FBDD9167E37BCDCDF3D89E61290F7796710A38831272116E659AAE1A1ADD63C5E7E965315F710161D35F3C17D64CCEF3DFD1B9CC859B1BDA4CF0773D3E3222D6",
                    testblock03.Hash);
            }

      
        }
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
