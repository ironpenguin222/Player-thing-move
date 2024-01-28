using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetBack : MonoBehaviour
{
    public int playerX = 0;
    public int playerY = 0;

    void OnCollisionEnter2D(Collision2D collision)
        {
        Vector2 playerCoords = new Vector2(playerX, playerY);
        collision.transform.position = playerCoords;
        }
    
}
