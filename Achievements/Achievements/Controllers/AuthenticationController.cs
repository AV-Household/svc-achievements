using Achievements.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Achievements.Controllers
{
    [ApiController]
    [Route("authentication")]
    public class AuthenticationController : Controller
    {
        private static int authencticatedUserId = -1;
        private static bool isAuthorizedUserAdult = false;

        [HttpPost]
        public string LogIn(string Name, string password)
        {
            if (authencticatedUserId == -1)
            {
                FamilyMember loggedMember = FamilyMembersController.GetMemberByName(Name);
                if (loggedMember == null)
                {
                    return "Пользователь с таким именем не найден";
                }
                else if (loggedMember.IsAdult == true && password == "iamadult" || loggedMember.IsAdult == false && password == "iamkid")
                {
                    authencticatedUserId = loggedMember.ID;
                    isAuthorizedUserAdult = loggedMember.IsAdult;
                    return "Успешная аутентификация";
                }
                else
                {
                    return "Неверный пароль";
                }
            }
            else
            {
                return "Необходимо выйти из текущего аккаунта";
            }
        }

        [HttpDelete]
        public string LogOut()
        {
            if(authencticatedUserId == -1)
            {
                return "Вход в аккаунт не выполнен";
            }
            else
            {
                authencticatedUserId = -1;
                return "Выход из аккаунта выполнен";
            }
        }

        public static int GetID()
        {
            return authencticatedUserId;
        }

        public static bool IsUserAuthorized()
        {
            return authencticatedUserId != -1;
        }

        public static bool IsAuthorizedAdult()
        {
            return authencticatedUserId != -1 && isAuthorizedUserAdult;
        }
    }
}
