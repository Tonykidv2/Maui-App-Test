using MauiApp1.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Shared.Services
{
    public interface IMonkeyService
    {
        public Task<List<Monkey>> GetMonkeys();
    }
}
