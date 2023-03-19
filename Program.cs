using System;

public class HaloGeneric<T>
{
    private T _data;

    public HaloGeneric(T data)
    {
        _data = data;
    }

    public void SapaUser<U>(U user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nama = "Arya";
        HaloGeneric<string> sapa = new HaloGeneric<string>(" ");
        sapa.SapaUser(nama);  
    }
}