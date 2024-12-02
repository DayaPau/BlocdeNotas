using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocdeNotas.Models
{
    internal class About
    {
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";
        public string Title { get; set; } = "Dayana Vallejos";
        public string Description { get; set; } = "Hola, me gustan los gatos y lo filosofía de vida es CarpeDiem";
        public string ImagePath { get; set; } = "your_image.jpg"; 
    }
}
