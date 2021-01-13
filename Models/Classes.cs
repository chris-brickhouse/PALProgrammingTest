namespace PALConsoleTest.Models {
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Classes")]
	public class Classes {

		[Key]
		public int ClassID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal? Cost { get; set; }
		public int? Capacity { get; set; }
		public int? LocationID { get; set; }
		public DateTime? TimeStamp { get; set; } = DateTime.Now;
		public bool? DeleteFlag { get; set; } = false;

	}
}