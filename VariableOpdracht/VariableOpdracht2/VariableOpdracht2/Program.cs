using System;
using System.Reflection.Metadata.Ecma335;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?
          
            twitchStream.name = "je favoriete streamer";
            twitchStream.laststreamName = "waarde: de streamname van de laatste keer";
            twitchStream.streamGame = new Game("naam van de game hier");
            twitchStream.followersl = 10;
            twitchStream.automod = true;

            Console.WriteLine("Hello, World!");
        }
    }
}