using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_movement : MonoBehaviour
{
    public float ms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - ms * Time.deltaTime, transform.position.y);
        if (transform.position.x <= -3.5) {
            Destroy(gameObject);
        }
    }
}
