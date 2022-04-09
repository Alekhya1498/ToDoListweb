﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TodoList
    {
        public int Id { get; set; } 
        [Required]
        public string Items { get; set; }

        public DateTime Dates { get; set; }


    }
}
