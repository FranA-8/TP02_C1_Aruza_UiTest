using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    [Header("Movement")]
    [SerializeField] private KeyCode moveup = KeyCode.W;
    [SerializeField] private KeyCode movedown = KeyCode.S;
    [SerializeField] private KeyCode movedleft = KeyCode.A;
    [SerializeField] private KeyCode movedright = KeyCode.D;
    [Header("Rotate")]
    [SerializeField] private KeyCode rotateleft = KeyCode.Q;
    [SerializeField] private KeyCode rotateright = KeyCode.E;
    [SerializeField] private float rotate = 10f;

    [Header("Color")]
    [SerializeField] private KeyCode random = KeyCode.R;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        if (Input.GetKeyUp(random))
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value, 1f);
        }
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
