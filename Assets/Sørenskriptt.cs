using System;
using UnityEngine;

public class Sørenskriptt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected float SixSeven = 0.67f;
    [SerializeField] string Object;
    
    Rigidbody _rb;
    [SerializeField] GameObject _SørensDejligeObjekt;

    [SerializeField] float _speed = 10f;
    [SerializeField] float _shootCd = 3f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        print("Halløj Søren");
        Debug.Log(SixSeven + " " + Object);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
