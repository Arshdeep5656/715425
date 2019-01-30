using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715425
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside blue = new Countryside();
            blue.Launch();
        }
    }
}
    class village
    {
    // Node is an ADT
    // What kind of data do we need in a NODE?
    public village nextvillage;
    public village Previousvillage;
    public string villageName;
    public bool isAstrlieHere = false;
    }
    class Countryside
    {
    village Maple = new village();    
    village Toronto = new village();    
    village Ajax = new village();
    village First;
    village Last;
    village temp;

    public void Launch()
    {
        
        village First = Maple;
        village Last = Ajax;
        Maple.villageName = "Maple";
        Maple.nextvillage = Toronto;
        Maple.Previousvillage = null;
        Toronto.villageName = "Toronto";
        Toronto.nextvillage = Ajax;
        Toronto.Previousvillage = Maple;
        Ajax.villageName = "Ajax";
        Ajax.nextvillage = null;
        Ajax.nextvillage = Toronto;

        Console.WriteLine(this.displayMap());

    }

    public string displayMap()
    {
        string listofCities = "";
        while (true)
        {
            listofCities = listofCities + First.villageName + "-----";
            temp = First.nextvillage;
            listofCities = listofCities + temp.villageName + "------";

            return listofCities;
        }
        
    }
}
