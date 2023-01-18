﻿using Microsoft.AspNetCore.Mvc;
using MVCModelBindingRestart.Models;

namespace MVCModelBindingRestart.Controllers
{
	public class StudentController : Controller
	{
		// GET: /Student/Create
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost] // This action is hit after the user submits form data
		public IActionResult Create(IFormCollection formData)
		{
			// Validate all data


			Student stu = new()
			{
				FirstName = formData["first-name"],
				LastName = formData["last-name"],
				DateOfBirth = DateTime.Parse(formData["date-of-birth"]),
				StudentEmail = formData["school-email"],
				PhoneNumber = formData["phone-number"]
			};


			// Add to database 
			// StudentDb.Add(stu);

			// Return a view

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult CreateWithModelBinding()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateWithModelBinding(Student stu)
		{
			if (ModelState.IsValid)
			{
				// Add to database 
				// StudentDB.Add(stu);

				// returns to Index view of HomeController
				return RedirectToAction("Index", "Home");
			}
			// If the ModelState is not valid
			// show the user the same web page,
			// with validation errors
			return View(stu);
		}
	}
}

