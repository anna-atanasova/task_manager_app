using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { set; get; }

        public bool IsDone { get; set; }
    }
}
