using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimieno : MonoBehaviour
{
    Rigidbody2D Movimiento;
    public float horizontal;
    public float vertical;
    public float velocidad;
    void Awake()
    {
        Movimiento = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Movimiento.velocity = new Vector2(horizontal * velocidad, vertical * velocidad);
    }
}
