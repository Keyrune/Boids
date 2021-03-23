using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/StayInScreen")]
public class StayInScreenBehaviour : FlockBehaviour
{
    //private Vector2 screenBorder = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 screenBorder = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        screenBorder *= 0.9f;

        Vector2 move = Vector2.zero;
        move -= (Vector2)agent.transform.position;

        // If outside border go to center
        if (agent.transform.position.x > screenBorder.x ||
            agent.transform.position.x < -screenBorder.x ||
            agent.transform.position.y > screenBorder.y ||
            agent.transform.position.y < -screenBorder.y)
        {
            return move;
        }
            
        return Vector2.zero;
    }

}
