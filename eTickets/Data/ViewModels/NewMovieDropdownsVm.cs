using eTickets.Controllers;
using eTickets.Models;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropdownsVm
    {
        public NewMovieDropdownsVm()
        {
            Producers = new List<Producer>();
            Actors = new List<Actor>();
            Cinemas = new List<Cinema>();
        }

        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
