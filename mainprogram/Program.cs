using System;

namespace mainprogram
{
    class Program
    {
        static void Main(string[] args)
        {
                while(true){
            try
            {
                Display obj = new Display();
                int choice, choice1, index, start, end;
                string sub_choice=null;
                string sub_choice1 = null;
                string str_keyword;

               do
                {
                        Console.WriteLine("Please select from the following:");
                        Console.WriteLine("1. Display all the items and their information");
                        Console.WriteLine("2. Sort the items by Product Name");
                        Console.WriteLine("3. Search the Items to display its information");
                        Console.WriteLine("4. Delete any item and Display the contents");
                        Console.WriteLine("5. Exit out of the program");
                        choice = int.Parse(Console.ReadLine());

                        switch(choice)
                        {
                                case 1: Console.WriteLine("-------------------------------------------------------");
                                        obj.DisplayAll();
                                        break;

                                case 2: Console.WriteLine("-------------------------------------------------------");
                                        obj.displaySortedProducts(); 
                                        break;

                                case 3: Console.WriteLine("-------------------------------------------------------");        
                                        Console.WriteLine("Please enter the Product or any keyword you want to search");
                                        str_keyword = Console.ReadLine();
                                        obj.DisplayFound(str_keyword);
                                        break;

                                case 4: do
                                        {
                                                Console.WriteLine("-------------------------------------------------------");
                                                Console.WriteLine("Please select from the following:");
                                                Console.WriteLine("1. Delete at a Particular index");
                                                Console.WriteLine("2. Delete a Range of Products");
                                                Console.WriteLine("3. Delete a product by its name");
                                                choice1 = int.Parse(Console.ReadLine());
                                                switch(choice1)
                                                {
                                                case 1: Console.WriteLine("Please enter the index:");
                                                        Console.WriteLine("0. Go Cheese");   
                                                        Console.WriteLine("1. Amul Cheese");
                                                        Console.WriteLine("2. Britannia Cheese");
                                                        Console.WriteLine("3. Coca-Cola");
                                                        Console.WriteLine("4. Sprite");
                                                        Console.WriteLine("5. Surf Excel");
                                                        Console.WriteLine("6. Ariel");
                                                        Console.WriteLine("7. Vegetables");
                                                         Console.WriteLine("8. Spices");
                                                            
                                                        index = int.Parse(Console.ReadLine());
                                                        obj.DisplayAfterDeletion1(index);
                                                        break;
                                                
                                                case 2: Console.WriteLine("Please enter the Start and the End index");
                                                        Console.WriteLine("0. Go Cheese");   
                                                        Console.WriteLine("1. Amul Cheese");
                                                        Console.WriteLine("2. Britannia Cheese");
                                                        Console.WriteLine("3. Coca-Cola");
                                                        Console.WriteLine("4. Sprite");
                                                        Console.WriteLine("5. Surf Excel");
                                                        Console.WriteLine("6. Ariel");
                                                        Console.WriteLine("7. Vegetables");
                                                         Console.WriteLine("8. Spices");
                                                        start = int.Parse(Console.ReadLine());
                                                        end = int.Parse(Console.ReadLine());
                                                        obj.DisplayAfterDeletion3(start,end);
                                                        break;
                                                case 3: Console.WriteLine("Please enter the product name to be deleted");
                                                        Console.WriteLine("0. Go Cheese");   
                                                        Console.WriteLine("1. Amul Cheese");
                                                        Console.WriteLine("2. Britania Cheese");
                                                        Console.WriteLine("3. Coca-Cola");
                                                        Console.WriteLine("4. Sprite");
                                                        Console.WriteLine("5. Surf Excel");
                                                        Console.WriteLine("6. Ariel");
                                                        Console.WriteLine("7. Vegetables");
                                                        Console.WriteLine("8. Spices");
                                                        try{
                                                        string delete_name=Console.ReadLine();
                                                        obj.DisplayAfterDeletion4(delete_name);
                                                       }
                                                        catch(Exception ex){
                                                                 Console.WriteLine(ex.Message);
                                                        }
                                                        break;
                                                default: Console.WriteLine("Sorry! Wrong Input");
                                                        break;        
                                                }
                                                Console.WriteLine("Would you like to Continue with the deletion procedure(Yes/No) ?");
                                                sub_choice1 = Console.ReadLine();
                                        }while(sub_choice1.ToUpper() == "YES");
                                        break;
                                 case 5:
                                        return;
                                default: Console.WriteLine("You have entered a wrong input");
                                        break;        
                        }
                        Console.WriteLine("Would you like to Continue?(Yes/No)");
                        sub_choice = Console.ReadLine();
                }while(sub_choice.ToUpper() == "YES");                         
            }catch(Exception ex){
                    Console.WriteLine("{0},please enter a valid input and  try again ",ex.Message);
                        
                        }
            }
        }
        }
    }

