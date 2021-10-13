using System.Collections.Generic;
using MyFace.Models.Database;

namespace MyFace.Data
{
    public static class SampleUsers
    {
        public static IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    FirstName = "Gard",
                    LastName = "Fundell",
                    Username = "gfundell0",
                    Email = "gfundell0@drupal.org",
                    ProfileImageUrl = "https://s3-us-west-2.amazonaws.com/uw-s3-cdn/wp-content/uploads/sites/6/2013/04/04195807/david_notkin220.jpg",
                    CoverImageUrl = "https://i.picsum.photos/id/200/1280/480.jpg",
                },
                new User
                {
                    FirstName = "Malissa",
                    LastName = "Shuttle",
                    Username = "mshuttle1",
                    Email = "mshuttle1@about.me",
                    ProfileImageUrl = "https://static.wixstatic.com/media/3410bd_526a44dd605c4a739fd53d490a344fd9~mv2_d_1824_2280_s_2.jpg/v1/fill/w_1000,h_1250,al_c,q_90,usm_0.66_1.00_0.01/3410bd_526a44dd605c4a739fd53d490a344fd9~mv2_d_1824_2280_s_2.jpg",
                    CoverImageUrl = "https://i.picsum.photos/id/201/1280/480.jpg",
                },
                new User
                {
                    FirstName = "Mabelle",
                    LastName = "Vereker",
                    Username = "mvereker2",
                    Email = "mvereker2@t.co",
                    ProfileImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Donald_William_Bain_%28cropped%29.jpg",
                    CoverImageUrl = "https://i.picsum.photos/id/202/1280/480.jpg",
                },
                new User
                {
                    FirstName = "Harmon",
                    LastName = "Winsley",
                    Username = "hwinsley3",
                    Email = "hwinsley3@mashable.com",
                    ProfileImageUrl = "https://www.biography.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cg_face%2Cq_auto:good%2Cw_300/MTE5NTU2MzE2MzMwMTAwMjM1/friedrich-nietzsche-9423452-1-402.jpg",
                    CoverImageUrl = "https://i.picsum.photos/id/203/1280/480.jpg",
                },
                new User
                {
                    FirstName = "Annamaria",
                    LastName = "Cruttenden",
                    Username = "acruttenden4",
                    Email = "acruttenden4@ucoz.ru",
                    ProfileImageUrl = "https://cottage.images.holiday/Redhurst-Cottage-Lamlash-near-Brodick-Isle-Of-Arran-large.jpg",
                    CoverImageUrl = "https://i.picsum.photos/id/204/1280/480.jpg",
                },
            };
        }
    }
}