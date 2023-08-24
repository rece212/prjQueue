namespace prjPriorityLinkedListQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PQueue PQ= new PQueue();
            QPNode qPNode = PQ.newNode(4, 1);
            qPNode = PQ.push(qPNode, 5, 2);
            qPNode = PQ.push(qPNode, 6, 3);
            qPNode = PQ.push(qPNode, 7, 5);

            while (PQ.isEmpty(qPNode)==0)
            {
                Console.WriteLine( "{0:D} ",PQ.peek(qPNode));
                qPNode = PQ.pop(qPNode);
            }

        }
    }
}