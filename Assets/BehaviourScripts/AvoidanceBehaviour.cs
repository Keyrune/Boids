using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behaviour/Avoidance")]
public class AvoidanceBehaviour : FlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 avoidanceMove = Vector2.zero;
        if (context.Count == 0) //if no neighbors return (0, 0)
            return avoidanceMove;

        int nAvoid = 0;
        foreach (Transform item in context)
        {
            nAvoid++;
            avoidanceMove += (Vector2)(agent.transform.position - item.position);
        }
        if (nAvoid > 0)
            avoidanceMove /= nAvoid;

        return avoidanceMove;

    }
}
