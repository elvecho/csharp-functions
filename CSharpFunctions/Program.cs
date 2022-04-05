// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arraydinumeri = { 2, 6, 7, 5, 3, 9 };
stampaarrayinteri(arraydinumeri);

void stampaarrayinteri(int[] array)
{
    {
        int ultimoindice = array.Length -1;
        Console.Write("[");

        for (int i = 0; i < array.Length ; i++)
        {
            if (ultimoindice == i)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
        
        Console.WriteLine("]");
    }
}

int quadrato( int addendo)
{
    int quadrato = addendo * addendo;
    return quadrato;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayNuovo = (int[])array.Clone();
    for (int i = 0; i < arrayNuovo.Length; i++)
    {
        arrayNuovo[i] = quadrato((int)arrayNuovo[i]);
    }
    return arrayNuovo;
}

int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}


stampaarrayinteri(arraydinumeri);

int[] arraynuovo = ElevaArrayAlQuadrato(arraydinumeri);

stampaarrayinteri(arraynuovo);

int somma = SommaElementiArray(arraydinumeri);
Console.WriteLine(somma);

int sommanumerialquadrato = SommaElementiArray(arraynuovo);
Console.WriteLine(sommanumerialquadrato);