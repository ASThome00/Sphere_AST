using System;

namespace Sphere_AST
{
	/// <summary>
	/// This class models a sphere. This class is a translated version of Sphere.java writen by Dr. Rob Kelley
	/// </summary>
    class Sphere
    {
		private double diameter;

		/// <summary>
		/// Empty argument constructor
		/// </summary>
		public Sphere()
		{
			diameter = 2.0;
		}//end constructor

		/// <summary>
		/// Preferred constructor for sphere
		/// </summary>
		/// <param name="diameter">the diameter of the sphere</param>
		public Sphere(double diameter)
		{

			this.setDiameter(diameter);

		}//end constructor

		/// <summary>
		/// Calculates the volume of a sphere
		/// </summary>
		/// <returns>volume of the sphere</returns>
		public double getVolume()
		{

			return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

		}//end getVolume

		/// <summary>
		/// calculates the Surface area of the sphere
		/// </summary>
		/// <returns>surface area of the sphere</returns>
		public double getSurfaceArea()
		{

			return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
		}//end getSurfaceArea


		/// <summary>
		/// getter for diameter
		/// </summary>
		/// <returns>diameter</returns>
		public double getDiameter()
		{
			return diameter;
		}//end getDiameter

		/// <summary>
		/// Setter for diameter. Resets the diameter to 2 if the passed value is less than 2
		/// </summary>
		/// <param name="diameter">diameter of the sphere</param>
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
