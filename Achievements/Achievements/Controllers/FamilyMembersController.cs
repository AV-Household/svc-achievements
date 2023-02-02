using Achievements.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Achievements.Controllers
{
    [ApiController]
    [Route("familymembers")]
    public class FamilyMembersController : ControllerBase
    {
        private static readonly List<FamilyMember> familyMembers = new List<FamilyMember>
        {
            new FamilyMember(0, "Папа", "+79370000000", "father@family.com", true),
            new FamilyMember(1, "Мама", "+79370000001", "mother@family.com", true),
            new FamilyMember(2, "Сын", "+79370000002", "son@family.com", false),
            new FamilyMember(3, "Дочь", "+79370000003", "daughter@family.com", false),
        };

        public static void AddFamilyMember(AddFamilyMemberDTO familyMember)
        {
            int newMemberID;
            if(familyMembers.Count == 0)
            {
                newMemberID = 0;
            }
            else
            {
                newMemberID = familyMembers.Last().ID + 1;
            }
            familyMembers.Add(new FamilyMember(newMemberID, familyMember.Name, familyMember.EMail, familyMember.Phone, familyMember.IsAdult));
            if(familyMember.IsAdult == false)
            {
                RatingPointsController.AddKid(newMemberID, 0);
            }
        }

        public static void DeleteFamilyMember(int idOfDeleted)
        {
            foreach(FamilyMember familyMember in familyMembers)
            {
                if(familyMember.ID == idOfDeleted)
                {
                    familyMembers.Remove(familyMember);
                    RatingPointsController.DeleteKid(familyMember.ID);
                    break;
                }
            }
        }

        public static void ClearFamilyMemberList()
        {
            familyMembers.Clear();
            RatingPointsController.ClearKidList();
        }

        public static List<FamilyMember> GetFamilyMembers()
        {
            return familyMembers;
        }

        public static FamilyMember GetMemberByID(int idOfMember)
        {
            foreach (FamilyMember familyMember in familyMembers)
            {
                if (familyMember.ID == idOfMember)
                {
                    return familyMember;
                }
            }
            return null;
        }

        public static FamilyMember GetMemberByName(string memberName)
        {
            foreach (FamilyMember familyMember in familyMembers)
            {
                if (familyMember.Name == memberName)
                {
                    return familyMember;
                }
            }
            return null;
        }

        [HttpGet]
        public List<FamilyMember> Get()
        {
            return familyMembers;
        }

        public record AddFamilyMemberDTO(string Name, bool IsAdult, string EMail, string Phone);
    }
}
