using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danozona : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        ruby controller = other.GetComponent<ruby>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}