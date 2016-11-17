using System.Threading.Tasks;
using AspNetStarter.Services;
using Microsoft.AspNetCore.Mvc;
using AspNetStarter.Repositories;
using Microsoft.AspNetCore.Authorization;


using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Logging;
using AspNetStarter.Models;
using AspNetStarter.Models.AccountViewModels;
using System.Text;
using AspNetStarter.Shared;

namespace AspNetStarter.Controllers
{
    [Route("api/[controller]")]
    public class UserAccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;

        public UserAccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ISmsSender smsSender,
            ILoggerFactory loggerFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }


        [HttpPost("register")]
        public async Task Register([FromBody]RegisterViewModel registrationModel)
        {
            var user = new ApplicationUser { UserName = registrationModel.Email, Email = registrationModel.Email };
            var result = await _userManager.CreateAsync(user, registrationModel.Password);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=532713
                // Send an email with this link
                //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                //var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                //await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
                //    $"Please confirm your account by clicking this link: <a href='{callbackUrl}'>link</a>");
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(3, "User created a new account with password.");
            }
            else
            {
                var errors = GetAllErrors(result);
                _logger.LogError(errors);
                throw new BusinessException(errors);
            }

        }

        private string GetAllErrors(IdentityResult result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var error in result.Errors)
            {
                sb.AppendLine(error.Description);
            }
            return sb.ToString();
        }


    }


}
