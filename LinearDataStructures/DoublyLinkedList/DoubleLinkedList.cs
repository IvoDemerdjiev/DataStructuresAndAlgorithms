namespace DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;


    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        public Node<T> First { get; private set; }

        public Node<T> Last { get; private set; }

        public int Count { get; set; } 

        public void Add(T value)
        {
            var node = new Node<T>(value);

            if (First == null)
            {
                this.First = this.Last = node;
            }
            else
            {
                node.Previous = this.Last;

                this.Last.Next = node;
                this.Last = node; 
            }

            this.Count++;
        }

        public int Remove(T value)
        {
            int currentIndex = 0;
            Node<T> currentNode = First;
            Node<T> prevNode = null;

            // Find the element
            while (currentNode != null)
            {
                if ((currentNode.Value != null &&
                       currentNode.Value.Equals(value)) ||
                      (currentNode.Value == null) && (value == null))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // Element is found. Remove it
                Count--;
                if (Count == 0)
                {
                    First = null;
                }
                else if (prevNode == null)
                {
                    First = currentNode.Next;
                }
                else
                {
                    prevNode.Next = currentNode.Next;
                }

                // Find last element
                Node<T> lastElement = null;
                if (this.First != null)
                {
                    lastElement = this.First;
                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }
                Last = lastElement;

                return currentIndex;
            }
            else
            {
                // Element is not found in the list
                return -1;
            }
        }

        public T Insert(T value , int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                      "Invalid index: " + index);
            }
            else
            {
                Node<T> currentNode = this.First;
                for (int i = 0; i < Count; i++)
                {
                    if (i == index)
                    {
                        currentNode.Next.Value = value;
                        currentNode.Value = value;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                }
                return currentNode.Value;
            }
        }

        public int IndexOf(T value)
        {
            int index = 0;
            Node<T> current = First;

            while (current != null)
            {
                if ((current.Value != null &&  current.Value.Equals(value)) || (current.Value == null && value == null))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = this.First; current != null; current = current.Next)
                yield return current.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(",", this);
        }
    }
}
