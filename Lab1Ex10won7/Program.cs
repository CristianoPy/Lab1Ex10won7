/*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
tastatura.*/

int sum = 0;
int mod;    

Console.WriteLine("Introduce un numar: ");
int num = Convert.ToInt32(Console.ReadLine());



while (num > 0)
{
    mod = num % 10;
    sum += mod;
    num /= 10;
}

Console.WriteLine("Suma este: " +  sum);

Console.ReadLine();
