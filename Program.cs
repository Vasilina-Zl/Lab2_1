using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
	static void Main(string[] args)
	{
		Labor2_1.Address first = new Labor2_1.Address();

		first.Index = 03217;
		first.Country ="Ukraine";
		first.City ="Kyiv";
		first.Street ="Polova street";
		first.House = 45;
		first.Apartment = 3;

		Console.WriteLine($"Index: {first.Index} | Country: {first.Country} |" +
			$" City: {first.City} | Street: {first.Street} | House: {first.House} | Apartment: {first.Apartment}");

	}
}