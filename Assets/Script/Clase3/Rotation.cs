using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Header("Rotate")]
    [SerializeField] private KeyCode rotateleft = KeyCode.Q;
    [SerializeField] private KeyCode rotateright = KeyCode.E;
    [SerializeField] private float rotate = 10f;
    void Update()
    {
        if (Input.GetKeyDown(rotateleft))
        {
            transform.Rotate(0, 0, rotate);
        }
        if (Input.GetKeyDown(rotateright))
        {
            transform.Rotate(0, 0, -rotate);
        }
    }
}
