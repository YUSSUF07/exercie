using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        deviner(23,1,100);
        
    }

    public static void deviner(int x, int inf, int sup) 
    {
        /*
                do
                {
                  int milieu = (inf + sup)/2;
                    Console.Write("Est ce que le nombre est superieur a" +milieu );
                    if(milieu == x)
                        {
                        Console.WriteLine("le chiffre a deviner est " + x);

                        }
                    else if (x >milieu)
                    {
                        Console.WriteLine("OUI");
                        inf= milieu + 1;
                    }
                    else
                    {
                        Console.WriteLine("NON");
                        sup = milieu - 1;

                    }
                } 
                while (inf!=sup);
        */

        int milieu = (inf + sup) / 2; ;
       do
        {
            milieu = (inf + sup) / 2;
            Console.Write("Est ce que le nombre est superieur a " + milieu);
            if (milieu < x){
                Console.WriteLine(" OUI");
                inf = milieu + 1;
            }
            else
            {
                Console.WriteLine(" NON");
                sup = milieu ;
            }
            

        }
        while (milieu != x && inf < sup);
        if (milieu == x)
        {
            Console.WriteLine("le chiffre a deviner est " + x);

        }
        else
        {
            Console.WriteLine("le chiffre a deviner n existe pas ");

        }

    }
}