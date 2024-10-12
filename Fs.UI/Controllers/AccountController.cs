using Fs.BusinessLogicLayer.Abstract;
using Fs.BusinessLogicLayer.Concrete;
using Fs.BusinessLogicLayer.Dtos;
using FS.CoreLayer.Helper;
using FS.ExternalServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fs.UI.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public AccountController(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            CreateUserDto userDto = new();
            return View(userDto);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserDto userDto)
        {
            var result = await _userService.CreateUserAsync(userDto);

            if (result.ResponseType == FS.CoreLayer.Enums.ResponseType.ValidationError)
            {
                foreach (var item in result.ResponseValidationResults)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    );

                return Json(new { success = false, errors });
            }
            string url = $"http://localhost:5226/account/ConfirmEmail?code={result.Data.ConfirmCode}&userId={result.Data.Id}";
            var htmlMessage = HtmlTemplateGenerator.ConfirmMessage("Click button for complete email verification", url);
            await _emailService.SendEmailAsync(result.Data.Email, "ConfirmationCode", htmlMessage);
            return Json(new { success = true, message = "Registration successful! Please check your email to confirm." });
        }

        [HttpGet]

        public async Task<IActionResult> ConfirmEmail(int code, int userId)
        {
            return Json("Hey");

        }
    }
}