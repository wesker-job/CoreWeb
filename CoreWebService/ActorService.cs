using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebService
{
    public class ActorService : IActorService
    {
        public List<string> GetActors(string movieName)
        {
            List<string> actors = new List<string>();
            return actors;
        }

        public List<string> GetMovies(int actorId)
        {
            List<string> movies = new List<string>();
            return movies;
        }

        public string GetActorData(int actorId)
        {
            return string.Empty;
        }
    }
}
