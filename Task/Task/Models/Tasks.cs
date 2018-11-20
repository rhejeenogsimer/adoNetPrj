using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class Task
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool Complete { get; set; }
        [Display(Name ="Due Date")]
        public DateTime DueDate { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}