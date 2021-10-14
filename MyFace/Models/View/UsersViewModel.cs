using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class UsersViewModel
    {
        public IEnumerable<UserViewModel> Users { get; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalUsers { get; set; }

        public UsersViewModel(IEnumerable<User> users, int pageNumber, int pageSize, int totalUsers)
        {
            Users = users.Select(user => new UserViewModel(user));
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalUsers = totalUsers;
        }
    }
}