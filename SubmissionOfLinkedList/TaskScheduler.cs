using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    // Node representing a task
    class TaskNode
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int id, string name, int priority, DateTime dueDate)
        {
            TaskID = id;
            TaskName = name;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }

    class TaskScheduler
    {
        private TaskNode head = null;
        private TaskNode currentTask = null;

        // Add a task at the beginning
        public void AddAtBeginning(int id, string name, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head; // Circular link
            }
            else
            {
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                newNode.Next = head;
                temp.Next = newNode;
                head = newNode;
            }
        }

        // Add a task at the end
        public void AddAtEnd(int id, string name, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }
        }

        // Remove a task by Task ID
        public void RemoveTask(int id)
        {
            if (head == null) return;
            TaskNode temp = head, prev = null;
            do
            {
                if (temp.TaskID == id)
                {
                    if (prev != null)
                    {
                        prev.Next = temp.Next;
                    }
                    else
                    {
                        TaskNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }
                        head = head.Next;
                        last.Next = head;
                    }
                    return;
                }
                prev = temp;
                temp = temp.Next;
            } while (temp != head);
        }

        // View the current task and move to the next task
        public void ViewCurrentTask()
        {
            if (currentTask == null)
                currentTask = head;
            Console.WriteLine($"Current Task: ID={currentTask.TaskID}, Name={currentTask.TaskName}, Priority={currentTask.Priority}, Due Date={currentTask.DueDate}");
            currentTask = currentTask.Next;
        }

        // Display all tasks
        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            TaskNode temp = head;
            do
            {
                Console.WriteLine($"ID={temp.TaskID}, Name={temp.TaskName}, Priority={temp.Priority}, Due Date={temp.DueDate}");
                temp = temp.Next;
            } while (temp != head);
        }

        // Search for a task by priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            TaskNode temp = head;
            bool found = false;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine($"Found Task: ID={temp.TaskID}, Name={temp.TaskName}, Due Date={temp.DueDate}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);
            if (!found)
            {
                Console.WriteLine("No task found with the given priority.");
            }
        }
    }

}
