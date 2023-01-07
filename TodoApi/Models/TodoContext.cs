using System;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{

    //The database context is the main class that coordinates Entity Framework functionality for a data model.
    //This class is created by deriving from Microsoft.EntityFrameworkCore.DbContext class.
    public class TodoContext: DbContext
	{
		public TodoContext(DbContextOptions <TodoContext> options) :base(options)
		{
		}

        //! (null-forgiving) operator (C# reference)
        //suppress all nullable warnings for the preceding expression
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
	}
}
  
