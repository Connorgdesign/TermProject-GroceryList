using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace GroceryList_TermProject
{
    [Activity(Label = "GroceryList_TermProject", MainLauncher = true)]
    public class MainActivity : Activity
    {
        const string NAME = "Name";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText itemName = FindViewById<EditText>(Resource.Id.groceryItemEdit);

            Button viewButton = FindViewById<Button>(Resource.Id.viewButton);

            viewButton.Click += delegate {
                var back = new Intent(this, typeof(SecondActivity));

                //get the date in a string format that matches the database
                back.PutExtra(NAME, itemName.Text);
                StartActivity(back);
            };

        }

        

    }
}

