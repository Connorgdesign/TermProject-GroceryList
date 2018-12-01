using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.ObjectModel;

namespace GroceryList_TermProject
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : ListActivity
    {
        const string NAME = "Name";
        //GroceryItem[] items;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            // Development testing: load data into the ArrayAdapter by filling the array with Flora objects with "hard-coded" names
            string name = Intent.Extras.GetString(NAME);

            List<GroceryItem> list = new List<GroceryItem>();
            list.Add(new GroceryItem { Name = "Vegetables"  });
            list.Add(new GroceryItem { Name = "Fruits" });
            list.Add(new GroceryItem { Name = "Flower Buds" });
            list.Add(new GroceryItem { Name = "Vegetables" });
            list.Add(new GroceryItem { Name = "Vegetables" });
            list.Add(new GroceryItem { Name = "Vegetables" });
            list.Add(new GroceryItem { Name = "Vegetables" });


            GroceryItem[] items = list.ToArray();

            

            

            Toast.MakeText(this, name, ToastLength.Long).Show();



            // Load data into the ArrayAdapter by filling the array with Flora objects with names read from a file
            //items = LoadListOfVegetablesFromAssets();

            // Assign our ArrayAdapter to the ListActivity's ListAdapter property

            ListAdapter = new GroceryListAdapter(this, items);

            // Enable fast scolling
            //ListView.FastScrollEnabled = true;
        }

    }
}