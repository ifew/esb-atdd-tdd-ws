using System;

namespace api.Unittest
{
    public class MemberServiceTest
    {
        [Fact]
        public void GetMemberInfo_Success_ReturnMemberInfo(){

            var umayplusCardID = "6273885053341539";
            var personalCardID = "3100505143401";
            var birthDate = "01/01/2530";
            var mobilePhone = "092224955";

            var expectMember = new MemberServiceTest()
            {
                UmayplusCardID = "6273885053341539",
                PersonalCardID = "3100505143401",
                BirthDate = "01/01/2530", 
                MobilePhone = "092224955"
                FirstName = "Nathawat",
                LastName = "Thumthiwong"
            };

            MemberService memberService = new MemberService();
            Member actualMember = MemberService.getMemberInfo(umayplusCardID, personalCardID, birthDate, mobilePhone);
            


        }
    }
}
