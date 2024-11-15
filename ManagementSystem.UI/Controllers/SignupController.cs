using ManagementSystem.Application.Features.Commands.FUser.CreateUser;
using ManagementSystem.Infrastructure.Securities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    public class SignupController : Controller
    {
        readonly private IMediator _mediator;

        public SignupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> üyeOl([FromBody] CreateUserCommandRequest model)
        {
            if (ModelState.IsValid)
            {
                var response = Get(model.UserPassword);
                foreach (var item in response.Value)
                {
                    model.UserPassword = item;
                    break;
                } 

              
                CreateUserCommandResponse res = await _mediator.Send(model);

                return Json(new { success = true, message = "Kayıt başarılı!" });
            }

            return Json(new { success = false, message = "Geçersiz giriş!" });
        }


        public ActionResult<IEnumerable<string>> Get(string key)
        {
            //METHOD1 Two Way
            //-------------------------------------------------------------------------
            var SCollection = new ServiceCollection();

            //add protection services
            SCollection.AddDataProtection();
            var LockerKey = SCollection.BuildServiceProvider();

            // create an instance of classfile using 'CreateInstance' method
            var locker = ActivatorUtilities.CreateInstance<Security>(LockerKey);
            string encryptKey = locker.Encrypt(key);
            string deencryptKey = locker.Decrypt(encryptKey);
            return new string[] { encryptKey, deencryptKey };

            //https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.cryptography.keyderivation.keyderivation.pbkdf2?view=aspnetcore-2.1
            //METHOD2 One Way
            //-------------------------------------------------------------------------
            //string salt = locker.HashCreate();
            //string encryptKey = locker.HashCreate(key, salt);

            //string getEncryptKey = encryptKey.Split('æ')[0];
            //string getSalt = encryptKey.Split('æ')[1];
            //string result = locker.ValidateHash(key, getSalt, getEncryptKey).ToString();
            //string deencryptKey = locker.ValidateHash(key, salt, encryptKey).ToString();

            //return new string[] { encryptKey, result, salt };
        }

    }
}
