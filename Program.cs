namespace SimpleToDoList
{

    class Program
    {

        public static void Main(string[] args)
        {
            string path = @"D:\LAV\Files\Programming\Plan\SimpleToDoList\files\tasks.json";

            Console.WriteLine("[sys_mes]: Список доступных задач:");
                        //не работает!
            ToDo toDo = new ToDo();
            toDo.ListTasks(path);
            int numTask = -1;
            Console.WriteLine("[sys_mes]: Добро пожаловать в To-do list выберите действие:");
            do
            {
                Console.WriteLine("[sys_mes]:" +
                "\n 1 - Вывод задач: " +
                "\n 2 - Ввод задачи: " +
                "\n 3 - Отметить выполнение:" +
                "\n 0 - Выход ");

                numTask= Convert.ToInt32(Console.ReadLine());
                switch (numTask)
                {
                    case 0:
                        Console.WriteLine("[sys_mes]: До скорой встречи.");
                        break;
                    case 1:
                        toDo.ListTasks(path);
                        break;
                    case 2:
                        toDo.WriteTask(path);
                        break;
                    default:
                        Console.WriteLine("[sys_mes]: Такой команды не существует.");
                        break;
                }

            } while (numTask != 0);
        }
    } 
}