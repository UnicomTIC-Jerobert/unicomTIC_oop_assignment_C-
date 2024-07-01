abstract class CellPhone{
    abstract void makeCalls();
    abstract void makeSMS();
}

interface InternetOptions{
    public void browseInternet();
    
}

interface SocialMedia{
    public void whatsApp();
    public void FaceBook();
}

abstract class SmartPhone extends CellPhone implements InternetOptions,SocialMedia {
    
      void makeCalls(){
              System.out.println("Make Calls...");
      }
   
        void makeSMS(){
              System.out.println("Make SMS...");
      }
    
    
    public void browseInternet(){
        System.out.println("Browsing Internet ...");
    }
    
    public void whatsApp(){
        System.out.println("Using whats App ...");
    }
    public void FaceBook(){
        System.out.println("Using FaceBook ...");
    }
}

class Samsung extends SmartPhone{
    
}

public class SmartPhoneApp {
    public static void main(String[] args) {
       Samsung smPhone=new Samsung();
       smPhone.makeCalls();
    }
}