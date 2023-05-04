﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Pure_Life.ViewModel.Stafi
{
	public class EditStafiViewModel
	{
		public int Id { get; set; }
		public string? NrLeternjoftimit { get; set; }
		public string? Imagelink { get; set; }
		public string Emri { get; set; }
		public string Mbiemri { get; set; }
		public string? Gjinia { get; set; }
		public DateTime? DataLindjes { get; set; }
		public string? NrLincences { get; set; }
		public string? NrTel { get; set; }
		public int RoletId { get; set; }
		public string Email { get; set; }
		public string EmailZyrtar { get; set; }
		public int? ShtetiId { get; set; }
		public string? Qyteti { get; set; }
		public int? NacionalitetiId { get; set; }
		public int? LemiaId { get; set; }
		public DateTime ModifiedDate { get; set; }
	    public string ModifiedFrom { get; set; }
/*		public string? Imagelink { get; set; }*/

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Confirm password")]
		[Required(ErrorMessage = "Confirm password is required")]
		[DataType(DataType.Password)]

		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }

		public IFormFile? PictureUrl { get; set; }
		public bool? IsDeleted { get; internal set; }
		public DateTime? InsertedDate { get; internal set; }
		public string? InsertedFrom { get; internal set; }
		public string? PublicId { get; internal set; }
	}
}
