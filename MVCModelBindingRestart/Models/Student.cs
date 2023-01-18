using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCModelBindingRestart.Models
{
	public class Student
	{
		[Key] // Make this property primary key
		public int Id { get; set; }

		/// <summary>
		/// The legal first name
		/// </summary>
		[Display(Name = "First Name")]
		[Required(ErrorMessage = "{0} is required.")]
		public string FirstName { get; set; }

		/// <summary>
		/// The legal last name
		/// </summary>
		[Display(Name = "Last Name")]
		[Required(ErrorMessage = "{0} is required.")]
		public string LastName { get; set; }

		/// <summary>
		/// Student's Date of birth
		/// </summary>
		[Display(Name = "Date Of Birth")]
		[Required(ErrorMessage = "{0} is required.")]
		[DataType(DataType.Date)] // display Date picker
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		/// The assigned school email address
		/// </summary>
		//[Required()]
		[Display(Name = "Student Email")]
		// [DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "Invalid email address.")]
		public string? StudentEmail { get; set; }

		/// <summary>
		/// Student's preferred contact number
		/// </summary>
		//[Required()]
		[Display(Name = "Phone Number")]
		// [DataType(DataType.PhoneNumber)]
		[Phone]
		public string? PhoneNumber { get; set; }
	}
}
