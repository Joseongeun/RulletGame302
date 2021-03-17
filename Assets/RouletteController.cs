using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0.0f;
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        if(Input.GetMouseButtonUp(1))
        {
            this.rotSpeed = 0.0f;
        }
        this.rotSpeed *= 0.96f;
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
