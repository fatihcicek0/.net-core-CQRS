using Bogus;
using CQRS_.net_core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Persistence.Configurations
{
    internal class DetailConfiguration:IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("tr");

            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                isDeleted = false,
                CategoryId = 1,
                CreatedDate = DateTime.Now
            };

            Detail detail2 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                isDeleted = false,
                CategoryId = 1,
                CreatedDate = DateTime.Now
            };
        }
    }
}
