using UnityEngine;

public class PhysicsRotation : MonoBehaviour
{
    [Header("Rotate")]
    [SerializeField] private KeyCode rotateleft = KeyCode.Q;
    [SerializeField] private KeyCode rotateright = KeyCode.E;
    [SerializeField] private float rotateSpeed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(rotateleft))
        {
            rb.rotation += rotateSpeed;

            //continua
            //rb.AddTorque(rotateSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(rotateright))
        {   
            rb.rotation -= rotateSpeed;
            
            //continua
            //rb.AddTorque(-rotateSpeed, ForceMode2D.Impulse);
        }
    }
}
