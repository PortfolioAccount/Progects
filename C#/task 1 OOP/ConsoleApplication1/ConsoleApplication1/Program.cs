using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasRabotniki
{
    class Program
    {
       
           public static int chec = 0, i;    // объявляем переменную chec-подсчет количества созданных объектов
           static  Basic[] Rab = new Basic[20];       //объявляем массивы на 20 объектов 
        class Basic
        {
            public string dolgn; // поле должность
            public string fam;   // поле фамилия
            public int zarp;     // поле зарплата
            public int stag;     // поле стаж

            public virtual int oclad() // объявляем вертуальный метод расчета оклада работника
            {
                return zarp; 
            }
            
            public void Show() // объявляем метод вывода информации о сотрудниках
            {
                Console.WriteLine("Должность " + this.dolgn);
                Console.WriteLine("Фамилия " + this.fam);
                Console.WriteLine("Стаж " + this.stag);
                Console.WriteLine("Зарплата " + this.oclad());
            }
        }
        //--------------
        class Manager : Basic  //создаем класс-наследник Manager, для которого базовым является Basic
        {
            public Manager(string Dolgn, string Fam, int Stag, int Zarp) // конструктор менеджер
            {
                this.dolgn = Dolgn;
                this.fam = Fam;
                this.stag = Stag;
                this.zarp = Zarp;

            }

            public override int oclad()   // переопределяем метод для подсчета зарплаты с надбавкой за стаж
            {
                return this.stag * 500 + this.zarp;
            }

        }
        //--------------
        class Nachal : Basic  
        {
            public Nachal(string Dolgn, string Fam, int Stag, int Zarp)
            {
                this.dolgn = Dolgn;
                this.fam = Fam;
                this.stag = Stag;
                this.zarp = Zarp;
            }
            public override int oclad()  
            {

                return this.stag * 1000 + this.zarp;
            }

        }
        //--------------
        class Bugalter : Basic  
        {
            public Bugalter(string Dolgn, string Fam, int Stag, int Zarp)
            {
                this.dolgn = Dolgn;
                this.fam = Fam;
                this.stag = Stag;
                this.zarp = Zarp;
            }
            public override int oclad()   //свойство для подсчета премии надбавки за стаж
            {
              return this.stag * 700 + this.zarp;
            }
        }
        //--------------
        public static void menu() // объявляем метод который будет работать как меню программы
        {
            String subkey = "n", key, chet;
            do                               // выводим меню для работы с программой
            {
                Console.WriteLine("***Меню***");
                Console.WriteLine("1 - Ввод данных");
                Console.WriteLine("2 - Вывод данных");
                Console.WriteLine("3 - Удалить работника");
                Console.WriteLine("4 - Выход");
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":         // ввод данных выполняется через соответствующие свойства
                        do
                        { Console.WriteLine("Кого хотите создать? ");
                            Console.WriteLine("1 - Менеджер");
                            Console.WriteLine("2 - Начальник");
                            Console.WriteLine("3 - Бугалтер");
                            chet = Console.ReadLine();
                            string dolg;
                            string fam;
                            int stag;
                            int zp;
                            switch (chet) // оператор свич.. если условие верно то выполняется
                            {
                                case "1": 
                                    dolg = "Менеджер";
                                    Console.WriteLine("Введите фамилию: ");
                                    fam = Console.ReadLine();
                                    Console.WriteLine("Стаж ");
                                    stag = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите зарплату: ");
                                    zp = Convert.ToInt32(Console.ReadLine());
                                    Manager manager = new Manager(dolg, fam, stag, zp); // создаем объект класса
                                    Rab[chec] = manager;//заносим в массив объект 
                                    chec++;                    // количество инициализорованных объектов
                                    Console.WriteLine("Продолжить?(Y/N)...");
                                    subkey = Console.ReadLine();
                                    break;
                                case "2":
                                    dolg = "Начальник";
                                    Console.WriteLine("Введите фамилию: ");
                                    fam = Console.ReadLine();
                                    Console.WriteLine("Стаж ");
                                    stag = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите зарплату: ");
                                    zp = Convert.ToInt32(Console.ReadLine());
                                    Nachal nachal = new Nachal(dolg, fam, stag, zp);// создаем объект класса
                                    Rab[chec] = nachal;//заносим в массив объект 
                                    chec++;                    // количество инициализорованных объектов
                                    Console.WriteLine("Продолжить?(Y/N)...");
                                    subkey = Console.ReadLine();
                                    break;
                                case "3":
                                    dolg = "Бухгалтер";
                                    Console.WriteLine("Введите фамилию: ");
                                    fam = Console.ReadLine();
                                    Console.WriteLine("Стаж ");
                                    stag = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите зарплату: ");
                                    zp = Convert.ToInt32(Console.ReadLine());
                                    Bugalter bugalter = new Bugalter(dolg, fam, stag, zp);// создаем объект класса
                                    Rab[chec] = bugalter;//заносим в массив объект
                                    chec++;                    // количество инициализорованных объектов
                                    Console.WriteLine("Продолжить?(Y/N)...");
                                    subkey = Console.ReadLine();
                                    break;
                            }




                        } while ((subkey == "y") || (subkey == "Y")); break;

                    case "2":               // вывод данных
                        Basic rab = new Basic();// переменная ссылка 

                        for (i = 0; i < chec; i++)
                        {
                            rab = Rab[i];
                            rab.Show(); //Вызываем метод показать все поля
                            Console.WriteLine("");
                        }

                        break;
                        case "3":               // вывод данных
                        Console.WriteLine("Введите фамилию сотрудника которого хотите удалить");
                        Basic drop;//Ссылка на базовый класс
                        String famcl;//фамилия работника которого хотим удалить
                        famcl = Console.ReadLine();
                        for (int i = 0; i < chec; i++)
                        {
                            drop = Rab[i];//заносим в переменную объект из массива
                            if (drop != null)
                            {
                                if (famcl == drop.fam)//Если фамилия соответствует полю имя 
                                {
                                    for (int j=i; j < chec; j++)
                                    {

                                        Rab[j] = Rab[j + 1];
                                    }
                                    chec --;
                                    Console.WriteLine("Сотрудник удален!");
                                }
                            }
                        }
                        break;
                }
            } while (key != "4");
        }
        static void Main(string[] args)
        {
            menu();
        }
        }
    }

