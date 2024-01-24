//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public Collision collision;
    public PlayerScript player;
    public Stats entityStats;
    public string target;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == target)
        {
            entityStats.health -= 25;
        }

        if (entityStats.health <= 0)
        {
            player.enabled = false;
        }
    }
}
