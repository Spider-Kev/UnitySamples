using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float rotSpeed = 50f;

    public CharacterShoot characterShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime*
                            InputManager.InputVertical);
        
        /*transform.Translate(Vector3.right * speed * Time.deltaTime*
                            InputManager.InputHorizontal);*/
        
        transform.Rotate(Vector3.up *Time.deltaTime * rotSpeed * InputManager.InputHorizontal);
        
        if (InputManager.InputShoot)
            characterShoot.Shoot();

        Bullet balita = new Bullet();
        balita.speed = 10;
        Debug.Log(balita.speed);
    }
}
