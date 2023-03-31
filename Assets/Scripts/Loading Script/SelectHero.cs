using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHero : MonoBehaviour
{

    public void Select(int heroNum){

      HeroData.hero = heroNum;
        
    }
}
