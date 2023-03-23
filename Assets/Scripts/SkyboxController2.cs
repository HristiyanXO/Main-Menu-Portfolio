using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController2 : MonoBehaviour
{
    public Material matl;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSky()
    {
        RenderSettings.skybox = matl;
    }

}
