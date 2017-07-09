namespace DoublyLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DoublyLinkedTest
    {
        static void Main()
        {
            var doubleList = new DoubleLinkedList<int>();

            doubleList.Add(1);
            doubleList.Add(33);
            doubleList.Add(44);

            doubleList.Insert(34, 1);

            //Console.WriteLine(doubleList);

            //doubleList.Remove(33);

            Console.WriteLine(doubleList);
        }
    }
}
