using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the transform in the direction and distance of translation//

        //.foward in Vector3 for forward new vector movement lol GG//

        Debug.Log(Time.deltaTime);
        //Vector3.forward ---> (0,0,1)
        //(0,0,1) * Time.deltaTime = (0,0,.001)
        transform.Translate(Vector3.forward * Time.deltaTime * 10);


    }
}
