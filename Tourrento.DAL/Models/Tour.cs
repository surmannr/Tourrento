using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models.JoinTables;
using Tourrento.Shared.Attributes;
using Tourrento.Shared.Owned;

namespace Tourrento.DAL.Models
{
    public class Tour
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A túra nevének kitöltése kötelező!")]
        [StringLength(100, ErrorMessage = "A név nem lehet több 100 karakternél.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A túra kezdeti dátumának kitöltése kötelező!")]
        [AfterNow(DaysLater = 7, ErrorMessage = "A túra kezdete és a létrehozása között minimum egy hétnek el kell telni.")]
        public DateTimeOffset StartDate { get; set; }

        [Required(ErrorMessage = "A túra befejező dátumának kitöltése kötelező!")]
        [AfterNow(DaysLater = 7, ErrorMessage = "A túra vége és a létrehozása között minimum egy hétnek el kell telni.")]
        [AfterDate(DateName = "StartDate",ErrorMessage = "A túra vége nem lehet korábban a túra kezdeténél.")]
        public DateTimeOffset EndDate { get; set; }

        [Required(ErrorMessage = "A túraútvonal kiinduló helyének kitöltése kötelező!")]
        public Location StartLocation { get; set; }
        [Required(ErrorMessage = "A túraútvonal befejező helyének kitöltése kötelező!")]
        public Location FinalLocation { get; set; }

        [StringLength(1000, ErrorMessage = "A leírás legfeljebb 1000 karakter hosszú lehet.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A maximális létszám kitöltése kötelező!")]
        [Min(0, ErrorMessage = "A maximális létszám nem lehet negítv szám.")]
        public int MaxNumberOfPeople { get; set; }

        [Required(ErrorMessage = "Az ár kitöltése kötelező!")]
        [Min(0, ErrorMessage = "Az ár nem lehet negítv szám.")]
        public int Price { get; set; }

        public string ImageName { get; set; }

        [ForeignKey(nameof(User))]
        public string CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<ParticipateTour> ParticipateTours { get; set; }
        public ICollection<RequiredCategoryTour> RequiredCategoryTours { get; set; }
        public ICollection<TourService> TourServices { get; set; }
    }
}
