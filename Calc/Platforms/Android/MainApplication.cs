﻿using Android.App;
using Android.Content.Res;
using Android.Runtime;

namespace Calc
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                if (view is Entry)
                {
                    // Remove underline
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    // Change placeholder text color
                    handler.PlatformView.SetHintTextColor(ColorStateList.ValueOf(Android.Graphics.Color.Red));

                    handler.PlatformView.ShowSoftInputOnFocus = false;
                }
            });
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
