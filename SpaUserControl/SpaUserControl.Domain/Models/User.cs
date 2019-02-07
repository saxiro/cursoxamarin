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
            AssertionConcern.AssertArgumentNotNull(password, "Senha Inválida");
            AssertionConcern.AssertArgumentNotNull(confirmPassword, "Confirmação Inválida");
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, "A senha e confirmação não coincidem.");
            AssertionConcern.AssertArgumentLength(password, 6, 20, "A senha deve conter entre 6 e 20 caracteres");
            Password = password;
        }
    }
}
