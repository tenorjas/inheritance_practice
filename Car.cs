namespace inheritance_practice
{
            public class Car
        {
            public int ModelYear {get; set;}
            public string Make {get; set;}
            public string Model {get; set;}
            public int Doors {get;set;}
            public int Miles {get; set;}

            public override string ToString()
            {
                return $"Your car is a {ModelYear} {Make} {Model}.  It has {Doors} doors, and the odometer reading is {Miles} miles.";
            }

        }

}