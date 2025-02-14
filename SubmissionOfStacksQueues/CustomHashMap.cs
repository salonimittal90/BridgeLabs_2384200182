using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    class CustomHashMap<K, V>
    {
        private class Node
        {
            public K Key;
            public V Value;
            public Node Next;

            public Node(K key, V value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private readonly int size = 10; // Fixed size array (hash table)
        private Node[] buckets;

        public CustomHashMap()
        {
            buckets = new Node[size];
        }

        private int GetIndex(K key)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }

        public void Put(K key, V value)
        {
            int index = GetIndex(key);
            Node head = buckets[index];

            // Update existing key
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }

            // Insert new node at the head (Separate Chaining)
            Node newNode = new Node(key, value);
            newNode.Next = buckets[index];
            buckets[index] = newNode;
        }

        public V Get(K key)
        {
            int index = GetIndex(key);
            Node head = buckets[index];

            while (head != null)
            {
                if (head.Key.Equals(key))
                    return head.Value;
                head = head.Next;
            }

            throw new KeyNotFoundException("Key not found!");
        }

        public void Remove(K key)
        {
            int index = GetIndex(key);
            Node head = buckets[index];
            Node prev = null;

            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    if (prev == null)
                        buckets[index] = head.Next; // Remove first node
                    else
                        prev.Next = head.Next; // Remove middle or last node
                    return;
                }
                prev = head;
                head = head.Next;
            }
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Bucket {i}: ");
                Node head = buckets[i];
                while (head != null)
                {
                    Console.Write($"[{head.Key}: {head.Value}] -> ");
                    head = head.Next;
                }
                Console.WriteLine("NULL");
            }
        }
    }
}