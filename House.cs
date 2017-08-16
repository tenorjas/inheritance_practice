namespace inheritance_practice
    {
        public class House
        {
            public int NumFloors {get; set;}
            public int NumRooms {get; set;}
            public int YearBuilt {get; set;}

            public override string ToString()
            {
                return $"House has {NumFloors} floors and {NumRooms} rooms, and was built in {YearBuilt}.";
            }
        }
    }
