using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Budget_Buddy.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }

		[Column(TypeName = "nvarchar(50)")]
		[Required(ErrorMessage ="Title is Required")]
		public string Title { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string Icon { get; set; } = "";

		[Column(TypeName = "nvarchar(20)")]
		public string Type { get; set; } = "Expense";

		[NotMapped]
		public string? TitleWithIcon
		{
			get { return this.Icon + " " + this.Title; }
		}



        public Category() 
		{
		}
	}
}

