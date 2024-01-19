using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PoolManager poolParticulas;
    public static float InputVertical;
    public static float InputHorizontal;
    public static bool InputShoot;
   
    // Update is called once per frame
    void Update()
    {
        
        
        
        
        

        #if UNITY_ANDROID && !UNITY_EDITOR
        InputShoot = false;
        InputHorizontal = 0f;
        
        if (Input.touchCount<=0)
            return;
        
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended && touch.deltaTime < 1)
            InputShoot = true;
        
        if (touch.phase == TouchPhase.Stationary)
        {
            Vector2 touchPos = touch.position;
            if (touchPos.x > Screen.width / 2f)
                InputHorizontal = 1f;
            else
                InputHorizontal = -1;    
        }
        
        #else
        InputShoot = Input.GetButtonDown("Jump");       // true, false
        InputVertical = Input.GetAxis("Vertical");      // [-1,1]
        InputHorizontal = Input.GetAxis("Horizontal");  // [-1,1]
        #endif
    }
}
