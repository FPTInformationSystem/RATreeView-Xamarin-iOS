using System;
using System.Collections.Generic;
using Foundation;

namespace Demo
{
	public class DataObject : NSObject
	{

		public string Name { get; set;}
		public List<DataObject> Children { get; set;}

		public DataObject(string name, List<DataObject> children)
		{
			Name = name;
			Children = children;
		}

		public DataObject(string name)
		{
			Name = name;
			Children = new List<DataObject>();
		}

		public void AddChild(DataObject child)
		{
			this.Children.Add(child);
		}

		public void RemoveChild(DataObject child)
		{
			this.RemoveChild(child);
		}

		public static List<DataObject> DefaultTreeRootChildren()
		{
			var phone1 = new DataObject(name: "Phone1");
			var phone2 = new DataObject(name: "Phone2");
			var phone3 = new DataObject(name: "Phone3");
			var phone4 = new DataObject(name: "Phone4");
			var phones = new DataObject(name: "Phones", children: new List<DataObject>
			{
				phone1, phone2, phone3, phone4
			});

			var notebook1 = new DataObject(name: "Notebook 1");
			var notebook2 = new DataObject(name: "Notebook 2");

			var computer1 = new DataObject(name: "Computer 1", children: new List<DataObject>
			{
				notebook1, notebook2
			});
			var computer2 = new DataObject(name: "Computer 2");
			var computer3 = new DataObject(name: "Computer 3");
			var computers = new DataObject(name: "Computers", children: new List<DataObject>
			{
				computer1, computer2, computer3
			});

			var cars = new DataObject(name: "Cars");
			var bikes = new DataObject(name: "Bikes");
			var houses = new DataObject(name: "Houses");
			var flats = new DataObject(name: "Flats");
			var motorbikes = new DataObject(name: "Motorbikes");
			var drinks = new DataObject(name: "Drinks");
			var food = new DataObject(name: "Food");
			var sweets = new DataObject(name: "Sweets");
			var watches = new DataObject(name: "Watches");
			var walls = new DataObject(name: "Walls");

			return new List<DataObject>
			{
				phones, computers, cars, bikes, houses, flats, motorbikes, drinks, food, sweets, watches, walls
			};
		}
	}
}
