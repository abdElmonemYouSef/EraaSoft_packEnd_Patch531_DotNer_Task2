namespace EraaSoft_packEnd_Patch531_DotNer_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<int> UsedList = new();

            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9 };


            List<int> usrMemberList = new List<int>();



            bool UserWillToContinue = true;

            while (UserWillToContinue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" \nplease select an option form the listed Options below : \n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("G - generate My own list\r\n" +
                    "G - generate list\r\n" +
                    "D - display values\r\n" +
                    "A - Add a number\r\n" +
                    "M - Display mean of the numbers\r\n" +
                    "SM - Display the smallest number\r\n" +
                    "P - Print numbers\r\n" +
                    "L - Display the largest number\r\n" +
                    "S - Search for value\r\n" +
                    "SA - Sort the list Asendently \r\n" +
                    "SD - Sort the list Destently \r\n " +
                    "C - Clear List \r\n " +
                    "Q - Quit\r\n");

                string UserOption = Console.ReadLine();


                switch (UserOption.ToLower())
                {


                    case "g":
                        Console.WriteLine("please Enter the list member count : ");

                        int usrMemberListCount = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < usrMemberListCount
                            ; i++)
                        {

                            Console.WriteLine($" please Enter a value for list member no {i + 1} ");
                            int usrMemberListValue = Convert.ToInt32(Console.ReadLine());

                            usrMemberList.Add(usrMemberListValue);



                        }

                        Console.Write("Your List Has been added successfully :    ");

                        Console.Write("[");
                        for (int i = 0; i < usrMemberList.Count; i++)
                        {
                            Console.Write(usrMemberList[i]);
                            if (i < usrMemberList.Count - 1)
                                Console.Write(",");
                        }

                        Console.Write("]");









                        break;  //generate list

                    case "d": // display

                        Console.WriteLine(" would you like to use you own list or use our bulit in list :");
                        Console.WriteLine("1- will use my own one ");
                        Console.WriteLine("2- use puilt in app list ");

                        string usroption = Console.ReadLine();

                        if (usroption.ToLower() == "1")
                        {
                            UsedList = usrMemberList;
                            if (usrMemberList.Count == 0)
                                Console.WriteLine("[] - the list is empty ");
                            else
                            {
                                Console.Write("[");
                                foreach (var item in UsedList)
                                {

                                    Console.Write($" {item} ");
                                }
                                Console.Write("]");

                            }

                        }
                        else if (usroption.ToLower() == "2")
                        {
                            UsedList = list;

                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty ");
                            else
                            {
                                Console.Write("[");
                                foreach (var item in UsedList)
                                {

                                    Console.Write($" {item} ");
                                }
                                Console.Write("]");

                            }


                            foreach (var item in list)
                            {

                                Console.Write($" {item}\t");
                            }


                        }



                        break;   //diplay values

                    case "a": // add value 

                        Console.WriteLine(" please Enter the value to add : ");
                        int UserAddedValueInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the value is : " + UserAddedValueInput);


                        list.Add(UserAddedValueInput);

                        Console.Write("[");
                        Console.Write(list[1]);

                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write($"{list[i]}");

                            if (i < list.Count - 1)
                            {
                                Console.Write(",");
                            }
                        }
                        Console.Write("]");




                        break; // add value

                    case "m":
                        int sum = 0;
                        foreach (var item in list)
                        {
                            sum += item;
                        }
                        decimal Mean = sum / list.Count;

                        Console.WriteLine($"the mean is : sum {sum} / list memberCount {list.Count} = {((decimal)sum / (decimal)list.Count):##,#0.00}");
                        break; // mean

                    case "sm":
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


                        break; // smalest value

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


                        break; // largest value

                    case "q":
                        Console.WriteLine("would you like to continue : (y/n)");


                        string UsrInput = Console.ReadLine();
                        if (UsrInput.ToLower() == "y")
                        {
                            UserWillToContinue = false;
                            Console.WriteLine("Goodbye");
                        }
                        break; // quit

                    case "s": // search
                        Console.WriteLine("please Enter the List Member value that you want to search : ");
                        int usrInputValue = Convert.ToInt32(Console.ReadLine());

                        string MatchingStringIndex = "";
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == usrInputValue)
                            {
                                MatchingStringIndex += $" {i}";
                            }
                            //else Console.WriteLine("Not found !");

                        }




                        Console.Write($"value found at index of  :{MatchingStringIndex}");


                        break; // search

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

                        break; // sort ascendent
                   
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


                        break; // sort descendent

                    case "c":
                        Console.WriteLine("Are You Sure , you Want to clear the List ? (Y _ N)");
                        string usrinput = Console.ReadLine();

                        

                        if (usrinput.ToLower() == "y")
                        {
                            if (list.Count == 0) Console.WriteLine(" The List Is Empty" );
                            else
                            {
                                list.Clear();
                                //for (int i = 0; i < list.Count-1; i++)
                                //{
                                //    Console.WriteLine($"i{i} _ list[i]:{list[i]}" );
                                //    Console.ForegroundColor = ConsoleColor.Red;
                                //    list.Remove(list[i]);
                                //    Console.WriteLine($"{list[i] } _ removed");
                                //    Console.ForegroundColor = ConsoleColor.White; 
                                //}

                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.WriteLine(list[i]);
                                }

                                Console.WriteLine("list cleared ");
                            }
     
                        }
                        else Console.WriteLine("action ignored ");
                        break; // clear
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            }
        }
    }
}
