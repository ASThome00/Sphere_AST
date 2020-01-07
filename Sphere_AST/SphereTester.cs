using System;
using System.Collections.Generic;
using System.Text;

namespace Sphere_AST
{
    class SphereTester
    {
		static void Main(string[] args)
		{
			Sphere s = new Sphere(4.0);
			Console.WriteLine("Volume: " + s.getVolume() + ", Surface Area: " + s.getSurfaceArea());
			Console.WriteLine(s.toString());
			System.Threading.Thread.Sleep(10000);
		}//end main
	}
}
