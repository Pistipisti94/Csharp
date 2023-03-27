/*
 * A C# egy úgynevezett OOP (Object Oriented Program) nyelv (nem igazán).
 * Az objektumok különféle könyvtárak (class) vagy adattípúsok is lehetnek.
 * 
 * Az előhívásuk pedig nagyon egyszerű.
 * A következő példában írjunk meg egy előhívást és elemezzük azt (az angol óriási segítség), ezt a random objektummal fogjuk megtenni.
 * 
 */

using System;

Random veletlen = new Random();

/*
 * Ebben a példában az objektumnak nincsnek kezdő paraméterei.
 * 
 * Az első szóban megadjuk magának a valtozónak a típúsát, ebben az esetben Object lesz, specifikusan Random Object.
 * A második szó "veletlen" a változónak az előhívó neve lesz majd megadunk neki egy új értéket ami a Random Object lesz (Random).
 * A "new Random()" kifejezés pontosan azt jelenti aminek tűnik, létre hozunk egy másolatot arról az objektumról majd a későbbiekben
 * ezzel a másolattal fogunk dolgozni.
 * (A Random objektum ugyan olyan megírt programrész amit akár én vagy Te is meg tudsz írni!)
 * 
 */

/*
 * A következő példában a létrehozott objektummal fogunk dolgozni és azt kielemezni.
 * 
 */

veletlen.Next(0, 10); // Itt előhívjuk a programba beépített metódus egyikét (public virtual int Next(int minValue, int maxValue) {...})