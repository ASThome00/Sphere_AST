using System;

namespace Sphere_AST
{
	/*
	 * This class models a sphere.
	 * This class is a translated version of Sphere.java writen by Dr. Rob Kelley
	 * @version 2.0
	 * @author Andrew Tanner
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Sphere s = new Sphere(4.0);
			Console.WriteLine("Volume: " + s.getVolume() + ", Surface Area: " + s.getSurfaceArea());
			Console.WriteLine(s.toString());
			System.Threading.Thread.Sleep(10000);
		}//end main
	}

    class Sphere
    {
		private double diameter;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Sphere()
		{
			diameter = 2.0;
		}//end constructor

		/**
		 * Constructor accepts value of diameter.
		 * Preferred constructor.
		 * @param diameter
		 */
		public Sphere(double diameter)
		{

			this.setDiameter(diameter);

		}//end constructor

		/**
		 * Calculates the volume of the sphere.
		 * @return volume
		 */
		public double getVolume()
		{

			return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

		}//end getVolume

		/**
		 * Calculates the surface area of the sphere.
		 * @return - surface area
		 */
		public double getSurfaceArea()
		{

			return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
		}//end getSurfaceArea


		/**
		 * Getter for diameter
		 * @return
		 */
		public double getDiameter()
		{
			return diameter;
		}//end getDiameter

		/**
		 * Setter for diameter. Checks bound on
		 * formal parameter and resets to 2 if
		 * the value is less than 2.
		 * @param diameter
		 */
		public void setDiameter(double diameter)
		{
			if (diameter < 2)
				this.diameter = 2;
			else
				this.diameter = diameter;
		}//end setDiameter
		
		public String toString()
		{
			return "Sphere [diameter=" + diameter + "]";
		}//end toString
	}//end class
}
