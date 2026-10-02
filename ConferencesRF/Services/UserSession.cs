using ConferencesRF.Models;

namespace ConferencesRF.Services
{
    public class UserSession
    {

        public int? UserId { get; set; }

        public string? UserName { get; set; }

        public string? UserRole { get; set; }

        public bool IsAuthenticated => UserId != null;

        public void SetUser(int userId, string userName, string userRole)
        {
            UserId = userId;
            UserName = userName;
            UserRole = userRole;
        }

        public void Clear()
        {
            UserId = null;
            UserName = null;
            UserRole = null;
        }
    }
}
