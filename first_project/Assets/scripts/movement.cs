using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float forwardforce = 2500f;
    public float sidewaysforce = 800f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }
}
