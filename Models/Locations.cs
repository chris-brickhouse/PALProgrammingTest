namespace PALConsoleTest.Models {
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Locations")]
	public class Locations {

		[Key]
		public int LocationID { get; set; }
		public string Name { get; set; }
		public DateTime? TimeStamp { get; set; } = DateTime.Now;
		public bool? DeleteFlag { get; set; } = false;

	}
}