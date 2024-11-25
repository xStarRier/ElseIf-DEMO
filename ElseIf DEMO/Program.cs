// See https://aka.ms/new-console-template for more information

namespace IfElsetest
{

internal class ifElse
{
    int number1 = 5;
    int number2 = 1;
    bool isEqual = false;

    public void Run()
    { 
        if(number1 == number2 )
        {
            isEqual = true;
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            isEqual = false;
            Console.WriteLine("The numbers are not equal");
        }

        if (isEqual)
        {
            number1++;
        }
        else
        {
            number2--;
        }


    }



}

}