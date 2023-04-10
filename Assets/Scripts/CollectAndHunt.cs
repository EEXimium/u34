using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAndHunt : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("okYay"))
        {
            Destroy(other.gameObject);
        }
    }

}
