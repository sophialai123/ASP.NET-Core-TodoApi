using System;
namespace TodoAPI.Models
{
	public class TodoItem

	{
        //The Id property functions as the unique key in a relational database.
        public long Id { get; set; }
		public string? Name { get; set; }
		public bool IsComplete { get; set; }

        //The secret field needs to be hidden from this app,
        //but an administrative app could choose to expose it.
        public string? Secret { get; set; }
    }


    //Production apps typically limit the data that's input and returned using a subset of the model(DTO).
    //There are multiple reasons behind this, and security is a major one.
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

