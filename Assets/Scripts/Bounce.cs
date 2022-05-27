using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    public Rigidbody2D rb;

    public float jumpStrength;
    public float varianceStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 force = Vector2.up * jumpStrength + new Vector2(Random.Range(-varianceStrength, varianceStrength), Random.Range(-varianceStrength, varianceStrength));
            rb.AddForce(force);
            AudioController.PlayAudio("Gun");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioController.PlayAudio("Chomp");
    }
}
