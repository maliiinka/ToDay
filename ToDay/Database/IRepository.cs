using ToDay.Database.Models;

namespace ToDay.Database
{
    internal interface IRepository
    {
        public void ensureCreated();

        //dev features
        public void fillEfficiencyTable();
        public void fillTaskTable();
        public void fillTables();

        //Tasks handle
        public void addTask(Models.Task task);
        public void removeTask(Models.Task task);
        public Models.Task getTaskById(int id);
        public List<Models.Task> getTasksByCreatedDay(DateTime createdAt);
        public List<Models.Task> getTasksBySheduledDay(DateTime sheduledFor);

        //Efficiencies handle
        public void addEfficiency(Efficiency efficiency);
        public void removeEfficiency(Efficiency efficiency);
        public Efficiency getEfficiencyById(int id);
        public List<Efficiency> getEfficienciesByDay(DateTime day);
        public List<Efficiency> getEfficienciesByCompletedTasks(int completedTasks);
    }
}
