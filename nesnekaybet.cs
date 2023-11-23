using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class nesnekaybet : MonoBehaviour

{

 
    public int kackeredekirilsin;


    private void OnMouseDown()
    {

        kackeredekirilsin--;

    }

    void Update()

    {
        if (kackeredekirilsin == 0)

        {
         
            Destroy(gameObject);  
        }
            
    }


}
