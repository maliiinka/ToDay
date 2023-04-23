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
