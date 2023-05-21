using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDay.Database.Models;

namespace ToDay.Database
{
    internal class Repository : IRepository
    {
        public void addTask(Models.Task task)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                applicationContext.tasks.Add(task);
                applicationContext.SaveChanges();
            }
        }

        public void ensureCreated()
        {
            ApplicationContext applicationContext = new ApplicationContext();
        }

        public void fillTables()
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                if (applicationContext.tasks.Count() == 0 && applicationContext.efficiencies.Count() == 0)
                {
                    fillEfficiencyTable();
                    fillTaskTable();
                }
            }
        }

        public void fillEfficiencyTable()
        {
            Efficiency temp;
            Random random = new Random();

            for (int i = 1; i < 8; i++)
            {
                temp = new Efficiency();
                temp.completed_tasks = random.Next(5, 15);
                temp.day = DateTime.Now.AddDays(-1 * i);
                addEfficiency(temp);
            }
        }

        public void fillTaskTable()
        {
            Models.Task temp;

            temp = new Models.Task();
            temp.name = "Зарядка и разминка";
            temp.description = "В течение дня нужно сделать пробежку и разминку.";
            temp.created_at = DateTime.Now.AddHours(-12);
            temp.sheduled_for = DateTime.Now.AddHours(20);
            temp.is_active = true;
            temp.is_priority = true;
            addTask(temp);

            temp = new Models.Task();
            temp.name = "Покупки";
            temp.description = "Купить в магазине картошку и кефир.";
            temp.created_at = DateTime.Now.AddHours(-10);
            temp.sheduled_for = DateTime.Now.AddHours(22);
            temp.is_active = true;
            temp.is_priority = false;
            addTask(temp);

            temp = new Models.Task();
            temp.name = "Посетить встречу";
            temp.description = "Принять участие в мите с командой.";
            temp.created_at = DateTime.Now.AddHours(-8);
            temp.sheduled_for = DateTime.Now.AddHours(23);
            temp.is_active = true;
            temp.is_priority = false;
            addTask(temp);

            temp = new Models.Task();
            temp.name = "Сходить на консультацию";
            temp.description = "Сходить к врачу на консультацию.";
            temp.created_at = DateTime.Now.AddHours(-6);
            temp.sheduled_for = DateTime.Now.AddHours(24);
            temp.is_active = true;
            temp.is_priority = false;
            addTask(temp);

            temp = new Models.Task();
            temp.name = "Важно";
            temp.description = "Полить цветы.";
            temp.created_at = DateTime.Now.AddHours(-12);
            temp.sheduled_for = DateTime.Now.AddHours(27);
            temp.is_active = true;
            temp.is_priority = true;
            addTask(temp);
        }

        public List<Models.Task> getTasksByCreatedDay(DateTime createdAt)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                return applicationContext.tasks.Where(t => t.created_at == createdAt).ToList();
            }
        }

        public Models.Task getTaskById(int id)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                return applicationContext.tasks.Where(t => t.task_Id == id).Single();
            }
        }

        public List<Models.Task> getTasksBySheduledDay(DateTime sheduledFor)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                return applicationContext.tasks.Where(t => t.sheduled_for == sheduledFor).ToList();
            }
        }

        public void removeTask(Models.Task task)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                applicationContext.tasks.Remove(task);
            }
        }

        public void addEfficiency(Efficiency efficiency)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                applicationContext.efficiencies.Add(efficiency);
                applicationContext.SaveChanges();
            }
        }

        public void removeEfficiency(Efficiency efficiency)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                applicationContext.efficiencies.Remove(efficiency);
            }
        }

        public Efficiency getEfficiencyById(int id)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                return applicationContext.efficiencies.Where(e => e.efficiency_Id == id).Single();
            }
        }

        public List<Efficiency> getEfficienciesByDay(DateTime day)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                return applicationContext.efficiencies.Where(e => e.day == day).ToList();
            }
        }

        public List<Efficiency> getEfficienciesByCompletedTasks(int completedTasks)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                return applicationContext.efficiencies.Where(e => e.completed_tasks == completedTasks).ToList();
            }
        }
    }
}
