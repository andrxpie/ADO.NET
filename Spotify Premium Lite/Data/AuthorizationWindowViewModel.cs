using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite.Data
{
    class AuthorizationWindowViewModel
    {
        public SpotifyLiteDbContext database = new();
        public ICollection<User> users => database.Users.ToArray();

        public AuthorizationWindowViewModel()
        {

        }
    }
}