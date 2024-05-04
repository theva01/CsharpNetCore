class Program
{
    private String cadena; 
    private String verMayusculas = "";
    private String verMinusculas = "";
    private int n;
    private string[] Mayusculas;
    private string[] Minusculas;
    private string[] tempMy;
    private string[] tempMn;

    public Program(String cadena)
    {
        this.cadena = cadena; 
        n = cadena.Length;
        Mayusculas = new string[n];
        Minusculas = new string[n];
        tempMy = new string[n];
        tempMn = new string[n]; 
    }
    

    public String mayusculas()
    {
        for (int i = 0; i < n; i++) 
        {
            if (Char.IsUpper(cadena[i]))
            {
                tempMy[i] = Convert.ToString(cadena[i]);
            }
        }
        for (int i = 0;i < tempMy.Length; i++)
        {
            if (tempMy[i]  != null)
            {
                Mayusculas[i] = tempMy[i];
                verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
            }
        }
        return verMayusculas;
    }

    public String minusculas()
    {
        for (int i = 0; i < n; i++)
        {
            if (Char.IsLower(cadena[i]))
            {
                tempMn[i] = Convert.ToString(cadena[i]);
            }
        }
        for (int i = 0; i < tempMn.Length; i++)
        {
            if (tempMn[i] != null)
            {
                Minusculas[i] = tempMn[i];
                verMinusculas = $"{verMinusculas},{Minusculas[i]}";
            }
        }
        return verMinusculas;
    }

    static void Main() 
    {
        var cadenaRead = Console.ReadLine();
        var data = new Program(cadenaRead);
        Console.WriteLine($"Mayusculas:{data.mayusculas()} \n Minusculas: {data.minusculas()}");
        Console.ReadLine();
    }


    

}
