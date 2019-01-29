using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt: MonoBehaviour
{
    public Quaternion rotate;

    // Start is called before the first frame update
    void Start()
    {
        rotate = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
                   
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(3, 0, 2);
        }       
    }
}