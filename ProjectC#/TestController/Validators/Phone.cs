using System.Text.RegularExpressions;

namespace TestController.Validators
{
    public static class Phone
    {
        public static string Validate(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return "\"Номер телефона отсутствует\"";

            string digitsOnly = Regex.Replace(phone, @"[^\d]", "");
            if (digitsOnly.Length < 11 || !Regex.IsMatch(phone, @"^\+\d\s\(\d{3}\)\s\d{3}-\d{4}$"))
                return "\"Номер телефона содержит ошибки\"";

            return phone;
        }
    }
}
