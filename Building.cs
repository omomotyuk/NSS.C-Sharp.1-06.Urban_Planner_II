using System;

namespace _1_06.Urban_Planner_II
{
    class Building
    {
        private string _designer; // It will hold your name.
        private DateTime _dateConstructed; // This will hold the exact time the building was created.
        private string _address;
        private string _owner; // This will store the same of the person who owns the building.

        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume
         {
            get
            {
                return Convert.ToInt32( Width * Depth * 3 * Stories );
            }
         } // should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.

        public Building( string address )
        {
            _designer = "Alex";
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase( string person )
        {
            _owner = person;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_address}");
            for( int i = 0; i < _address.Length; i++ )
            {
                Console.Write("-");
            }
            Console.Write(
                $"\nDesigned by {_designer}\n" +
                $"Constructed on {_dateConstructed}\n" +
                $"Owned by {_owner}\n" +
                $"{Volume} cubic meters of space\n\n"
                );
        }
    }
}
