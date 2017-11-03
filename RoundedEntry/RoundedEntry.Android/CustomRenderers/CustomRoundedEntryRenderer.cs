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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using RoundedEntry.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(RoundedEntry.CustomRenderers.RoundedEntry),
typeof(CustomRoundedEntryRenderer))]
namespace RoundedEntry.Droid.CustomRenderers
{
    public class CustomRoundedEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control!=null)
            {
                Control.Background = this.Resources.GetDrawable(Resource.Drawable.RoundedEntry);
            }
        }
    }
}