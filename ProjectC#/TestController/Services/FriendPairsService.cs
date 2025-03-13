using TestCore.Models;

namespace TestController.Services
{
    public static class FriendPairsService
    {
        public static string Get(User user, List<User> allUsers)
        {
            if (user.Friends == null || !user.Friends.Any())
                return "\"Дружеские пары отсутствуют\"";

            var friendNames = user.Friends.Select(f => f.Name).ToList();
            var pairs = new List<string>();

            foreach (var friendName in friendNames)
            {
                var friend = allUsers.FirstOrDefault(u => u.Name == friendName);
                if (friend != null && friend.Friends != null &&
                    friend.Friends.Any(f => f.Name == user.Name))
                {
                    pairs.Add($"{user.Name} - {friendName}");
                }
            }

            return pairs.Any() ? string.Join(", ", pairs) : "\"Дружеские пары отсутствуют\"";
        }
    }
}