using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    void Start()
    {
        rb.gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -2f){
            Destroy(gameObject);
        }
    }
}
