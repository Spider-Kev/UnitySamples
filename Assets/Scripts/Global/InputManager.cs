using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PoolManager poolParticulas;
    public static float InputVertical
    {
        get { return Input.GetAxis("Vertical"); }
        private set{}
    }

    public static float InputHorizontal
    {
        get { return Input.GetAxis("Horizontal"); }
    }

    public static bool InputShoot
    {
        get { return Input.GetButtonDown("Jump"); }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        //InputVertical = Input.GetMouseButtonDown(0) ? 1 : 0;

        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            poolParticulas.AskForObject(Vector3.zero);
        }
        //InputVertical = 
    }
}
