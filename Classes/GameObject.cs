public abstract class GameObject
{
    public bool IsEliminated {get; set;}

    public GameObject(bool isEliminated)
    {
        IsEliminated = false;
    }

    public virtual void MovePiece()
    {

    }
}