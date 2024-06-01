using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Budget_Buddy.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionID { get; set; }

		[Range(1,int.MaxValue, ErrorMessage ="Please select a catergory")]
        public int CategoryId { get; set; }
		public Category? Category { get; set; }

        [Range(0.0001, int.MaxValue, ErrorMessage = "Amount should be greater than Zero")]
        public int Amount { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Note { get; set; }

		public DateTime Date { get; set; } = DateTime.Now;

		[NotMapped]
		public string? FormattedAmount {
			get {
				return (Category == null || Category.Type == "Expense" ? "- " : "+ ") + Amount.ToString("c0", CultureInfo.GetCultureInfo("en-us")) ;
			}
		}

		[NotMapped]
		public string? CategoryWithIcon {
			get {
				return Category == null ? " " : Category.TitleWithIcon;
				}
		}

		public Transaction()
		{
		}
	}
}

