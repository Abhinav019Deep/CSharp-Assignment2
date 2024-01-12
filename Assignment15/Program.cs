namespace Assignment2
{
    enum UserType { Admin=1, Customer}
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "y";
            Product[] product = new Product[10];
            while (ch == "y")
            {
                Console.WriteLine("Enter the user type : 1.Admin 2.Customer : ");
                int userType = Byte.Parse(Console.ReadLine());
                if (userType  == (int)UserType.Admin)
                { 
                    for (int i = 0; i < 2; i++)
                    {
                        product[i] = new Product();
                        product[i].GetDetails();
                    }
                }
                else if (userType == (int)UserType.Customer)
                {
                    foreach (Product product1 in product)
                    {
                        if(product1!=null)
                        product1.DisplayDetails();
                    }

                }

                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine();
            }
        }
    }
}
