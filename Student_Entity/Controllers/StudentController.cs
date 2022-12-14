﻿using Microsoft.AspNetCore.Mvc;
using Student_Entity.Data;
using Student_Entity.Models;

namespace Student_Entity.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _db;
        
        public StudentController(StudentDbContext db)
        {
            _db = db;   
        }

        public IActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public IActionResult Add() 
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();  
                return RedirectToAction("Index");   
            }
            return View(student);
        }
    }
}
