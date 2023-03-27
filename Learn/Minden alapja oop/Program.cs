/*
 * A C# egy úgynevezett OOP (Object Oriented Program) nyelv (nem igazán).
 * Az objektumok különféle könyvtárak (class) vagy adattípúsok is lehetnek.
 * Azaz a következő kód sor is lehet objektum.
 * 
 */

using System;

class Autok // Az objektum megnevezése
{
    string marka { get; set; }
    string tipus { get; set; }               // Ez a terület az objektum belső paraméterei
    DateTime gyartasiEv { get; set; }

    Autok(string Marka, string Tipus, DateTime GyartasiEv) // Az objektum felépítése és az ahhoz járuló paraméterek
    {
        this.marka = Marka;
        this.tipus = Tipus;                   // Beállítjuk az objektum paramétereihez tartozó adatokat (a this jelző elhagyható!)
        this.gyartasiEv = GyartasiEv;
    }

    void BeallitMarka(string ujMarka)          // Az objektumba beépített belső metódusok létrehozása
    {
        // Itt már elhagytam a this jelzőt a példa kedvéért
        marka = ujMarka;
    }
}


/*
 * A C#-ban létre lehet hozni publikus és privát "tagokat" (property/member).
 * Ezek arra valók, hogyha az objektumon keresztül szeretnél előhívni egy beépített metódust akkor a privát tagokat nem tudod előhívni,
 * de a publikust igen!
 * 
 * Minden új metódus privát, ha publikus tagot akarsz létre hozni akkor meg kell neki adni a public property-t! 
 * (public void SetBrand(string newBrand) {...})
 * 
 * Ez azt jelenti, hogy az előző példa használhatatlan?
 *      Igen azt jelenti.
 * 
 * Készítsünk egy új objektumot csak most helyes megoldással!
 * 
 */

class Animals
{
    string type { get; set; }
    string breed { get; set; }
    string name { get; set; }

    public Animals(string Type, string Breed, string Name)
    {
        type = Type;
        breed = Breed;
        name = Name;
    }

    public string GetType()
    {
        return type;
    }

    public string GetBreed()
    {
        return breed;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }
}

/*
 * Ha ezeket az egyszerű szabályokat betartjuk akkor az objektumunk előhívható lesz és működőképes.
 * 
 */