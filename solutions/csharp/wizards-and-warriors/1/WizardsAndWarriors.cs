abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType) => _characterType = characterType;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")    {}

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool IsSpellReady = false;
    
    public Wizard() : base("Wizard")    {}

    public override int DamagePoints(Character target) => target.Vulnerable() ? 3 : 12;

    public override bool Vulnerable() => IsSpellReady == false;
    
    public void PrepareSpell() => IsSpellReady = true;
}
