using ManagementSystem.Infrastructure.Securities;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
