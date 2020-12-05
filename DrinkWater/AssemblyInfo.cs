using Android.App;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly: ExportFont("CabinSketchBold.ttf", Alias = "CabinSketch")]
[assembly: UsesPermission(Android.Manifest.Permission.Vibrate)]