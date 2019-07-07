using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float thrust;
    Rigidbody rb;
    public float life_time = 15f;
    float time = 0f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        time = 0;


    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        print(time);
        if (time > life_time)
        {
            Destroy(gameObject);
        }
    }
}

