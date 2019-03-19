using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekGameStore.Domain.Entities;

namespace GeekGameStore.Domain.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
