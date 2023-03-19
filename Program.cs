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

public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nama = "Arya";
        HaloGeneric<string> sapa = new HaloGeneric<string>(nama);
        sapa.SapaUser(nama);

        string nim = "1302213069";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }

}