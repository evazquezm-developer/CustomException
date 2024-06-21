using System;

static void ValidateEmail ()
{
    string email = string.Empty;

    if ( string.IsNullOrEmpty ( email ) )
    {
        throw new MyCustomException();
    }
}

// 

try
{
    ValidateEmail();
}
catch (MyCustomException ex)
{
    Console.WriteLine("Caught exception : ");
    Console.WriteLine($"{ ex.Message }");
}