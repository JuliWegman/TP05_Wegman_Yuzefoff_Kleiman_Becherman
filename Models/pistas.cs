class Pistas{

    public static int cant{get;set;}=3;
    public static int num{get;set;}=0;
    public static string[,] pistasardas{get;set;} = new string[5, 3]{{"Cuantas ganas tengo de hacer una sopa de letras...","Las palabras de la sopa de letras estas ordenadas en un orden específico?","Las primera letra de cada palabra de la sopa de letras forma la respuesta"},{"Quien es ET?","hoy vino ET?","cuales son las faltas de ET?"},{"que significan esas lineas y puntos de destello?","la primer letra es y","es YANI -_-"},{"Hay luces titilando en la bomba","Cada luz que titila en la bomba corresponde a una letra","hay que poner las letras de las luces que titilan en orden"},{"Que extraño, hay números escritos con sangre por todos lados","De qué forma hay que ordenarlos?","hay que ordenarlos en la forma que los fuimos viendo"}};

    public void siguiente()
    {
        num=0;
    }
    
    public static string PedirPista(int estadojuego)
    {
        string frase;
     if (num<3)
     {
        frase=pistasardas[estadojuego,num];
        num++;
     }else{
        frase="¡NO TE QUEDAN MÁS PISTAS!";
     }
     
     
     return frase; 
    }
}