using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Plastics" || target.tag == "Fish")
        {
            Destroy(target.gameObject);
        }

    }
}
