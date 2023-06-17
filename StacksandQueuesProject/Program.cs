namespace StacksandQueuesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackQueueDemo stackLinkedList = new StackQueueDemo();
            stackLinkedList.Push(70);
            stackLinkedList.Push(30);
            stackLinkedList.Push(56);
            stackLinkedList.Display();
        }
    }
}