using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class Project
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}