﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebUI.MVC.Models;
using WebUI.MVC.Services.Interfaces;

namespace WebUI.MVC.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserManagement _userManagement;

        public UserController(IUserManagement userManagement)
        {
            _userManagement = userManagement;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(User user)
        {
            var authEntity = await _userManagement.CreateUser(user);
            TempData["Message"] = "Success : User has been succesfully created";
            return RedirectToAction("GetAll");
        }

        

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userManagement.GetAllUsers();
            return View(users);
        }


        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManagement.GetUserById(id);
            if(user == null)
            {
                TempData["Message"] = "Error : This user cannot be deleted";
                return RedirectToAction("GetAll");
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        {
            await _userManagement.DeleteById(id);
            TempData["Message"] = "Warning : User has been deleted";
            return RedirectToAction("GetAll");
        }
    }
}
