using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }
		[StringLength(50)]
		//[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
		public string LastName { get; set; }
		[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
		[Column("FirstName")]
		//[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
		public string FirstMidName { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime EnrollmentDate { get; set; }
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}