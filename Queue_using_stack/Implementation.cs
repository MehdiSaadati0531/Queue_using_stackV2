using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_using_stack
{
    public class Implementation
    {
        int[] array;
        int[] array2;
        int top;
        int top2;

        public Implementation(int size)
        {
            array = new int[size];
            array2 = new int[size];
            top = -1;
            top2 = -1;
        }

        bool IsFull()
        {
            if (top == array.Length - 1)
            {
                Console.WriteLine("The queue is full");
                return true;
            }
            return false;
        }
        bool IsEmpty()
        {
            if (top == -1)
            {
                Console.WriteLine("The queue is empty");
                return true;
            }
            return false;
        }

        private void Push(int Newnumber)
        {
            if (IsFull())
            {

            }
            else
            {
                ++top;
                array[top] = Newnumber;
            }
        }

        private void Pop()
        {
            if (IsEmpty())
            {

            }
            else
            {
                for (int i = top; i > -1; i--)
                {
                    top2++;
                    array2[top2] = array[i];
                }
                top2--;
                var n = 0;
                for (int i = top2; i > -1; i--)
                {
                    array[n] = array2[i];
                    n++;
                }
                top--;
                top2 = -1;
            }
        }
        public void PrintMembers()
        {
            if (IsEmpty())
            {

            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(array[i]);
                }

            }
        }

        public void EnQueue(int NewNumber)
        {
            Push(NewNumber);
        }

        public void DeQueue()
        {
            Pop();
        }

    }
}