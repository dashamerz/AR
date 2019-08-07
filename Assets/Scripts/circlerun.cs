using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlerun : StateMachineBehaviour
{
    private GameObject hero;
    float speed = (2 * Mathf.PI) / 5;
    private float X = 0.0f;
    private float Y = 0.0f;
    private float Z = 0.0f;
    float radius = 0.2f;
   
    void OnStateUpdate()
    {
        hero = GameObject.Find("Hero_00");
        X = Mathf.Cos(speed) * radius;
        Z = Mathf.Sin(speed) * radius;

        hero.transform.Translate(new Vector3(X, Y, Z) * Time.deltaTime);
    }

    
}

