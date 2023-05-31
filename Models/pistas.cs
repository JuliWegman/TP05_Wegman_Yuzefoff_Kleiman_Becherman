class Pistas{

    static int cant{get;set;}=3;
    static int num{get;set;}=0;
    static string[,] pistas{get;set;} = new string[5, 3]{{"","",""},{"","",""},{"","",""},{"","",""},{"","",""}};

    public void siguiente()
    {
        num=0;
    }
    
    public string PedirPista(int estadojuego)
    {
     string frase=pistas[estadojuego,num];
     num++;
     return frase; 
    }
}