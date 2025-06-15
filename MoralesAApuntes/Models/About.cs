using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesAApuntes.Models;
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Name => "Anthony Moales";
        public string Description => "Estudiante de Ingeniería de Software";
        public string Hobbies => "Mis hobbies incluyen jugar videojuegos, escuchar musica, jugar futbol";
    }

