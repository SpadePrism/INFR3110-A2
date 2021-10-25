using UnityEngine.UI;

public interface ICommand
{
    void Execute();
}

//public class PlaceDeathCommand : ICommand
//{
//    private Vector3 position;
//    private Transform cube;

//    public PlaceDeathCommand(Vector3 position, Transform cube)
//    {
//        this.position = position;
//        this.cube = cube;
//    }

//    public void Execute()
//    {
//        SphereMaker.makeSphere(position, cube);
//    }
//}

//public class ChangeColorCommand : ICommand
//{
//    private Color color;
//    private GameObject item;

//    public ChangeColorCommand(GameObject item, Color color)
//    {
//        this.item = item;
//        this.color = color;
//    }

//    public void Execute()
//    {
//    }
//}

public class SpawnButtonCommand : ICommand
{
    private Button button;

    public SpawnButtonCommand(Button color)
    {
        this.button = color;
    }

    public void Execute()
    {
        button.gameObject.SetActive(true);
    }
}