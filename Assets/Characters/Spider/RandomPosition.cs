using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public GameObject prefab;
    public int xPos;
    public int zPos;
    public int index;
    public float wait;
    public int objectToadd;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(index < objectToadd)
        {
            xPos = Random.Range(-5,10);
            zPos = Random.Range(-5,14);

            Instantiate(prefab, new Vector3(xPos, 15, zPos), Quaternion.identity);
            yield return new WaitForSeconds(wait);
            index += 1;
        }
    }
}
