using System;

namespace LinkedListAssignment
{
    class ProcessNode
    {
        public int ProcessID;
        public int BurstTime;
        public int Priority;
        public ProcessNode Next;

        public ProcessNode(int processID, int burstTime, int priority)
        {
            ProcessID = processID;
            BurstTime = burstTime;
            Priority = priority;
            Next = null;
        }
    }

    class RoundRobinSchedulingAlgorithm
    {
        private ProcessNode head = null;
        private ProcessNode tail = null;

        public void AddProcess(int processID, int burstTime, int priority)
        {
            ProcessNode newNode = new ProcessNode(processID, burstTime, priority);
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }
        }

        public void RemoveProcess(int processID)
        {
            if (head == null) return;
            ProcessNode current = head, prev = null;

            do
            {
                if (current.ProcessID == processID)
                {
                    if (current == head)
                    {
                        if (head == tail)  // ✅ If only one process left
                        {
                            head = tail = null;
                        }
                        else
                        {
                            head = head.Next;
                            tail.Next = head;
                        }
                    }
                    else if (current == tail)
                    {
                        tail = prev;
                        tail.Next = head;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    return;
                }
                prev = current;
                current = current.Next;
            } while (current != head);
        }

        public void RoundRobinScheduling(int timeQuantum)
        {
            if (head == null) return;
            ProcessNode current = head;

            while (head != null)
            {
                ProcessNode nextNode = current.Next;  // ✅ Store next node before deletion

                Console.WriteLine($"Executing Process ID: {current.ProcessID}, Burst Time: {current.BurstTime}");

                if (current.BurstTime > timeQuantum)
                {
                    current.BurstTime -= timeQuantum;
                }
                else
                {
                    Console.WriteLine($"Process ID {current.ProcessID} Completed");
                    RemoveProcess(current.ProcessID);
                }

                current = (head != null) ? nextNode : null;  // ✅ Prevent infinite loop if list becomes empty
                DisplayProcesses();
            }
        }

        public void DisplayProcesses()
        {
            if (head == null) return;
            ProcessNode temp = head;
            do
            {
                Console.WriteLine($"Process ID={temp.ProcessID}, Burst Time={temp.BurstTime}, Priority={temp.Priority}");
                temp = temp.Next;
            } while (temp != head);
        }
    }
}