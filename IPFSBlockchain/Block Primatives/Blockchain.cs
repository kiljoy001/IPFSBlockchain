using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primatives
{
    public class Blockchain
    {
        static private LinkedList<Block> Chain;
        public Blockchain(Block firstBlock)
        {
            LinkedListNode<Block> node = new LinkedListNode<Block>(firstBlock);
            Chain.AddLast(firstBlock);
        }

        public void Add(Block block)
        {
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

    }
}
