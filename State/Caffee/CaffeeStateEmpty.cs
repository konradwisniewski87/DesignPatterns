namespace State.Caffee;

public class CaffeeStateEmpty : CaffeeState
{
    public CaffeeStateEmpty()
    {
        Console.WriteLine("Caffee is empty!");
    }
	public override void Fill(Caffee caffee)
	{
		Console.WriteLine("Caffee is filling");
		caffee.caffeeState = new CaffeeStateFull();
	}
}