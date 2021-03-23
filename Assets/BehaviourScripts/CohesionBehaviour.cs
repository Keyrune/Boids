using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behaviour/Cohesion")]
public class CohesionBehaviour : FlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 cohesionMove = Vector2.zero;
        if (context.Count == 0) //if no neighbors return (0, 0)
            return cohesionMove;

        // find everage neighbor pos
        foreach (Transform item in context)
        {
            cohesionMove += (Vector2)item.position;
        }
        cohesionMove /= context.Count;
        
        // offset from agent position 
        cohesionMove -= (Vector2)agent.transform.position;
        return cohesionMove;

    }
}
