using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSingleton : MonoBehaviour
{
    void Awake()
    {
        int numberOfCanvases = FindObjectsOfType<CanvasSingleton>().Length;
        if (numberOfCanvases > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
