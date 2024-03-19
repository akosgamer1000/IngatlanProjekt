using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

}
