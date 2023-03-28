using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesandBinarySearchTree
{
   public class Nodes
    {
        public int Value;
        public Nodes Left;
        public Nodes Right;

        public Nodes(int value)
        {
            this.Value= value;
        }

        public void Insert(int value)
        {
            if(value<Value) 
            {
                if(Left==null)
                {
                    Left = new Nodes(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if(Right==null) 
                {
                    Right = new Nodes(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }

           
        }
        public  void Contains(int value) 
        {
            if(value == Value)
            {
                Console.WriteLine("true");;
               //return true;
            }
            else
            {
                if(value< Value) 
                {
                    if(Left==null)
                    {
                      Console.WriteLine("false");
                        //return false;
                    }
                    else
                    {
                        Left.Contains(value);
                    }
                }
                else
                {
                    if (Right == null)
                    { Console.WriteLine("false"); }
                    else
                    {
                        Right.Contains(value);
                    }
                }
            }
        }

    }

   public class BinarySearchTree
    {
        public void Execute()
        {
            Nodes datas = new Nodes(14);
            datas.Insert(15);
            datas.Insert(16);
            datas.Insert(17);
            datas.Insert(21);

            //if (datas.Contains(17))
            //{
            //    Console.WriteLine("17 root is found");
            //}
            //else
            //{
            //    Console.WriteLine("Root not found");
            //}
        }
    }
}
