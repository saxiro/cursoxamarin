﻿using SpaUserControl.Common.Resources;
using SpaUserControl.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaUserControl.Domain.Models
{
    public class User
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public void SetPassword(string password, string confirmPassword)
        {
            AssertionConcern.AssertArgumentNotNull(password, Errors.InvalidPassword);
            AssertionConcern.AssertArgumentNotNull(confirmPassword, Errors.InvalidPasswordConfirmation);
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, Errors.InvalidPasswordConfirmation);
            AssertionConcern.AssertArgumentLength(password, 6, 20, Errors.InvalidPassword);
            Password = PasswordAssertionConcern.Encrypt(Password);
        }

        public string ResetPassword()
        {
            string password = Guid.NewGuid().ToString().Substring(0, 8);
            this.Password = PasswordAssertionConcern.Encrypt(password);

            return password;
        }
    }
}
