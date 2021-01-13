namespace PALConsoleTest.Models {
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("UsersAttendance")]
	public class UsersAttendance {

		[Key]
		public int UserAttendanceID { get; set; }
		public int? UserID { get; set; }
		public int? ClassID { get; set; }
		public DateTime? AttendanceDate { get; set; }
		public DateTime? TimeStamp { get; set; } = DateTime.Now;
		public bool? DeleteFlag { get; set; } = false;

	}
}