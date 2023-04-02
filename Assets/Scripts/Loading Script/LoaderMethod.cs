using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoaderMethod : MonoBehaviour
{
   public GameObject LoaderUI;
    public Slider progressSlider;
    
   void Start(){
      StartCoroutine(LoadScene_Coroutine(SceneLoader.sceneVal));

   }
   public IEnumerator LoadScene_Coroutine(int index)
    {
        Debug.Log(index);
        progressSlider.value = 0;
        LoaderUI.SetActive(true);
 
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
 
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;

            if (progress >= 0.9f)
            {
                progressSlider.value = 1;
                asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
