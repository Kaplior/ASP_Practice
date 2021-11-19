using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Services
{
    public class TimeService
    {
        public string GetTime() => System.DateTime.Now.ToString("hh:mm:ss");
    }
}
