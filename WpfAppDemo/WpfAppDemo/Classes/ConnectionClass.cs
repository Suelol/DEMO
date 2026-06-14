using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Models;

namespace WpfAppDemo.Classes
{
    public static class ConnectionClass
    {
        public static PogRamilPsEntities connect = new PogRamilPsEntities();
    }
}
