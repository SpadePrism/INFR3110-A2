using UnityEngine;

//https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/
//https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/
//https://unity3d.college/2018/12/12/creating-objects-in-unity3d-using-the-factory-pattern/
public interface IFactory
{
    void CreateShape();

    void SetPosition(Vector3 pos);

    // GameObject CreatePrefab();
}

public class Sphere : IFactory
{
    private Vector3 position;
    private Transform cube;

    public Sphere(Vector3 position, Transform cube)
    {
        this.position = position;
        this.cube = cube;
    }

    public void CreateShape()
    {
        SphereMaker.makeSphere(position, cube);
    }

    public void SetPosition(Vector3 pos)
    {
        position = pos;
    }
}

//public class Cube : IFactory
//{
//    private Vector3 positions;
//    private Transform prefab;

//    public Cube(Vector3 position, Transform cube)
//    {
//        this.positions = position;
//        this.prefab = cube;
//    }

//    public void CreateShape()
//    {
//        SphereMaker.makeSphere(positions, prefab);
//    }

//    public void SetPosition(Vector3 pos)
//    {
//        positions = pos;
//    }
//}

//public class Cylinder : IFactory
//{
//    private Vector3 positions;
//    private Transform prefab;

//    public Cylinder(Vector3 position, Transform cube)
//    {
//        this.positions = position;
//        this.prefab = cube;
//    }

//    public void CreateShape()
//    {
//        SphereMaker.makeSphere(positions, prefab);
//    }

//    public void SetPosition(Vector3 pos)
//    {
//        positions = pos;
//    }
//}

public abstract class ProductFactory
{
    private Vector3 position;

    public abstract IFactory MakeProduct();

    public abstract IFactory MakeProduct(Vector3 Position);

    public void SetPosition(Vector3 pos)
    {
        position = pos;
    }

    public IFactory GetObject() // Implementation of Factory Method.
    {
        return this.MakeProduct();
    }
}