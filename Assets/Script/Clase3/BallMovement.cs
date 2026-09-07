using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private KeyCode launch = KeyCode.Space;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(launch))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(1f, 5f)) * 5f, ForceMode2D.Impulse);
        }

    }
}
