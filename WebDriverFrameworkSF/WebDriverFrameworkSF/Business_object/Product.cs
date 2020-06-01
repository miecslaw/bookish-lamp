using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFrameworkSF
{
    class User
    {
        public string nameInput { get; set; }
        public string passwordInput { get; set; }
        public User(string nameInput,
                    string passwordInput)
        {
            this.nameInput = nameInput;
            this.passwordInput = passwordInput;
        }

    }
}