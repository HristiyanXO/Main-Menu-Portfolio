using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    float y = 180;
    
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    public void Right(float speedY = 1f){
        
        y -= speedY;
         
    }
    public void Left(float speedY = 1f){
       
        y += speedY;
        //    transform.Rotate(_rotation * _speed * Time.deltaTime);

         
    }

    void Update(){

    transform.eulerAngles = new Vector3(0,y,0);


    }
   
}
