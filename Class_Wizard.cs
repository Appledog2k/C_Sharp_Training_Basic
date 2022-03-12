// Tạo một thuật sĩ (Wizard) :)))
namespace Class
{
    class Wizard {
    //Khởi tạo thuộc tính của thuật sĩ
    public string name;
    public string favoriteSpell;
    private int spellSlots;
    int experience; // ko viết gì mặc định là private
    public static int Count;

    public Wizard(string _name, string _favoriteSpell){
        name = _name;
        favoriteSpell = _favoriteSpell;
        spellSlots = 2;
        experience = 0; 
        Count++;
    }

    public void CastSpell() {
        if (spellSlots > 0) {
        Console.WriteLine(name + " casts " + favoriteSpell);
        spellSlots--;
        experience += 1;
        }else {
            Console.WriteLine(name + " is out of spell slots");
        }
    }
    public void Meditate() {
        Console.WriteLine(name + " meditates to regain spell slots.");
        spellSlots += 1;
    }
    

}
}