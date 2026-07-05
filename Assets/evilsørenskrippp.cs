using System;
         using UnityEngine;
         using UnityEngine.AI;
         using Random = System.Random;
         
         public class evilsørenskrippp : MonoBehaviour
         {
             public NavMeshAgent agent;
             public bool peanutButterJellyTimeSpørgsmålsTegn;
             [SerializeField] Material myMaterialyay;
             GameObject playah;

             void Start()
             {
                 playah = GameObject.FindGameObjectWithTag("Player");
             }

             void Update()
             {
                 agent.SetDestination(playah.transform.position);
             }

             void OnTriggerEnter(Collider other)
             {
                 if (other.CompareTag("Bullet"))
                 {
                 //myMaterialyay.color = new Color(UnityEngine.Random.Range(0, 255), UnityEngine.Random.Range(0, 255), UnityEngine.Random.Range(0, 255), 0);
        Destroy(this.gameObject);
        }
    }
}
