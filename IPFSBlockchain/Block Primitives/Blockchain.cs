using IPFSBlockchain.Block_Primatives.Helpers;
using IPFSBlockchain.Block_Primitives.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primatives 
{
    public class Blockchain : IBlockChain
    {
        static private LinkedList<Block> Chain = new LinkedList<Block>();
        

        public Blockchain(Block firstBlock)
        {
            LinkedListNode<Block> node = new LinkedListNode<Block>(firstBlock);
            Chain.AddLast(firstBlock);
        }

        public LinkedListNode<Block> LastBlock { get { return Chain.Last; } }
        public int Count { get { return Chain.Count; } }
        

        public void Add(Block block)
        {
            block.BlockNumber = Chain.Count64()+1;
            Difficulty diff = new Difficulty(block.Difficulty, this);
            block.Difficulty = diff.calculateNext();
            Chain.AddLast(block);
        }

        public bool IsValid()
        {
            LinkedListNode<Block> node = Chain.Last;
            LinkedListNode<Block> lastNode = node.Previous;
            if(node.Value.Hash != node.Value.CalculateHash())
            {
                return false;
            }
            else if(lastNode.Value.Hash != node.Value.LastHash)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Block[] ToArray()
        {
            Block[] lastBlocks = new Block[Chain.Count];
            Chain.CopyTo(lastBlocks, 0);
            return lastBlocks;
        }




    }
}
