using System;

namespace inheritance_practice
{
    class Program
    {

        static void Main(string[] args)
        {
            var house = new TwoStory();
            house.NumFloors = 2;
            house.NumRooms = 5;
            house.YearBuilt = 1987;
            house.hasGarage = true;
            Console.WriteLine(house);
            if (house.hasGarage)
            {
               Console.WriteLine("The house has a garage."); 
            }
            else
            {
                Console.WriteLine("The house does not have a garage.");
            }


            var car = new Sedan();
            car.ModelYear = 2015;
            car.Make = "Toyota";
            car.Model = "Corolla";
            car.Doors = 4;
            car.Miles = 23333;
            car.hasTrunk = true;
            Console.WriteLine(car);
            if (car.hasTrunk)
            {
                Console.WriteLine("The car has a trunk.");
            }
            else
            {
                Console.WriteLine("The car does not have a trunk.");
            }

            var hobbies = new Hobbies();
            hobbies.Hobby1 = "Photography";
            hobbies.Hobby2 = "Wildlife watching";
            hobbies.Hobby3 = "Planespotting";
            hobbies.Hobby4 = "Singing";
            hobbies.Hobby5 = "World travel";
            Console.WriteLine($"My hobbies are: {hobbies.Hobby1}, {hobbies.Hobby2}, {hobbies.Hobby3}, {hobbies.Hobby4} and {hobbies.Hobby5}.");
        }
    }
}
