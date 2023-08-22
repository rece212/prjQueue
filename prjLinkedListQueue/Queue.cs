using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLinkedListQueue
{
     class Queues
    {
        public Qnode front, rear;
        public Queues() {
            this.front = this.rear = null; 
        }

        public void enqueue(int key)
        {
            Qnode temp = new Qnode(key);

            if(this.rear ==null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
        }

        public void dequeue()
        {
            if(this.front == null)
            {
                return;
            }

            this.front = this.front.next;
            if(this.front == null)
            {
                this.rear = null;
            }
        }


    }
}
