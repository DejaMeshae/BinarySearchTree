using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAssignment
{
    class Binary_Tree
    {
        //member variables 
        public Nodes root;
        int[] numbers = new int[] { 1, 3, 5, 7, 9, 11, 12, 13, 16, 17, 20, 35, 39, 41, 46, 50 }; //array of numbers

        public Binary_Tree()
        {
            root = null;
        }

        public Binary_Tree(int start)
        {
            root = new Nodes(start);//create first node and carry in value i passed to it
        }

        public Nodes Add(Nodes root, int numbers)
        {
            if (root == null) //checking if the tree is empty and if it is create new node
            {
                //add 
                Nodes NewNode = new Nodes(numbers); //create new node
                root = NewNode; //assigns it as the root
            }
          else if (numbers < root.data) //if data is less than start data
            {
                root.left = Add(root.left, numbers);
            }
            else
            {
                root.right = Add(root.right, numbers);
            }
            return root;
        }
        



    }
}
