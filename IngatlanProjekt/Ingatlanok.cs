using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;

public class Ingatlanok
{
    private List<Ingatlan> ingatlanLista;

    public Ingatlanok()
    {
        Beolvasas();
    }

    private void Beolvasas()
    {
        ingatlanLista = new List<Ingatlan>();
        try
        {
            using (StreamReader sr = new StreamReader("realestatetransactions.csv"))
            {
                sr.ReadLine(); // Első sor kihagyása (fejléc)
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    ingatlanLista.Add(new Ingatlan(sor));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public int eladásokszáma()
    {
        return ingatlanLista.Count;
    }
    public int legnagyobb()
    {
         return ingatlanLista.Max(ing => ing.Terulet);
        
    }
    public Ingatlan s()
    {
       var k= ingatlanLista.Where(ing=>ing.Terulet==legnagyobb()).ToList().FirstOrDefault();
        return k;

    }
    public int össz()
    {
         return ingatlanLista.Sum(ing => ing.Ar);
    }

}
