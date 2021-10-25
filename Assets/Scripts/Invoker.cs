using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private static Queue<ICommand> commandBuffer;

    // Start is called before the first frame update
    private void Start()
    {
        commandBuffer = new Queue<ICommand>();
    }

    public static void AddCommand(ICommand command)
    {
        commandBuffer.Enqueue(command);
    }

    // Update is called once per frame
    private void Update()
    {
        if (commandBuffer.Count > 0)
        {
            ICommand c = commandBuffer.Dequeue();
            c.Execute();
        }
    }
}