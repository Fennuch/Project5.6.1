namespace Project5._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var data = DataEntry();
            ShowData(data);
        }

        static (string, string, int, int, string[], int, string[]) DataEntry()
        {
            //имя
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();


            //фамилия
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();

            //возраст

            int age;
            while (true)
            {

                Console.WriteLine("Введите возраст:");
                int.TryParse(Console.ReadLine(), out int result);
                age = result;

                if (CheckingAge(age))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод возраста!");
                }

            }

            //Наличие питомцев


            string petCheak;
            int numberOfPets = 0;
            string[] namePets = new string[1];

            while (true)
            {
                Console.WriteLine("Есть ли питомцы? Ответ да или нет с маленькой буквы.");
                string petCheck = Console.ReadLine();




                if (petCheck == "да")
                {
                    while (true)
                    {

                        Console.WriteLine("Введите кол-во ваших питомцев: ");
                        int.TryParse(Console.ReadLine(), out int result);
                        numberOfPets = result;

                        if (CheckingPet(numberOfPets))
                        {
                            namePets = new string[numberOfPets];
                            for (int i = 0; i < numberOfPets; i++)
                            {
                                Console.WriteLine("Введите имя вашего питомца: ");
                                string namePet = Console.ReadLine();
                                namePets[i] = namePet;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод!");

                        }
                    }
                    break;
                }
                else if (petCheck == "нет")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }
            }




            // Наличие цветов


            string colorsCheck;
            int numberOfColors = 0;
            string[] nameColors = new string[1]; ;

            while (true)
            {
                Console.WriteLine("Есть ли любимые цвета? Ответ да или нет c маленькой буквы.");
                colorsCheck = Console.ReadLine();


                if (colorsCheck == "да")
                {
                    while (true)
                    {

                        Console.WriteLine("Введите кол-во ваших любимых цветов: ");
                        int.TryParse(Console.ReadLine(), out int result);
                        numberOfColors = result;
                        if (CheckingColors(numberOfColors))
                        {

                            nameColors = new string[numberOfColors];
                            for (int i = 0; i < numberOfColors; i++)
                            {
                                Console.WriteLine("Введите название цвета: ");
                                string nameColor = Console.ReadLine();
                                nameColors[i] = nameColor;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод!");
                        }
                    }
                    break;
                }
                else if (colorsCheck == "нет")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }
            }

                return (name, surname, age, numberOfPets, namePets, numberOfColors, nameColors);

            
        }


        static bool CheckingAge(int age)
        {
            return age < 100 && age > 0;
        }

        static bool CheckingPet(int numberOfPets)
        {
            return numberOfPets > 0;
        }

        static bool CheckingColors(int numberOfColors)
        {
            return numberOfColors > 0;
        }

        static void ShowData((string, string, int, int, string[] , int, string[]) data)
        {
            Console.WriteLine("Ваши данные");
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item3);
            Console.WriteLine(data.Item4 == 0 ? "Нет питомцев": "Питомцев:" + data.Item4 ) ;
            foreach ( string i in data.Item5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(data.Item6 == 0 ? "Нет любимых цветов" : "Любимых цветов:" + data.Item6);
            foreach (string i in data.Item7)
            {
                Console.WriteLine(i);
            }

        }


    }
}