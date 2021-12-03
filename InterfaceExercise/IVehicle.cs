using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle : ICompany
    {
        public int Year { get; set; }
        public int Make { get; set; }

        public int Model { get; set; }

        public int Color { get; set; }
    }


}
