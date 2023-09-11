using Android.App;
using Android.Content;
using Android.Content.PM;

namespace BottomSheetTest;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Intent.ActionView },
    Categories = new[]
    {
        Intent.ActionView,
        Intent.CategoryDefault,
        Intent.CategoryBrowsable
    },
    AutoVerify = true, DataScheme = "https", DataHost = "bottom-sheet", DataPathPrefix = "/test"
)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnResume()
    {
        base.OnResume();

        Platform.OnResume(this);
    }

    protected override void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);

        Platform.OnNewIntent(intent);
    }
}

