using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDetected : MonoBehaviour
{
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.color = Color.red;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.color = Color.white;
        Vector2 sendPlayer = new Vector2(0, 0);
        collision.transform.position = sendPlayer;
    }
}
