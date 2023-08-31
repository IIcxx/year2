using iThinkSoQuestionMark;

Items cod = new Items();
Items salmon = new Items();
Character starter = new Character();
Weapons flintsword = new Weapons();
cod.Healing = 3;
salmon.Healing = 5;
starter.Health = 20;
starter.Speed = 5;
starter.Damage = 1;
flintsword.Damage = 4;

Console.WriteLine(starter.Damage);
Console.WriteLine("You found a flint sword, do you want to equip it /n Y = Yes /n N = No");
if(Console.ReadLine() == "y" || Console.ReadLine() == "Y"){
    starter.Damage +=4;
    Console.WriteLine(starter.Damage);
}
else{
    Console.WriteLine("okay, you get no weapon then have fun without a weapon");
    
}


Console.ReadLine();