using System;
using Avalonia.Controls;

namespace AppWindowStyleDemo;

public class AppWindow : Window
{
    protected override Type StyleKeyOverride => typeof(AppWindow);
    
    protected AppWindow()
    {
        PseudoClasses.Set(":mac", true);
    }
}