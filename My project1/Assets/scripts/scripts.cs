using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.getkey(keycode.W))
            transform.position = new vector3(transform.position.x,transform.position.y + 0.001f, 0);

        if (input.getkey(keycode.D))
            transform.position = new vector3(transform.position.x + 0.001f, transform.position.y , 0);

        if (input.getkey(keycode.A))
            transform.position = new vector3(transform.position.x +0.001f, transform.position.y,  0);
      
        if (input.getkey(keycode.S))
            transform.position = new vector3(transform.position.x +0.001f, transform.position.y , 0);


    }
}
