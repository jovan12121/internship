﻿using Microsoft.EntityFrameworkCore;

namespace Exercise1.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options):base(options) 
        {
        }
        public DbSet<TodoItem> ToDoItems { get; set; } = null!;
    }
}
