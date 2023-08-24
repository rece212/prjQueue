using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPriorityLinkedListQueue
{
     class PQueue
    {
        public QPNode node = new QPNode();
        public QPNode newNode(int d, int p)
        {
            QPNode temp = new QPNode();
            temp.data = d;
            temp.priority = p;
            temp.next = null;
            return temp;
        }
        public int peek(QPNode head) 
        {
            return head.data;
        }

        public QPNode pop(QPNode head)
        {
            return head.next;
        }
        public QPNode push(QPNode head,int d,int p)
        {
            QPNode start = head;
            QPNode temp = newNode(d, p);
            if (head.priority<p)
            {
                temp.next = head;
                head = temp;
            }
            else
            {
                while(start.next != null&& start.next.priority>p)
                {
                    start = start.next;
                }
                temp.next = start.next;
                start.next = temp;
            }
            return head;
        }
        public int isEmpty(QPNode head)
        {
            return (head == null) ? 1 : 0;
        }
    }
}
