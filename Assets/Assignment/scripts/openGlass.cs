using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGlass : MonoBehaviour
{
    public GameObject glass;
    private void OnCollisionEnter2D(Collision2D collision)
        {

        glass.SetActive(!glass.activeInHierarchy);

        }
    
