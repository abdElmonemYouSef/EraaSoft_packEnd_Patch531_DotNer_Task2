namespace EraaSoft_packEnd_Patch531_DotNer_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            List<int> list = new List<int>() { 1, 2, 9, 4, 5, 6, 7, 8, 3 };

            bool UserWillToContinue = true;

            while (UserWillToContinue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" \nplease select an option form the listed Options below : \n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("    P - Print numbers\r\n    A - Add a number\r\n    M - Display mean of the numbers\r\n    S - Display the smallest number\r\n    L - Display the largest number\r\n    SA - Sort the list Asendently \r\n    sd - Sort the list Destently \r\n    Q - Quit\r\n");

                string UserOption = Console.ReadLine();


                switch (UserOption.ToLower())
                {






                    case "p":
                        {


                            foreach (var item in list)
                            {

                                Console.Write($" {item}\t");
                            }
                        }
                        break;

                    case "a":
                        Console.WriteLine(" please Enter the value to add : ");
                        int UserAddedValueInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the value is : " + UserAddedValueInput);


                        list.Add(UserAddedValueInput);
                        foreach (var item in list)
                        {
                            Console.Write($"{item}\t");
                        }
                        break;


                    case "m":
                        int sum = 0;
                        foreach (var item in list)
                        {
                            sum += item;
                        }
                        decimal Mean = sum / list.Count;

                        Console.WriteLine($"the mean is : sum {sum} / list memberCount {list.Count} = {((decimal)sum / (decimal)list.Count):##,#0.00}");
                        break;

                    case "s":
                        int smallest = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            smallest = list[i];

                            for (int j = 0; j < list.Count; j++)
                            {
                                if (smallest > list[j])
                                {
                                    smallest = list[j];
                                }
                            }
                        }

                        Console.WriteLine(smallest);


                        break;


                    case "l":
                        int Largest = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            Largest = list[i];

                            for (int j = 0; j < list.Count; j++)
                            {
                                if (Largest < list[j])
                                {
                                    Largest = list[j];
                                }
                            }
                        }

                        Console.WriteLine(Largest);


                        break;

                    case "q":
                        Console.WriteLine("would you like to continue : (y/n)");


                        string UsrInput = Console.ReadLine();
                        if (UsrInput.ToLower() == "y")
                        {
                            UserWillToContinue = false;
                        }
                        break;

                    case "sa":
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = 0; j < list.Count - 1; j++)
                            {
                                //Console.WriteLine("trial number : " + i);
                                //Console.WriteLine("------------");
                                //Console.WriteLine($"logic (list[j] > list[j+1]): {list[j] > list[j + 1]}");
                                //Console.WriteLine("temp : " + temp);
                                //Console.WriteLine("(list[j] : " + list[j]);
                                //Console.WriteLine("(list[j + 1 ] : " + list[j + 1]);
                                //Console.WriteLine("------------");
                                if (list[j] > list[j + 1])
                                {
                                    //Console.ForegroundColor = ConsoleColor.Green;
                                    //Console.WriteLine("action of swap taken");
                                    //Console.ForegroundColor = ConsoleColor.White;
                                    int temp = list[j];
                                    list[j] = list[j + 1];
                                    list[j + 1] = temp;

                                }



        


                            }




                        }
                        Console.Write("List sorted Asendently :  ");
                        foreach (var item in list)
                        {
                            Console.Write($"{item} ");
                        }

                        break;
                    case "sd":
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = 0; j < list.Count - 1; j++)
                            {
                                //Console.WriteLine("trial number : " + i);
                                //Console.WriteLine("------------");
                                //Console.WriteLine($"logic (list[j] < list[j+1]): {list[j] < list[j + 1]}");
                                //Console.WriteLine("temp : " + temp);
                                //Console.WriteLine("(list[j] : " + list[j]);
                                //Console.WriteLine("(list[j + 1 ] : " + list[j + 1]);
                                //Console.WriteLine("------------");
                                if (list[j] < list[j + 1])
                                {
                                    //Console.ForegroundColor = ConsoleColor.Green;
                                    //Console.WriteLine("action of swap taken");
                                    //Console.WriteLine("(list[j] : " + list[j]);
                                    //Console.WriteLine("(list[j + 1 ] : " + list[j + 1]);
                                    //Console.ForegroundColor = ConsoleColor.White;
                                    //Console.WriteLine($"logic (list[j] < list[j+1]): {list[j] < list[j + 1]}");
                                    int temp = list[j];
                                    list[j] = list[j + 1];
                                    list[j + 1] = temp;

                                }




                            }





                        }
                        Console.Write("List sorted Desendently :  ");
                        foreach (var item in list)
                        {
                            Console.Write($"{item} ");
                        }


                        break;

                    default:
                        Console.WriteLine("Invalid Input ");

                        break;



                }
            }




        }
    }
}
