using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Movement : MonoBehaviour
{
    BoxCollider2D Main_Floor;
    float Intial_pos;
    public float ms;

    void Start()
    {
        Main_Floor = GetComponent<BoxCollider2D>();
        Intial_pos = Main_Floor.size.x;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - ms * Time.deltaTime, transform.position.y);
        if (transform.position.x > -Intial_pos) {
            transform.position = new Vector2(transform.position.x, transform.position.y);
        } else {
            transform.position = new Vector2(transform.position.x + (Intial_pos * 2), transform.position.y);
        }
    }
}
