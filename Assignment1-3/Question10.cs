using System;
    class Question10
    {
		public static void Main()
		{
			Question10 obj = new Question10();
			obj.DivideChocolates();
		}
        public void DivideChocolates()
        {
            Console.Write("Enter the total number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());
            
            int chocolatesPerChild = numberOfChocolates / numberOfChildren; // Calculate chocolates per child
            int remainingChocolates = numberOfChocolates % numberOfChildren; // Calculate remaining chocolates
            
            Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+".The number of remaining chocolates is "+remainingChocolates);
        }
    }
