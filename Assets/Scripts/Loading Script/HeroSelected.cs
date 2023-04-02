using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSelected : MonoBehaviour
{
    public static int hero;
    int heroNum = HeroData.hero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(heroNum);
        if(heroNum == 0){
            Debug.Log("Hero One");
        }
    }

    // Update is called once per frame
   
}
