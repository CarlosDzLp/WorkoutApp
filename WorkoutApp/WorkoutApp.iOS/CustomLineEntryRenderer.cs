using System;
using System.ComponentModel;
using CoreAnimation;
using UIKit;
using WorkoutApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(Entry),typeof(CustomLineEntryRenderer))]
namespace WorkoutApp.iOS
{
    public class CustomLineEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null)
                return;
            Control.Layer.CornerRadius = 0;
            Control.BorderStyle = UIKit.UITextBorderStyle.None;
            Control.Layer.BorderWidth = 0;
            Control.ClipsToBounds = false;
        }
    }
}
