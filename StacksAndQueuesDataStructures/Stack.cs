using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesDataStructures
{
    class LinkedListStack<T>
    {
        public int Count { get; private set; }

        LinkedList<T> data = new LinkedList<T>();

        public LinkedListStack()
        {

        }

        public void Push(T value)
        {
            data.AddLast(new LinkedListNode<T>(value));
            Count++;
        }

        public T Pop()
        {
            LinkedListNode<T> temp = data.Last;
            data.RemoveLast();
            Count--;
            return temp.Value;
        }

        public T Peek()
        {
            return data.Last.Value;
        }

        public void Clear()
        {
            Count = 0;
            data.Clear();
        }

        public bool isEmpty()
        {
            return Count == 0;
        }
    }

    class ArrayStack<T>
    {
        private T[] data;
        public int Count { get; private set; }
        public ArrayStack(int capacity = 4)
        {
            data = new T[capacity];
        }
        public void Push(T Value)
        {
            if (Count < data.Length)
            {
                data[Count] = Value;
            }
            else
            {
                Resize(Count + 1);
                data[Count] = Value;
            }
            Count++;
        }

        public T Pop()
        {
            T temp = data[Count - 1];
            data[Count - 1] = default;
            Count--;
            return temp;
        }

        public T Peek()
        {
            return data[Count - 1];
        }

        private void Resize(int newSize)
        {
            if (newSize == data.Length)
            {
                return;
            }
            T[] temp = new T[newSize];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = data[i];
            }
            data = temp;
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                data[i] = default;
            }
            Count = 0;
        }

        public bool isEmpty()
        {
            return Count == 0;
        }
    }
}
