using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Chosen_Artefact.Models;
using Android.Content;
using Android.Support.V7.Widget;

namespace Chosen_Artefact
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Repository repository = Repository.GetInstance();
        ListView listview;
        EditText edit;
        Switch switcher;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);                  // Set our view from the "main" layout resource

            Button search = FindViewById<Button>(Resource.Id.searchButton);

            Button random = FindViewById<Button>(Resource.Id.randomButton);

            Button create = FindViewById<Button>(Resource.Id.createButton); // Make connection to button
            create.Click += delegate{                                       // Make desired effect when clicked
                Intent intent = new Intent(this, typeof(CreateActivity));
                StartActivity(intent);
            };

            listview = FindViewById<ListView>(Resource.Id.listView1);
            listview.Adapter = new ArtefactAdapter(this, repository.Artefacts);

            edit.FindViewById<EditText>(Resource.Id.nameEdit);
            edit.FindViewById<EditText>(Resource.Id.typeEdit);
            edit.FindViewById<EditText>(Resource.Id.elementEdit);
            switcher.FindViewById<Switch>(Resource.Id.setpieceSwitch);
        }

    }
}