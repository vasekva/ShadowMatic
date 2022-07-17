using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRotation : MonoBehaviour
{
    GameObject compared;
    
    
    // Start is called before the first frame update
    void Start()
    {
        compared = GameObject.Find("ComparedObject");
        if (!compared)
            Debug.Log("Ooops, there's some error!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float main_axis_x = transform.rotation.x;
        float cmprd_axis_x = compared.transform.GetChild(0).rotation.x;
        float x_diff = (float)Math.Abs(Math.Round(main_axis_x - cmprd_axis_x, 2));
        
        
        float main_axis_y = transform.rotation.y;
        float cmprd_axis_y = compared.transform.GetChild(0).rotation.y;
        float y_diff = (float)Math.Abs(Math.Round(main_axis_y - cmprd_axis_y, 2));
        
        float main_axis_z = transform.rotation.z;
        float cmprd_axis_z = compared.transform.GetChild(0).rotation.z;
        float z_diff = (float)Math.Abs(Math.Round(main_axis_z - cmprd_axis_z, 2));

        if (x_diff <= 0.02f && y_diff <= 0.02f && z_diff <= 0.04f)
            Debug.Log("You win!");
    }
}
