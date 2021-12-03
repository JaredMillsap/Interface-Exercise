using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany
    {
        public int HasTrunk { get; set; }
        public int EveryDay { get; set; }
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    
}
