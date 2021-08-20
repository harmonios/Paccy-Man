using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_creator : MonoBehaviour
{
    public GameObject Object_Insert;
    public float small;
    public float large;
    float intial;

    // Start is called before the first frame update
    void Start()
    {
        Create_Wall();
    }

    // Update is called once per frame
    void Update()
    {
        intial += Time.deltaTime;
        if (intial > 3) {
            intial = 0;
            Create_Wall();
        }
    }

    void Create_Wall(){
        float within = Random.Range(small, large); 
        GameObject Wall = Instantiate(Object_Insert);
        Wall.transform.position = new Vector2(transform.position.x, within);
    }
}
