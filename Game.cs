using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekGameStore.Domain.Abstract;
using GeekGameStore.Domain.Concrete;

namespace GeekGameStore.Domain.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
