using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubApp.StaticUtils
{
    public static class TaskFactories
    {
        private static List<Task> _tasks = new List<Task>();
        public static int StartTask(Action action)
        {
            var task = new Task(() => { action.Invoke(); });
            _tasks.Add(task);
            task.Start();
            return task.Id;
        }

        public static int StartTask<TType>(Action<TType> action, TType obj)
        {
            var task = new Task(() => { action.Invoke(obj); });
            _tasks.Add(task);
            task.Start();
            return task.Id;
        }

        public static int StartTask<TType1, TType2>(Action<TType1, TType2> action, TType1 obj1, TType2 obj2)
        {
            var task = new Task(() => { action.Invoke(obj1, obj2); });
            _tasks.Add(task);
            task.Start();
            return task.Id;
        }

        public static bool CloseTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                try
                {
                    task.Dispose();
                    return true;
                }
                catch
                {
                }
            }
            return false;
        }
    }
}
