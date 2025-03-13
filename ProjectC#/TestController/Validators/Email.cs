using System.Text.RegularExpressions;

namespace TestController.Validators
{
    public static class Email
    {
        public static string Validate(string email)
        {
            if (string.IsNullOrEmpty(email))
                return "\"Почта отсутствует\"";

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "\"Почта содержит ошибки\"";

            return email;
        }
    }
}
