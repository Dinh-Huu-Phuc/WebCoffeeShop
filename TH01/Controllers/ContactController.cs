﻿using Microsoft.AspNetCore.Mvc;
using TH01.Data;
using TH01.Models;

namespace TH01.Controllers
{
    public class ContactController : Controller
    {
        private readonly CoffeeshopDbContext _context;

        public ContactController(CoffeeshopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new Contact());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Send(Contact model)
        {
            if (ModelState.IsValid)
            {
                var contactMessage = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message,
                    SentDate = DateTime.Now
                };

                _context.ContactMessages.Add(contactMessage);
                await _context.SaveChangesAsync();


                ViewBag.SuccessMessage = "Tin nhắn của bạn đã được gửi thành công. Chúng tôi sẽ liên hệ lại với bạn sớm nhất!";

                ModelState.Clear();
                return View("Index", new Contact());

            }


            ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin bạn đã nhập.";
            return View("Index", model);
        }
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}