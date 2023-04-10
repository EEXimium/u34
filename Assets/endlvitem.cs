using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlvitem : MonoBehaviour
{
    public GameObject mn;
    public GameObject pumpkin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pumpkin.activeSelf == false)
        {
            mn.GetComponent<LevelChanger>().FadeToNextLevel();
        }
    }
}
