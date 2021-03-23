using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behaviour/Alignment")]
public class AlignmentBehaviour : FlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Debug.Log(agent.transform.up);
        Vector2 alignmentMove = Vector2.zero;
        //if no neighbors maintain current direction
        if (context.Count == 0) 
            return agent.transform.up;

        // find everage neighbor pos
        foreach (Transform item in context)
        {
            alignmentMove += (Vector2)item.transform.up;
        }
        alignmentMove /= context.Count;

        return alignmentMove;

    }
}
