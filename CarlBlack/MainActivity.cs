using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Runtime;
using Android.Widget;

namespace CarlBlack
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button buttonNext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout_2);

            buttonNext = FindViewById<Button>(Resource.Id.btnNext);                    

            this.FindViewById<Button>(Resource.Id.btnNext).Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Intent actMain = new Intent(this, typeof(Alvina));
            StartActivity(actMain);
        }
    }
}