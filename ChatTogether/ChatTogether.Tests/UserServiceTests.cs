using AutoMapper;
using ChatTogether.Application.Services;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Domain.Interface;
using ChatTogether.Infrastructure;
using ChatTogether.Infrastructure.Repositories;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;


namespace ChatTogether.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void CanAddUser()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Test23",
                    Surname = "SurnameTest23",
                    Nickname = "Test23",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                int idNewUser = userService.AddUser(user);
                var newUser = userService.GetUserById(idNewUser);

                //Assert
                idNewUser.Should().NotBe(0);
                newUser.Nickname.Should().Be(user.Nickname);
            }
        }

        [Fact]
        public void CheckNameExists()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Test23",
                    Surname = "SurnameTest23",
                    Nickname = "Test23",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRegister user2 = new UserRegister()
                {
                    Name = "Test23",
                    Surname = "SurnameTest23",
                    Nickname = "Test23",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                int idNewUser = userService.AddUser(user);
                var isUnique = userService.CheckNameUniqueness(user2.Nickname);

                //Assert
                isUnique.Should().BeFalse();
            }
        }

        [Fact]
        public void CheckEmailExixts()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Test23",
                    Surname = "SurnameTest23",
                    Nickname = "Test23",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRegister user2 = new UserRegister()
                {
                    Name = "Test23",
                    Surname = "SurnameTest23",
                    Nickname = "Test233",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                int idNewUser = userService.AddUser(user);
                var isUnique = userService.CheckEmailUniqueness(user2.EmailAddress);

                //Assert
                isUnique.Should().BeFalse();
            }
        }

        [Fact]
        public void CanConfirmAccountAndLogin()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Test23",
                    Surname = "SurnameTest23",
                    Nickname = "Test23",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                int idNewUser = userService.AddUser(user);
                Guid link = Guid.NewGuid();
                userService.AddConfirmation(link, user);
                userService.AccountConfirmation(link.ToString());
                var isLoginSuccess = userService.IsSucceslogin(user.Nickname, user.EncryptedPassword);

                //Assert
                isLoginSuccess.Should().BeTrue();
            }
        }

        [Fact]
        public void CanAddFriend()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Janek",
                    Surname = "Kowalski",
                    Nickname = "Janko",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRegister user2 = new UserRegister()
                {
                    Name = "Bartek",
                    Surname = "Nowak",
                    Nickname = "Bartko",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };
                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                var createUserId = userService.AddUser(user);
                var createUser2Id = userService.AddUser(user2);
                userService.AddFriend(createUserId.ToString(), createUser2Id);
                var friendList = userService.GetFriendList(createUser2Id.ToString());

                //Assert
                friendList.PendingFriends.Should().HaveCount(1);
                friendList.Friends.Should().HaveCount(0);

            }
        }

        [Fact]
        public void CanFindUsers()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Janek",
                    Surname = "Nowak",
                    Nickname = "Janko",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRegister user2 = new UserRegister()
                {
                    Name = "Bartek",
                    Surname = "Nowak",
                    Nickname = "Bartko",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };
                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                var createUserId = userService.AddUser(user);
                userService.AddUser(user2);
                var result = userService.GetUsers("Nowak", createUserId.ToString());

                //Assert
                result.Should().HaveCountGreaterOrEqualTo(1);

            }
        }

        [Fact]
        public async Task CanSendMessage()
        {
            var options = new DbContextOptionsBuilder<Context>()
            .UseInMemoryDatabase(databaseName: "ChatTogether")
            .Options;

            using (var context = new Context(options))
            {
                //Arrange
                UserRegister user = new UserRegister()
                {
                    Name = "Janek",
                    Surname = "Nowak",
                    Nickname = "Janko",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };

                UserRegister user2 = new UserRegister()
                {
                    Name = "Bartek",
                    Surname = "Nowak",
                    Nickname = "Bartko",
                    EmailAddress = "test23@wp.pl",
                    ConfirmEmailAddress = "test23@wp.pl",
                    EncryptedPassword = "haslo123",
                    ConfirmPassword = "haslo12",
                    DateOfBirth = new DateTime(1999, 06, 12),
                    Policy = true,
                    Rodo = true
                };
                UserRepository userRepository = new UserRepository(context);
                UserService userService = new UserService(userRepository);

                //Act
                var createUserId = userService.AddUser(user);
                var createUser2Id = userService.AddUser(user2);
                await userService.SendMessage(createUserId, createUser2Id, "wiadomoœæ1");
                await userService.SendMessage(createUserId, createUser2Id, "wiadomoœæ2");
                await userService.SendMessage(createUserId, createUser2Id, "wiadomoœæ3");

                var messages = userService.GetMessage(createUser2Id, createUserId);

                //Assert
                messages.Should().HaveCount(3);

            }
        }
    }
}
