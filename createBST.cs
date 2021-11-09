﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDay15
{
    class createBST<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get;
            set;
        }
        public createBST<T> LeftTree  //For LeftTree Generic getter and setter method use here. 
        {
            get;
            set;
        }
        public createBST<T> RightTree //For RightTree Generic getter and setter method use here 
        {
            get;
            set;
        }

        public createBST(T nodeData)    //here Constructor user for initialize the instance vaiables
        {
            this.NodeData = nodeData;   //here node data assigned to instance variable
            this.LeftTree = null;       //here initialy Lefttree node is null
            this.RightTree = null;      //here initialy Righttree node is null
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
       
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;          //here create a tree type new node

            if ((currentNodeValue.CompareTo(item)) > 0)  //here compare root data and newData
            {
                if (this.LeftTree == null)               //here lefttree is null then assigned to newNode
                {
                    this.LeftTree = new createBST<T>(item);
                }
                else
                    this.LeftTree.Insert(item);          //here lefttree is not null then insert data
            }
            else
            {
                if (this.RightTree == null)             //here righttree is null then assigned to newNode
                {
                    this.RightTree = new createBST<T>(item);
                }
                else
                    this.RightTree.Insert(item);        //here righttree is not null then insert data
            }
        }

        public void display()                   //here use Display
        {
            if (this.LeftTree != null)          // till left tree is not null 
            {
                this.leftCount++;               //here Count left Node 
                this.LeftTree.display();        //recursive call display method
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)         // till right tree is not null
            {
                this.rightCount++;              //here Count right Node
                this.RightTree.display();       //recursive call display method
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IFExits(T element, createBST<T> Node)
        {
            if (Node == null)                             //node is null then false
            {
                return false;
                
            }
            if (Node.NodeData.Equals(element))            //both search element find then return true "Equals Method"
            {
                Console.WriteLine("\n Fount the element in BST" + "" + Node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("\n Current Element is {0} in BST", Node.NodeData);
            }
            if (element.CompareTo(Node.NodeData) < 0)     //CompareTo both element
            {
                IFExits(element, Node.LeftTree);          //insert at left tree           
            }
            if (element.CompareTo(Node.NodeData) > 0)     //CompareTo both element 
            {
                IFExits(element, Node.RightTree);         //insert at right tree
            }
            return result;
            
        }
        
    }
}
