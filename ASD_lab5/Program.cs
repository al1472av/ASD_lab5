using ASD_lab5.Lists;

namespace ASD_lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SinglyLinkedListBase<int> list = new SinglyLinkedListBase<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.PrintCollectionData();
        }
    }
}