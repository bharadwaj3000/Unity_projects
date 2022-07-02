using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 15f;
    public float maxwidth = 5f;

    public Rigidbody2D rb;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newposition = rb.position + Vector2.right * x;

        newposition.x = Mathf.Clamp(newposition.x, -maxwidth, maxwidth);
        rb.MovePosition(newposition);
        
    }

    void OnCollisionEnter2D(){
        FindObjectOfType<gamemanager>().EngGame();
    }
}
