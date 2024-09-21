using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                               new User
                               {
                                   Id = Guid.NewGuid(),
                                   Name = "Jon&Linda",  
                                   Password = "blllllll"
                               },
                                new User
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "BillieBob",
                                    Password = "password"
                                },
                                new User
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Sally",
                                    Password = "password"
                                }
                );
        }
    }
}
