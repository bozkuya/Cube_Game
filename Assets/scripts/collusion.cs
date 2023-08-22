
using UnityEngine;

public class collusion : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}