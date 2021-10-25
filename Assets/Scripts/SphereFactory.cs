using UnityEngine;

//http://gyanendushekhar.com/2016/07/02/factory-method-design-pattern-c/

//https://www.patrykgalach.com/2019/03/28/implementing-factory-design-pattern-in-unity/

//concrete creator
public class SphereFactory : ProductFactory
{
    private Vector3 position;
    private Transform cube;

    public SphereFactory(Vector3 position, Transform cube)
    {
        this.position = position;
        this.cube = cube;
    }

    public override Sphere MakeProduct()
    {
        Sphere product = new Sphere(position, cube);
        product.CreateShape();
        return product;
    }

    public override Sphere MakeProduct(Vector3 Position)
    {
        Sphere product = new Sphere(Position, cube);
        product.CreateShape();

        return product;
    }
}