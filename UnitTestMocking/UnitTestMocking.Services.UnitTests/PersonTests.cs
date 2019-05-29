using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestMocking.Contracts;
using UnitTestMocking.Repositories;

namespace UnitTestMocking.Services.UnitTests
{
    [TestClass]
    public class PersonTests
    {
        private PersonService _personService;
        private Mock<PersonRepository> _personRepository;

        [TestInitialize]
        public void Setup()
        {
            _personRepository = new Mock<PersonRepository>();

            _personService = new PersonService(_personRepository.Object);
        }

        [TestCleanup]
        public void TearDown()
        {
            _personRepository = null;
            _personService = null;
        }

        [TestMethod]
        public void CreatePerson()
        {
            //Arrange
            var person = new Person() { Id = 1, Name = "John" };

            _personRepository.Setup(x => x.Create(It.IsAny<Person>()));

            //Act
            _personService.Create(person);

            //Assert
            _personRepository.Verify(x => x.Create(It.IsAny<Person>()), Times.Once);
        }
    }
}