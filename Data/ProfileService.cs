using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PavRewards.Models;

namespace PavRewards.Data
{
    public class ProfileService
    {
        public Task<Profile> GetProfileAsync()
        {
            return Task.FromResult(new Profile
            {
                FirstName = "John",
                LastName = "Doe",
                Avatar = "avatar.png"
            });
        }
    }

}