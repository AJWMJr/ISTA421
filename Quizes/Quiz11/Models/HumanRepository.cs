using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz11.Models
{
    public class HumanRepository
    {
        public IQueryable<Human> HumansGet {  get { return Humans; } }
        private IQueryable<Human> Humans => new List<Human>
        {
            new Human
            {
                Name = "AJ",
                Age = 28,
                Height = 69,
                Weight = 200,
                FavColor = "Purple"
            },
            new Human
            {
                Name = "Nick",
                Age = 25,
                Height = 72,
                Weight = 180,
                FavColor = "Red"
            },
            new Human
            {
                Name = "Tiffany",
                Age = 21,
                Height = 67,
                Weight = 130,
                FavColor = "Pink"
            },
            new Human
            {
                Name = "Mary",
                Age = 48,
                Height = 66,
                Weight = 160,
                FavColor = "Blue"
            }
        }.AsQueryable<Human>();
    }
}
