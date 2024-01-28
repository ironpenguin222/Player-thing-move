using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBack : MonoBehaviour
{
   
        void OnCollisionEnter2D(Collision2D collision)
        {
        collision.transform.position = Vector3.zero;
        }
    
}
