internal class Program
{
    private static void Main(string[] args)
    {
        // Codifica un programa que demani 6 números a l’usuari i després els imprimeixi de
        // manera inversa.
        
        int[] numList = new int[6];
        int numUser;

        for (int i = 0; i < numList.Length; i++)
        {   
            System.Console.Write("Escribe un numero: ");
            numUser = Convert.ToInt32(Console.ReadLine());
            numList[i] = numUser;
        }

        System.Console.WriteLine("");

        for (int i = numList.Length - 1; i >= 0; i--)
        {
            System.Console.WriteLine(numList[i]);
        }

        // Codifica un programa que prepari espai per desar un màxim de 100 noms. L'usuari
        // haurà d'anar introduint un nom cada cop, fins que es teclegi stop, moment en què
        // deixaran de demanar-se més noms i es mostrarà a la pantalla la llista dels noms que
        // s'han introduït.

        string[] nameList = new string[100];
        string nameUser = "";
        int nameCount = 0;

        while (nameUser != "stop" && nameCount < 100)
        {
            System.Console.WriteLine("Escribe nombre (para salir escribe 'stop'):");
            nameUser = Console.ReadLine();
            nameList[nameCount] = nameUser;
            nameCount += 1;
        }

        System.Console.WriteLine("");

        for (int i = 0; i < nameCount - 1; i++)
        {
            System.Console.WriteLine(nameList[i]);
        }

        // Codifica un programa que emmagatzemi en una taula el nombre de dies que té cada
        // mes, demaneu a l'usuari que us indiqui un mes (1=gener, 12=desembre) i mostri a la
        // pantalla el nombre de dies que té aquest mes.

        int[] monthList = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int monthUser;

        System.Console.Write("Indica un mes (1=gener, 12=desembre): ");
        monthUser = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine($"Dias del mes indicado: {monthList[monthUser]}");

        // Codifica un programa que permita al usuario ingresar 7 valores decimales y luego
        // muestre esos valores ordenados de mayor a menor.

        float[] floatList = new float [7];

        for (int i = 0; i < floatList.Length; i++)
        {
            System.Console.Write("Escribe numero decimal: ");
            floatList[i] = float.Parse(Console.ReadLine());
        }

        Array.Sort(floatList);
        Array.Reverse(floatList);

        for (int i = 0; i < floatList.Length; i++)
        {
            System.Console.WriteLine(floatList[i]);
        }

        // Codifica un programa que solicite al usuario el ingreso de 10 números y determine
        // cuántos de ellos son pares.

        int pairNums = 0;
        int userNum;

        for (int i = 0; i < 10; i++)
        {
            System.Console.Write("Escribe numero: ");
            userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum % 2 == 0)
            {
                pairNums += 1;
            }
        }

        Console.WriteLine($"{pairNums} numeros son pares");
        
    }
}