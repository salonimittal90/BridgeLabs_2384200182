using System;

namespace SubmissionOfLinkedList
{
     class StudentNode
    {
        public int rollNumber;
        public string name;
        public int age;
        public char grade;
        public StudentNode Next;

        public StudentNode(int rollNumber, string name, int age, char grade)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.age = age;
            this.grade = grade;
            Next = null;
        }

       public  class Student
        {
            public StudentNode head;
                public void AddFirst(int rollNumber, string name, int age, char grade)
                {
                    StudentNode newStudent = new StudentNode(rollNumber , name, age, grade);
                if (head == null)
                {
                    head = newStudent;
                    Console.WriteLine("Student with Rollnumber "+rollNumber+"Added");
                    
                    return;
                }
                else
                {
                    newStudent.Next = head;
                    Console.WriteLine("Student with Rollnumber " + rollNumber + "Added");
                    head = newStudent;
                }
                Console.WriteLine("------------------------");
            }  
            public void AddLast(int rollNumber, string name, int age, char grade)
            {
                StudentNode newStudent = new StudentNode(rollNumber, name, age, grade);
                if(head == null) 
                { 
                    head = newStudent;
                    Console.WriteLine("Student with Rollnumber " + rollNumber + "Added");
                    return;
                }
                StudentNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newStudent;
                Console.WriteLine("Student with Rollnumber " + rollNumber + "Added");
                Console.WriteLine("------------------------");
            }

            public void AddAtSpecific(int rollNumber, string name, int age, char grade,int position)
            {
                StudentNode newStudent = new StudentNode(rollNumber, name, age, grade);
                StudentNode temp = head;
                if (position < 1)
                {
                    Console.WriteLine("Invalid Position");
                    return;
                }
                if(position ==1)
                {
                    newStudent.Next = head;
                    newStudent = head;
                    Console.WriteLine("Student with Rollnumber " + rollNumber + "Added");
                    return ;
                }
                for(int i = 1;i<position-1 && temp.Next!=null ;i++)
                {
                    temp= temp.Next;

                }
                if (temp.Next == null && temp.rollNumber == 0)
                {
                    Console.WriteLine("Position out of bound");

                }

                newStudent.Next = temp.Next;
                temp.Next=newStudent;
                Console.WriteLine("Student with Rollnumber " + rollNumber + "Added");
                Console.WriteLine("------------------------");
            }

            public void DeleteRollno(int rollnumber)
            {
                if(rollnumber<1)
                {
                    Console.WriteLine("Invalid roll number");
                    return;
                }
                if(head == null)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }
                if(head.rollNumber == rollnumber)
                {
                    head = head.Next;
                    return;
                }
                    
                StudentNode  temp = head;
                while(temp.Next!=null && temp.Next.rollNumber!=rollnumber)
                {
                    temp = temp.Next;
                }

                if(temp.Next == null)
                {
                    Console.WriteLine("Student not found");
                    return;
                }
                temp.Next = temp.Next.Next;
                Console.WriteLine("Student with rollnumber "+rollnumber+"deleted Sucessfully");
                Console.WriteLine("------------------------");
            }
            public void SearchByRollno(int rollnumber)
            {
                if(head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                StudentNode temp = head;
                while(temp!=null)
                {
                    if(temp.rollNumber == rollnumber)
                    {
                        Console.WriteLine("Student found with rollnumber is "+temp.rollNumber+"Name is: "+temp.name+"Age is: "+temp.age+"Grade is: "+temp.grade);
                        return;
                    }
                    temp = temp.Next;
                }

                Console.WriteLine("Student not found with this rollno");
                Console.WriteLine("------------------------");
            }

            public void DisplayStudent()
            {
                if(head == null)
                {
                    Console.WriteLine("list is empty");
                    return;
                }
                StudentNode temp = head;
                int i = 1;
                while(temp!=null)
                {
                    Console.WriteLine("Student " +i+" details are "+" RollNumber is: "+temp.rollNumber+" Name is: "+temp.name+ " Age is: "+temp.age+" Grade is: "+temp.grade );
                    i++;
                    temp = temp.Next;
                }
                Console.WriteLine("------------------------");
            }
            public void UpdateGrade(int rollnumber , char grade)
            {
                if (head == null)
                {
                    Console.WriteLine("list is empty");
                    return; 
                }
                StudentNode temp = head;
                while (temp != null)
                {
                    if (temp.rollNumber == rollnumber)
                    {
                        temp.grade = grade;
                        Console.WriteLine("Student with rollnumber " + rollnumber + " updated grade is: "+grade);
                        return;
                    }
                     temp = temp.Next;
                }
                Console.WriteLine("student not Exist");
                Console.WriteLine("------------------------");

            }

        }
    }
}
