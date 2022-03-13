// See https://aka.ms/new-console-template for more information

//! Enum === TYPE LIST

// initialization Enum
Enum.Learning_ability learning_Ability;


learning_Ability = Enum.Learning_ability.Kha;

// Convert enum to number

int number = (int)learning_Ability;
System.Console.WriteLine(number);

// Convert number to enum

learning_Ability = (Enum.Learning_ability)(300);
System.Console.WriteLine(learning_Ability);


switch (learning_Ability)
{
    case Enum.Learning_ability.Kem:
        System.Console.WriteLine("Học lực kém");
        break;
    case Enum.Learning_ability.TrungBinh:
        System.Console.WriteLine("Học lực trung bình");
        break;
    case Enum.Learning_ability.Kha:
        System.Console.WriteLine("Học lực khá");
        break;
    case Enum.Learning_ability.Gioi:
        System.Console.WriteLine("Học lực giỏi");
        break;
    default:
        System.Console.WriteLine("Không có đối tượng này");
        break;
}
