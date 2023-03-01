Console.WriteLine("Кто ты воин? ");
string username = Console.ReadLine(); //оператор равенства значит возьми то что справа и положи в то что слева
if(username == "Ахиллес, сын Пелея") //toLower() -все символы строки, переносит в нижний регистр
{
    Console.WriteLine("Ахиллес? Я помню это имя");
}
else 
{
Console.Write("Я уважаю тебя как противника.И теперь буду уважать тебя как союзника, ");
Console.Write(username);
}