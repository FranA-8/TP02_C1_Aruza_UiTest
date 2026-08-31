using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
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
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (Input.GetKey(moveup))
        {
            transform.position += new Vector3 (0,moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(movedown))
        {
            transform.position += new Vector3 (0, -moveSpeed * Time.deltaTime);
        }   
        if (Input.GetKey(movedright))
        {
            transform.position += new Vector3 (moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(movedleft))
        {
            transform.position += new Vector3 (-moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(rotateleft))
        {
            transform.Rotate(0, 0, rotate);
        }
        if (Input.GetKeyDown(rotateright))
        {
            transform.Rotate(0, 0, -rotate);
        }
        if (Input.GetKeyUp(random))
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value, 1f);
        }
    }       
}
