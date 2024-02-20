using NUnit.Framework;
using Moq;
using School;
namespace Assesment_Nunit_Moq
{
    [TestFixture]
    public class Tests
    {
        SchoolMng SchMng;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TeacherNullTest()
        {
            foreach(var s in SchoolMng.allTeacher()) 
            {
                Assert.IsNotNull(s.Tid);
                Assert.IsNotNull(s.TeacherName);
            }
        }
        [Test]
        public void sutendNull()
        {
            int RollNumber = 1;
            Assert.IsNotNull(SchoolMng.EmpById(RollNumber));
        }
        [Test]
        public void MoqTeacherName()
        {
            var classes = new Mock<Teachers>();
            var techaer = classes.Object;
            Assert.IsNotNull(techaer);
        }

    }
}