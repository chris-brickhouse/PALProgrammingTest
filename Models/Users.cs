namespace PALConsoleTest.Models {
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Users")]
	public class Users {

		[Key]
		public int UserID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime? TimeStamp { get; set; } = DateTime.Now;
		public bool? DeleteFlag { get; set; } = false;
		public bool? IsTeacher { get; set; }

		// explain unmapped helper functions
		[NotMapped]
		public string FullName {
			get {
				return LastName + ", " + FirstName;
            }
        }

		// explain child objects, foreignkeys
		[ForeignKey("UserID")]
		public virtual List<UsersAttendance> UsersAttendance { get; set; }

		[ForeignKey("UserID")]
		public virtual List<UsersGrades> UsersGrades { get; set; }

	}
}