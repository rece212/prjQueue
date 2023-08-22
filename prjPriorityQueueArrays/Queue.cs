using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPriorityQueueArrays
{
    public class Queue
    {

        public item[] pr = new item[100000];
        int size = -1;

        public  void enqueue(int value, int priority)
        {
            size++;
            pr[size] = new item();
            pr[size].value = value;
            pr[size].priority = priority;
        }
        public  int peek()
        {
            int HighestPriority = int.MinValue;
            int iPos = -1;
            for(int i = 0 ; i < size; i++)
            {
                if ( HighestPriority == pr[i].priority && iPos >-1 && pr[iPos].value < pr[i].value)
                {
                    HighestPriority = pr[i].value;
                    iPos = i;    
                }
                else if (HighestPriority < pr[i].priority)
                {
                    HighestPriority = pr[i].priority;
                    iPos = i;
                }
            }
            return iPos;
        }
        public  void dequeue()
        {
            int iPos = peek();
            for(int i = iPos;i < size; i++)
            {
                pr[i] = pr[i + 1];
            }
            size--;
        }



    }
}
