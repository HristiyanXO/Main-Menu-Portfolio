using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
 using System.Threading.Tasks; 

public class SceneLoader : MonoBehaviour
{
    public static int sceneVal;

     public void LoadScene(int index)
    {
        sceneVal = index;
         SceneManager.LoadSceneAsync(1);
    }

 
 
}
