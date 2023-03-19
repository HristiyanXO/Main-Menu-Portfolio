using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Button rightArrow;

    Rotate rotateScript;

    float speedY = 50;

    void Start(){
        rotateScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Rotate>();

        Button btn = rightArrow.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

   
    public void RotateRight(){
        
        rotateScript.Right(speedY);
          
    }
    public void RotateLeft(){
        rotateScript.Left(speedY);
        
    }
 void TaskOnClick(){
        Debug.Log("Testvam Brat");
    }

    public void Update(){
       
       if (Input.GetKey(KeyCode.RightArrow)){
            rotateScript.Right();

       }
        if (Input.GetKey(KeyCode.LeftArrow)){
            rotateScript.Left();

       }
    }

}
