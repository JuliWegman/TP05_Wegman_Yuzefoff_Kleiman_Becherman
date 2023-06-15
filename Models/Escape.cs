class Escape{

public static string[] incognitasSalas{ get;}=new string[5];
public static int estadoJuego{get;set;}=0;

public static void InicializarJuego(){
incognitasSalas[0]="0112358";
incognitasSalas[1]="x..x.";
incognitasSalas[2]="yani";
incognitasSalas[3]="ha4c4";
incognitasSalas[4]="1904";
estadoJuego=0;
}
public static bool ResolverSala(string Incognita)
{
    return (Incognita==incognitasSalas[estadoJuego]);
}

}