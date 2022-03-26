using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private float depth = 0.0001f;
    private void Update()
    {
        Movement();
    } 
    private void Movement()
    {
        Vector2 direction = rb.velocity;
        float angel = Mathf.Atan2(direction.y, direction.x);
        transform.rotation = Quaternion.AngleAxis(angel, Vector3.forward);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            collision.transform.Translate(depth * -Vector2.right);
            transform.parent = collision.transform;
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<Collider2D>());
        }
    }
}
