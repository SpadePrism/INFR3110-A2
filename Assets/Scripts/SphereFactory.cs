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

    public override IFactory MakeProduct()
    {
        IFactory product = new Sphere(position, cube);
        product.CreateShape();
        return product;
    }

    public override IFactory MakeProduct(Vector3 Position)
    {
        IFactory product = new Sphere(Position, cube);
        product.CreateShape();

        return product;
    }
}