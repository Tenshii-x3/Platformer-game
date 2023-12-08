using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattack : MonoBehaviour
{
    private bool attacking = false;

    private float timetoattack = 0.25f;
    private float timer = 0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKey("z"))

        {
            attacking = true;
        }

        if(attacking)
        {

            if (timer > timetoattack)
            {
                timer = 0f;
                attacking = false;
             
            }
        }
    }

}
