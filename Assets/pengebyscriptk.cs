using System;
using System.Threading;
using UnityEngine;

public class pengebyscriptk : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PengeManager.instance.pinge++;
            Debug.Log(PengeManager.instance.pinge);
            Destroy(this.gameObject);
        }
    }
}
