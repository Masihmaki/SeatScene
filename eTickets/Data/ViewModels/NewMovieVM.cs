using eTickets.Data.Base;
using eTickets.Data.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is requierd")]
        public string Name { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Description is requierd")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is requierd")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster is requierd")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is requierd")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is requierd")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is requierd")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is requierd")]
        public List<int> ActorIds { get; set; }

        //Cinema
        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is requierd")]
        public int CinemaId { get; set; }

        //Producer
        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is requierd")]
        public int ProducerId { get; set; }
    }
}
