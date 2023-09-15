using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        // creating player property
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        // constructor
        public GameSession()
        {
            // when a game session object is created a new player is also created due to this constructor 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Player1";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";
        }
    }
}
