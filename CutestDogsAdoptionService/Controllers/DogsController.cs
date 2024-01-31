using CutestDogsAdoptionService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CutestDogsAdoptionService.Controllers
{
 
    public class DogsController : Controller
    {

        //detta är en privat fältvariabel
        private List<DogModel> dogs = new List<DogModel>
{
    new DogModel{ Id = 1, Name = "Bark Twain", Cuteness = 9, Image = "doggo 1.png", FavFood = "Barkoni", FavToy = "Barkle", Temperament = 7, IsAdopted= false },
    new DogModel{ Id = 2, Name = "Sir Waggington", Cuteness = 8, Image = "doggo 2.png", FavFood = "Pawsta", FavToy = "Fetch Stick", Temperament = 6, IsAdopted= false },
    new DogModel{ Id = 3, Name = "Furball", Cuteness = 6, Image = "doggo 3.png", FavFood = "Bone Appetit", FavToy = "Squeaky Ball", Temperament = 8, IsAdopted= false },
    new DogModel{ Id = 4, Name = "Princess Paws", Cuteness = 10, Image = "doggo 4.png", FavFood = "Royal Canin", FavToy = "Diamond Collar", Temperament = 5, IsAdopted= false },
    new DogModel{ Id = 5, Name = "Biscuit", Cuteness = 7, Image = "doggo 5.png", FavFood = "Pupcakes", FavToy = "Chewy Bone", Temperament = 9, IsAdopted= false },
    new DogModel{ Id = 6, Name = "Daisy", Cuteness = 4, Image = "doggo 6.png", FavFood = "Doggie Delight", FavToy = "Plush Squirrel", Temperament = 3, IsAdopted= false },
    new DogModel{ Id = 7, Name = "Captain Woof", Cuteness = 6, Image = "doggo 7.png", FavFood = "Fish 'n Chips", FavToy = "Nautical Rope", Temperament = 8, IsAdopted= false },
    new DogModel{ Id = 8, Name = "Snuggle Paws", Cuteness = 9, Image = "doggo 8.png", FavFood = "Cuddle Crunchies", FavToy = "Soft Blanket", Temperament = 7, IsAdopted= false },
    new DogModel{ Id = 9, Name = "Rocky", Cuteness = 3, Image = "doggo 9.png", FavFood = "Steak Bites", FavToy = "Tennis Ball", Temperament = 4, IsAdopted= false },
    new DogModel{ Id = 10, Name = "Lola", Cuteness = 5, Image = "doggo 10.png", FavFood = "Treat Tower", FavToy = "Squeaky Duck", Temperament = 6, IsAdopted= false },
    new DogModel{ Id = 11, Name = "Maximus", Cuteness = 8, Image = "doggo 11.png", FavFood = "Beefy Bites", FavToy = "Tug Rope", Temperament = 9, IsAdopted= false },
    new DogModel{ Id = 12, Name = "Roxy", Cuteness = 7, Image = "doggo 12.png", FavFood = "Chicken Chewies", FavToy = "Frisbee", Temperament = 4, IsAdopted = false },
    new DogModel{ Id = 13, Name = "Teddy", Cuteness = 2, Image = "doggo 13.png", FavFood = "Carrot Crunch", FavToy = "Plush Bunny", Temperament = 2, IsAdopted = false },
    new DogModel{ Id = 14, Name = "Coco", Cuteness = 6, Image = "doggo 14.png", FavFood = "Coconut Chew", FavToy = "Ball Launcher", Temperament = 8, IsAdopted= false }
};
        public IActionResult Index()
        {
            List<DogModel> sortedDogs = dogs.OrderBy(d => d.Name).ToList();
            //visa en view med alla dogs 
            return View(sortedDogs);
        }

        public IActionResult Details(int id) // id skickas med asp-routé id
        {

            //hämta hunden med id:t
            DogModel? selectedDog = dogs.FirstOrDefault(d => d.Id == id);
            //Skicka den hunden till View:en
            return View(selectedDog);
        }

        public IActionResult Adopt (int id)
        {

            //hämta hunden med id:t
            DogModel? selectedDog = dogs.FirstOrDefault(d => d.Id == id);
            
            if (selectedDog != null)
            {
                selectedDog.IsAdopted = true;

            }

            //Skicka den hunden till View:en
            return View(selectedDog);

        }


    }
}
