using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models;

namespace Tourrento.DAL.EntityConfigurations
{
    public class PostEntityConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post()
                {
                    Id = 1,
                    Question = "Hány megálló lesz, ahol pihenni lehet?",
                    QuestionerId = "seedtwo",
                    Answer = null,
                    TourId = 1
                },
                 new Post()
                 {
                     Id = 2,
                     Question = "Az étkezés benne van az árban?",
                     QuestionerId = "seedthree",
                     Answer = "Nem, az ételről mindenki maga gondoskodik, de megfogunk állni a boltoknál ha szükséges.",
                     TourId = 2
                 },
                 new Post()
                 {
                     Id = 3,
                     Question = "Hány megálló lesz, ahol pihenni lehet?",
                     QuestionerId = "seedtwo",
                     Answer = null,
                     TourId = 3
                 },
                 new Post()
                 {
                     Id = 4,
                     Question = "Az étkezés benne van az árban?",
                     QuestionerId = "seedthree",
                     Answer = "Nem, az ételről mindenki maga gondoskodik, de megfogunk állni a boltoknál ha szükséges.",
                     TourId = 4
                 },
                  new Post()
                  {
                      Id = 5,
                      Question = "Fogunk megállni bolt közelébe?",
                      QuestionerId = "seedthree",
                      Answer = "Igen, így aki szeretne az vásárolhat magának frissítőket vagy ennivalót.",
                      TourId = 1
                  },
                 new Post()
                 {
                     Id = 6,
                     Question = "Gyerekek is résztvehetnek az eseményen? A fiam szívesen jönne",
                     QuestionerId = "seedtwo",
                     Answer = null,
                     TourId = 2
                 },
                 new Post()
                 {
                     Id = 7,
                     Question = "Fogunk megállni bolt közelébe?",
                     QuestionerId = "seedthree",
                     Answer = "Igen, így aki szeretne az vásárolhat magának frissítőket vagy ennivalót.",
                     TourId = 3
                 },
                 new Post()
                 {
                     Id = 8,
                     Question = "Gyerekek is résztvehetnek az eseményen? A fiam szívesen jönne",
                     QuestionerId = "seedtwo",
                     Answer = null,
                     TourId = 4
                 }
            );
        }
    }
}
