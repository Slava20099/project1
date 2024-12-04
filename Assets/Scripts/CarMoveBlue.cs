using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveBlue : MonoBehaviour
{
    public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if (transform.position.x < -76)
        {
            transform.rotation = Quaternion.Euler(0, 0 ,0);
        }
        if (transform.position.z > 53&&transform.position.x < -76)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (transform.position.x > 3)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (transform.position.z < -24&&transform.position.x > 3)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }
}
