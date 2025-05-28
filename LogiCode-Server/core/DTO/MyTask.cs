using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class MyTask
    {
            public int Id { get; set; }  
            public string Title { get; set; }
            public bool IsCompleted { get; set; }
            public DateTime CreatedAt { get; set; }
            public int StudentId { get; set; }
    }
}
