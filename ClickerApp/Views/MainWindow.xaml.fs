namespace Views

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml
open Avalonia.Interactivity

type MainWindow () as self = 
    inherit Window ()
    #if DEBUG
    do self.AttachDevTools()
    #endif
    do AvaloniaXamlLoader.Load self
    member this.ExitApp(sender: obj , e: RoutedEventArgs) =
        this.Close()