using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace W
{
	internal class Box //Class Box= Any object that has mass
	{
        //Properties. Object characteristics
        protected double GRAVITY = 9.81;
		protected double mass; // It is a field, saves the data as a variable

        //Propierty
        public double Mass 
        {
			get { return mass; } //You can make a property read-only or write-only by making it private.
            set { mass = value; }
		}

		//Constructor. To initialize the variables in a class
		public Box()
		{
			mass = 0;
		}

		//Method
		public double CalculateWeight()
		{
			return mass*GRAVITY;
		}

	}
}
