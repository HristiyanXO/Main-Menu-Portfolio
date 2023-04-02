using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{

    Rotate rotateScript;

    float speedY = 50;

   
   

    public void Update(){
       
       if (Input.GetKey(KeyCode.RightArrow)){
            rotateScript.Right();

       }
        if (Input.GetKey(KeyCode.LeftArrow)){
            rotateScript.Left();

       }
    }

}
