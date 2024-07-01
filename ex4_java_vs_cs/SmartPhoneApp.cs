using System;

abstract class CellPhone{
    public abstract void makeCalls();
    public abstract void makeSMS();
}

interface IInternetOptions{
    public void browseInternet();
    
}

interface ISocialMedia{
    public void whatsApp();
    public void FaceBook();
}

abstract class SmartPhone : CellPhone,IInternetOptions,ISocialMedia{
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}