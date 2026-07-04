using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    public float bulletLifeTimeAmount;
    float bulletLifeTime;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        bulletLifeTime = bulletLifeTimeAmount;
    }

    // Update is called once per frame
    void Update()
    {
        bulletLifeTime -= Time.deltaTime;
        if (bulletLifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
