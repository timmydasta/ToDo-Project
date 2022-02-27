using SessionManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ToDo.Models
{

    public class ViewModel
    {
        public List<ListTask> tasks { get; set; }
        
        //public SessionManager.tasks = tasks
    }

    public class ListTask
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
