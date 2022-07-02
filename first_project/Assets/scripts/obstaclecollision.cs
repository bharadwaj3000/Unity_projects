
using UnityEngine;

public class obstaclecollision : MonoBehaviour

    
{
    public movement player_movement;
    void OnCollisionEnter(Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "obstacle")
        {
            player_movement.enabled = false;
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }
}
