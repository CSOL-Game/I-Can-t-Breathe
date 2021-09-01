namespace ViewModels

open Avalonia

type MainWindowViewModel() =
    inherit ViewModelBase()

    member this.GetSize(appSize : Rect) = 
        let height = appSize.Height/16.0*18.0/10.0
        let weight = appSize.Width*0.9
        new Rect(0.0,0.0,weight,height)
    member __.Greeting = "Hello World!"
        
        
