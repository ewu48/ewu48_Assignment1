using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    
	public Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        start = gameObject.transform.position;
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButton(1)) //right click detection
        {
            gameObject.transform.position = start;
        }
}
}