namespace SimpleToDoList
{

    class Program
    {

        public static void Main(string[] args)
        {
            List<Task> task = new List<Task>();
            Console.WriteLine("Привет вот мой консольный вариант ToDo листа выбери задачу:");
            int mesTsk = 0;

            Console.WriteLine(
                "1 Получить список задач;\n" +
                "2 Создать новую задачу\n" +
                "3 Удалить существующую задачу\n" +
                "4 Обновить существующую задачу\n" +
                "5 Выход  ");    
            
            do
            {

                string mes = Console.ReadLine();
               
                switch (mes)
                {
                    case "1":
                        Task().ListTask(task);
                        break;
                    case "2":
                        Task().CrieateTask(task);
                        break;
                    case "3":
                        Task().DeleteTask(task);
                        break;
                    case "4":
                        Task().UbdateTask(task);
                        break;
                    case "5":
                        mesTsk = 5;
                        Console.WriteLine("До скорой встречи");
                        Environment.Exit(0); // Закрыть консоль
                        break;
                    default:
                        Console.WriteLine("Такой команды нет :(");
                        mesTsk = -1;
                        break;
                }
            } while (mesTsk == -1);

            if (mesTsk != -1)
            {
                Console.ReadLine();
            }

        }
    }

    class Task
    {
        int id;
        string title;
        string description;
        DateTime dueDate;
        bool isCopleted;

        public void Tasks(int Id, string Title, string Description, DateTime DueDate, bool IsCopleted)
        {
            this.id = Id;
            this.title = Title;
            this.description = Description;
            this.dueDate = DueDate;
            this.isCopleted = IsCopleted;
        }

        public void ListTask(List<Task> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Задач нет");
                return;
            }
            Console.WriteLine("Список задач:");
            foreach (var t in tasks)
            {
                Console.WriteLine(t);
            }
        }

        public void CreateTask(List<Task> tasks)
        {
            Console.WriteLine("Создание новой задачи:");
            Console.Write("Заголовок: ");
            int id = tasks.Count + 1;
            string title = Console.ReadLine();
            Console.Write("Описание: ");
            string des = Console.ReadLine();
            Console.Write("Дата: ");
            DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            bool cb = false;

            tasks.Add(new Tasks(id, title, des, dt, cb));
        }

        public void DeleteTask(List<Task> tasks)
        {
            if (true)
            {

            }
        }
        public void UbdateTask(List<Task> tasks)
        {
            if (true)
            {

            }
        }
    }
}