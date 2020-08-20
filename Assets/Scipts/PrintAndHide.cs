using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
    int rand;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        rand = Random.Range(200,250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + " : " + i++ );
        if(tag == "Red" & i ==100)
        {
            gameObject.SetActive(false);
        }
        if(tag == "Blue" & i == rand)
        {
            gameObject.SetActive(false);
        }
    }
}
