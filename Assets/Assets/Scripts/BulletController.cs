using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody2D.position.y > 5.6f || _rigidbody2D.position.y < -5.6f || _rigidbody2D.position.x < -9.49 || _rigidbody2D.position.x > 9.49)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        Vector2 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SetPosition(mouseInput);
    }
    void SetPosition(Vector2 Direccion)
    {
        _rigidbody2D.position = _rigidbody2D.position + Direccion.normalized * Speed * Time.deltaTime;
    }
}
