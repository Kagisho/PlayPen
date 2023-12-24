using NSubstitute;
using NUnit.Framework;
using NUnit.Logic.Models;
using NUnit.Logic.Services;

namespace NUnit.Logic.Tests
{
    public class RegistrationProcessorShould
    {
        [Test]
        public void Reject_Registration_When_Age_Invalid()
        {
            var person = new Person
            {
                FirstName = "Young",
                LastName = "Child",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Now)
            };

            var validatorMock = Substitute.For<IValidator>();  
            var regProcessor = new RegistrationProcessor(validatorMock, null);
            
            var isRegistered = regProcessor.Register(person);

            Assert.That(isRegistered, Has
                                      .Property(nameof(isRegistered.RejectionReason)).EqualTo("Invalid age.")
                                      .And
                                      .Property(nameof(isRegistered.StudentNumber)).EqualTo(0));

        }

        [Test]
        public void Validator_Must_Not_Be_Called_When_Age_Is_Invalid()
        {
            var person = new Person
            {
                FirstName = "Young",
                LastName = "Child",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Now)
            };

            var validatorMock = Substitute.For<IValidator>();
            var regProcessor = new RegistrationProcessor(validatorMock, null);

            var isRegistered = regProcessor.Register(person);

            validatorMock.DidNotReceive().ValidateAge(person);
        }

        [Test]
        public void Accept_Registration_When_Age_Is_Valid()
        {
            var person = new Person
            {
                FirstName = "Valid",
                LastName = "Age",
                DateOfBirth = DateOnly.FromDateTime(new DateTime(1980,1,1))
            };

            var validatorMock = Substitute.For<IValidator>();
            validatorMock.ValidateAge(person).Returns(new ValidationResult { IsValid = true });

            var regProcessor = new RegistrationProcessor(validatorMock, null);

            var registrationResult = regProcessor.Register(person);

            Console.WriteLine(registrationResult.StudentNumber);

            Assert.That(registrationResult, Has
                                      .Property(nameof(registrationResult.RejectionReason)).Empty
                                      .And
                                      .Property(nameof(registrationResult.StudentNumber)).GreaterThan(0));

        }

        [Test]
        public void Validator_Must_Be_Called_When_Age_Is_Valid()
        {
            var person = new Person
            {
                FirstName = "Valid",
                LastName = "Age",
                DateOfBirth = DateOnly.FromDateTime(new DateTime(1980, 1, 1))
            };

            var validatorMock = Substitute.For<IValidator>();
            validatorMock.ValidateAge(person).Returns(new ValidationResult { IsValid = true });

            var regProcessor = new RegistrationProcessor(validatorMock, null);

            var registrationResult = regProcessor.Register(person);

            Console.WriteLine(registrationResult.StudentNumber);

           validatorMock.Received().ValidateAge(person);

        }
    }
}
