using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    // Node representing a text state in the undo/redo functionality
    class TextStateNode
    {
        public string Content;
        public TextStateNode Prev;
        public TextStateNode Next;

        public TextStateNode(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }

    class Undo_RedoFunctionalityforTextEditor
    {
        private TextStateNode head = null;
        private TextStateNode current = null;
        private int maxSize = 10;
        private int size = 0;

        // Add a new text state at the end
        public void AddState(string content)
        {
            TextStateNode newState = new TextStateNode(content);
            if (head == null)
            {
                head = newState;
                current = newState;
            }
            else
            {
                current.Next = newState;
                newState.Prev = current;
                current = newState;
            }
            size++;
            if (size > maxSize)
            {
                head = head.Next;
                head.Prev = null;
                size--;
            }
        }

        // Undo functionality
        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Undo: " + current.Content);
            }
            else
            {
                Console.WriteLine("No more undo steps available.");
            }
        }

        // Redo functionality
        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Redo: " + current.Content);
            }
            else
            {
                Console.WriteLine("No more redo steps available.");
            }
        }

        // Display the current state of the text
        public void DisplayCurrentState()
        {
            if (current != null)
            {
                Console.WriteLine("Current State: " + current.Content);
            }
            else
            {
                Console.WriteLine("No text available.");
            }
        }
    }
}
