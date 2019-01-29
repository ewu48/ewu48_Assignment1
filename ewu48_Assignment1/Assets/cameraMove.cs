using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
	public bool flag = true;    
	public Camera cam1;
    	public Camera cam2;
    
  void Start()
    {
        cam1.enabled = flag;
        cam2.enabled = !flag;
    }

 void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            flag = !flag;
            cam1.enabled = flag;
            cam2.enabled = !flag;
        }

    }
}

