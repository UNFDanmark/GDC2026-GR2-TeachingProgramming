using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sørenskriptt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected float SixSeven = 0.67f;
    [SerializeField] string Object;
    
    Rigidbody _rb;
    [SerializeField] GameObject _SørensDejligeObjekt;

    [SerializeField] float _speed = 10f;
    [SerializeField] float _shootCd = 3f;

    public InputAction move;

    public Vector3 moveValue;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        print("Halløj Søren");
        Debug.Log(SixSeven + " " + Object);
        move.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        moveValue = move.ReadValue<Vector3>();
        print(moveValue);
        Vector3 newVelocity = _rb.linearVelocity;
        newVelocity.x = moveValue.x * _speed;
        newVelocity.y = moveValue.y * _speed;
        newVelocity.z = moveValue.z * _speed;

        _rb.linearVelocity = newVelocity;
    }
}
