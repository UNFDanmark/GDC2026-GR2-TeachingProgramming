using System;
         using UnityEngine;
         using Random = System.Random;
         
         public class evilsørenskrippp : MonoBehaviour
         {
             public bool peanutButterJellyTimeSpørgsmålsTegn;
             [SerializeField] Material myMaterialyay;
         
             void OnTriggerEnter(Collider other)
             {
                 if (other.CompareTag("Bullet"))
                 {
                 //myMaterialyay.color = new Color(UnityEngine.Random.Range(0, 255), UnityEngine.Random.Range(0, 255), UnityEngine.Random.Range(0, 255), 0);
        Destroy(this.gameObject);
        }
    }
}
