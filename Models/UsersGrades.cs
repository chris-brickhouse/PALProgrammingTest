namespace PALConsoleTest.Models {
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("UsersGrades")]
	public class UsersGrades {

		[Key]
		public int UserGradeID { get; set; }
		public int? UserID { get; set; }
		public int? ClassID { get; set; }
		public int? Grade { get; set; }
		public DateTime? TimeStamp { get; set; } = DateTime.Now;
		public bool? DeleteFlag { get; set; } = false;

		[ForeignKey("ClassID")]
		public virtual Classes Class { get; set; }
	}
}