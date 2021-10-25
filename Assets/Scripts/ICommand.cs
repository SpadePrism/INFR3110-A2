using UnityEngine;

public interface ICommand
{
    void Execute();
}

public class PlaceDeathCommand : ICommand
{
    private Vector3 position;
    private Transform cube;

    public PlaceDeathCommand(Vector3 position, Transform cube)
    {
        this.position = position;
        this.cube = cube;
    }

    public void Execute()
    {
        SphereMaker.makeSphere(position, cube);
    }
}