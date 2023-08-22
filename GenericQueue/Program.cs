namespace GenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("One");
            numbers.Enqueue("Two");
            numbers.Enqueue("Three");
            numbers.Enqueue("Four");
            numbers.Enqueue("Five");

            foreach(String number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Dequeing {0}",numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}"
                , numbers.Peek());
            Console.WriteLine("Dequeing {0}", numbers.Dequeue());

            String[] test = { "One", "Three", "Nine" };

            Queue<string> queueCopy = new Queue<string>(test);
            Console.WriteLine("I Was cloned by Queue one");
            foreach (String number in queueCopy)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("was four found: {0}",queueCopy.Contains("Four"));
            Console.WriteLine("Clear the queue");
            queueCopy.Clear();
            Console.WriteLine("Queue copy count: {0}",queueCopy.Count());
        }
    }
}