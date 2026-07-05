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
    [SerializeField] float _shootCdAmount = 3f;

    public InputAction move;
    public InputAction create;
    public InputAction shoot;

    public Vector3 moveValue;

    float _shootCd;

    public GameObject Bullet;
    public GameObject ShootPoint;
    public float BulletZoom;
    
    
    public float BulletLifeTime;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        print("Halløj Søren");
        Debug.Log(SixSeven + " " + Object);
        move.Enable();
        create.Enable();
        shoot.Enable();
        _shootCd = _shootCdAmount;
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
        _shootCd -= Time.deltaTime;
        if (create.IsPressed())
        {
            Instantiate(_SørensDejligeObjekt);
        }

        if (shoot.IsPressed())
        {
            print("shot!");
            print(_shootCd);
            if (_shootCd <= 0)
            {
                _shootCd = _shootCdAmount;
                GameObject bullet = Instantiate(Bullet, ShootPoint.transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * BulletZoom, ForceMode.Force);
                bullet.GetComponent<bulletBehaviour>().bulletLifeTimeAmount = BulletLifeTime;
                
                GameObject bullet2 = Instantiate(Bullet, ShootPoint.transform.position, Quaternion.Euler(0, -20, 0));
                bullet2.GetComponent<Rigidbody>().AddRelativeForce(bullet2.transform.forward * BulletZoom, ForceMode.Force);
                bullet2.GetComponent<bulletBehaviour>().bulletLifeTimeAmount = BulletLifeTime;
                
                GameObject bullet3 = Instantiate(Bullet, ShootPoint.transform.position, Quaternion.Euler(0, 20, 0));
                bullet3.GetComponent<Rigidbody>().AddRelativeForce(bullet3.transform.forward * BulletZoom, ForceMode.Force);
                bullet3.GetComponent<bulletBehaviour>().bulletLifeTimeAmount = BulletLifeTime;
            }
        }
    }
}
