using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = new Vector2(0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
