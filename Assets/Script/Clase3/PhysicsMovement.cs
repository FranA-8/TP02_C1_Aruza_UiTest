using System;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    [Header("Movement")]
    [SerializeField] private KeyCode moveup = KeyCode.W;
    [SerializeField] private KeyCode movedown = KeyCode.S;
    [SerializeField] private KeyCode movedleft = KeyCode.A;
    [SerializeField] private KeyCode movedright = KeyCode.D;
    private Rigidbody2D rb;

    internal void SetColor(float value)
    {
        throw new NotImplementedException();
    }

    internal void SetSize(float value)
    {
        throw new NotImplementedException();
    }

    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(moveup))
        {
            rb.AddForce(new Vector3(0, moveSpeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(movedown))
        {
            rb.AddForce(new Vector3(0, -moveSpeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(movedright))
        {
            rb.AddForce(new Vector3(moveSpeed * Time.fixedDeltaTime, 0));
        }
        if (Input.GetKey(movedleft))
        {
            rb.AddForce(new Vector3(-moveSpeed * Time.fixedDeltaTime, 0));
        }
    }
}
