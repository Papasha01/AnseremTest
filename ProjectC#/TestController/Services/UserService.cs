using TestCore.Models;

namespace TestController.Services
{
    public static class UserService
    {
        public static string Analys(List<User> users)
        {
            var result = new List<string>();

            foreach (var user in users)
            {
                string phoneResult = Validators.Phone.Validate(user.Phone);

                string emailResult = Validators.Email.Validate(user.Email);

                int friendsCount = user.Friends?.Count ?? 0;

                string friendPairs = FriendPairsService.Get(user, users);

                string userResult = $"Имя: {user.Name}\n" +
                                   $"Номер телефона: {phoneResult}\n" +
                                   $"Почта: {emailResult}\n" +
                                   $"Количество друзей: {friendsCount}\n" +
                                   $"Дружеские пары: {friendPairs}";

                result.Add(userResult);
            }

            return string.Join("\n\n", result);
        }

        
    }
}
