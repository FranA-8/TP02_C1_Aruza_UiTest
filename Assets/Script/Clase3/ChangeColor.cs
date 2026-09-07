using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [Header("Color")]
    [SerializeField] private KeyCode random = KeyCode.R;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    private void Update()
    {
        if (Input.GetKeyUp(random))
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value, 1f);
        }
        
    }

}
