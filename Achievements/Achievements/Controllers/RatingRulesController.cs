using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Achievements.Controllers
{
    [ApiController]
    [Route("ratingrules")]

    public class RatingRulesController : ControllerBase
    {
        private static readonly int[] ratingCountingRules = { 0, 0, 0, 0, 0, 0 }; //по индексам: 0 - за невыполненную задачу, 1 - за выполненную, 2-5 - за соответсвующую оценку

        public static int[] GetRatingRules()
        {
            return ratingCountingRules;
        }

        public static void SetRatingRules(int[] newRatingRules)
        {
            for(int i = 0; i < ratingCountingRules.Length; i++)
            {
                ratingCountingRules[i] = newRatingRules[i];
            }
        }

        [HttpGet(Name = "Получить правила подсчета рейтинга")]
        public int[] Get()
        {
            if (AuthenticationController.IsUserAuthorized())
            {
                return ratingCountingRules;
            }
            else return null;
        }

        [HttpPost(Name = "Изменить правило подсчета рейтинга")]
        public void ChangeRule(int ruleIndex, int points)
        {
            if (AuthenticationController.IsAuthorizedAdult())
            {
                ratingCountingRules[ruleIndex] = points;
            }
        }
    }
}
