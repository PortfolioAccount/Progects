using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.BLL;
using Task6.Core;

namespace Task6
{
    class Program
    {
       static UserService userService = new UserService();
       static AwardService awardService = new AwardService();

        static void Main(string[] args)
        {
            Console.WriteLine("Перечень существующих наград:");
            foreach (var item in awardService.Get())
            {
                Console.WriteLine($"{item.Id}");  
                Console.WriteLine($"\t {item.Title} \t ");
            }

            Console.WriteLine();
            Console.WriteLine("Перечень существующих пользователей:");

            foreach (var user in userService.Get())
            {
                Console.WriteLine($"{user.Id} \t {user.Name} \t {user.BirthDay} \t {user.Age} \t ");
                Console.WriteLine(" \t Награды пользователя:");
                foreach (var award in user.Awards)
                {
                    Console.WriteLine($" \t {award.Id} \t {award.Title} \t ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Выберите определенную команду:");
            Console.WriteLine("Нажмите 1, чтобы создать пользователя");
            Console.WriteLine("Нажмите 2, чтобы редактировать пользователя");
            Console.WriteLine("Нажмите 3, чтобы удалить пользователя");
            Console.WriteLine("Нажмите 4, чтобы создать награду");
            Console.WriteLine("Нажмите 5, чтобы редактировать награду");
            Console.WriteLine("Нажмите 6, чтобы удалить награду");
            Console.WriteLine("Нажмите 7, чтобы присвоить пользователю награду");
            string button = Console.ReadLine();
            string name;
            DateTime dateBirtgh;
           
            switch (button)
            {
                case "1":
                    Console.WriteLine("Введите имя пользователя");
                    name = Console.ReadLine();
                    if (name == "") { Console.WriteLine("Вы не ввели имя!"); Console.ReadKey(); return; }
                    Console.WriteLine("Введите дату рождения");
                    string date1 = Console.ReadLine();
                    if (!DateTime.TryParse(date1, out dateBirtgh)) { Console.WriteLine("Вы ввели не дату!!!"); Console.ReadKey(); return; }
                    if (Convert.ToDateTime(date1) > DateTime.Now)
                    { Console.WriteLine("Вы ввели дату рождения из будущего!!!"); Console.ReadKey(); return; }
                    userService.CreateOrUpdate(new User()
                    {

                        BirthDay = dateBirtgh,
                        Name = name
                    });
                    Console.WriteLine("Пользователь успешно создан!");
                    Console.ReadKey();
                    break;
                    
                case "2":
                    Console.WriteLine("Введите Id пользователя, которрого хотите редактировать");
                    string ValueId = Console.ReadLine();
                    int createUserId;
                    if (!int.TryParse(ValueId, out createUserId)) { Console.WriteLine("Вы ввели не число!"); Console.ReadKey(); return; }
                    
                    Console.WriteLine("Введите новое имя пользователя");
                    name = Console.ReadLine();
                    if (name == "") { Console.WriteLine("Вы не ввели имя!"); Console.ReadKey(); return; }
                    Console.WriteLine("Введите новую дату рождения");
                  
                    string ValueDate = Console.ReadLine();
                   
                    if (!DateTime.TryParse(ValueDate, out dateBirtgh)) { Console.WriteLine("Вы ввели не дату!"); Console.ReadKey(); return; }
                    if (Convert.ToDateTime(ValueDate) > DateTime.Now)
                    { Console.WriteLine("Вы ввели дату рождения из будущего!!!"); Console.ReadKey(); return; }
                    var user = userService.Get(createUserId);
                    user.Name = name;
                    user.BirthDay = dateBirtgh;
                    userService.CreateOrUpdate(user);
                    Console.WriteLine("Пользователь успешно отредактирован!");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("Введите Id пользователя, которого хотите удалить");
                    string valueDelete = Console.ReadLine();
                    int deleteUserId;
                    if (!int.TryParse(valueDelete, out deleteUserId)) { Console.WriteLine("Вы ввели не число!"); Console.ReadKey(); return; }
                    
                    userService.Remove(deleteUserId);
                    Console.WriteLine("Пользователь успешно удален!");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Введите наименоваание награды");
                    string title = Console.ReadLine();
                    if (title == "") { Console.WriteLine("Вы не ввели наименование награды!"); Console.ReadKey(); return; }

                    awardService.CreateOrUpdate(new Award()
                    {
                        Title = title
                    });
                    Console.WriteLine("Награда успешно создана!");
                    Console.ReadKey();
                    break;

                case "5":
                    Console.WriteLine("Введите Id награды, которую хотите редактировать");
                    string valueCreate = Console.ReadLine();
                    int createAwardId;
                    if (!int.TryParse(valueCreate, out createAwardId)) { Console.WriteLine("Вы ввели не число!"); Console.ReadKey(); return; }
                    
                    Console.WriteLine("Введите новое название награды");
                    name = Console.ReadLine();
                    if (name == "") { Console.WriteLine("Вы не ввели наименование награды!"); Console.ReadKey(); return; }

                    var award = awardService.Get(createAwardId);
                    award.Title = name;

                    awardService.CreateOrUpdate(award);
                    Console.WriteLine("Награда успешно редактирована!");
                    Console.ReadKey();
                    break;

                case "6":
                    Console.WriteLine("Введите Id награды, которую хотите удалить");
                    string valueDel = Console.ReadLine();
                    int deleteAwardId;
                    if (!int.TryParse(valueDel, out deleteAwardId)) { Console.WriteLine("Вы ввели не число!"); Console.ReadKey(); return; }
                    awardService.Remove(deleteAwardId);
                    Console.WriteLine("Награда успешно удалена!");
                    Console.ReadKey();
                    break;

                case "7":
                    Console.WriteLine("Введите Id пользователя, которому хотите вручить награду");
                    string valueId = Console.ReadLine();
                    int selectUser;
                    if (!int.TryParse(valueId, out selectUser)) { Console.WriteLine("Вы ввели не число!"); Console.ReadKey(); return; }
                    Console.WriteLine("Введите Id награды, которую хотите вручить данному пользователю");
                    string valueIdAw = Console.ReadLine();
                    int selectAward;
                    if (!int.TryParse(valueIdAw, out selectAward)) { Console.WriteLine("Вы ввели не число!"); Console.ReadKey(); return; }
                    int n = 0;
                    foreach (var item in awardService.Get())
                    {
                       if (item.Id == selectAward)
                        { n++; }
                    }
                    if (n == 0)
                    {
                        Console.WriteLine("Награды с таким id не существует!"); Console.ReadKey(); return;
                    }
                    userService.Get(selectUser).Awards.Add(awardService.Get(selectAward));
                    userService.CreateOrUpdate(userService.Get(selectUser));
                    Console.WriteLine("Награда успешно вручена пользователю!");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Команда была введена некорректно!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

