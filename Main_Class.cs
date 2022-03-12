// See https://aka.ms/new-console-template for more information
/* 
Mô tả lớp thông qua thực tế tạo một nhân vật 
*/

Class.Wizard wizard01 = new Class.Wizard("LuLu","Healing");
Class.Wizard wizard02 = new Class.Wizard("Soraka", "Healing All");

wizard01.CastSpell();
wizard01.Meditate();

wizard02.CastSpell();
wizard02.Meditate();

//  tìm xem đã tạo bao nhiêu wizard
Console.WriteLine(Class.Wizard.Count);







