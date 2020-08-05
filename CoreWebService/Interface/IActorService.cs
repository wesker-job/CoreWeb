using System.Collections.Generic;

namespace CoreWebService
{
    public interface IActorService
    {
        string GetActorData(int actorId);
        List<string> GetActors(string movieName);
        List<string> GetMovies(int actorId);
    }
}