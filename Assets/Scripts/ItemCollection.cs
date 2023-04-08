using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public Button collectButton;

    private void Start()
    {
            //buton görünmez olur, mouse simgesi ekranda belirir.
            collectButton.gameObject.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerEnter(Collider other)
    {
        ////karakterle item etkileþime girdiðinde buton ortaya çýkar.
        if (other.CompareTag("Player"))
        {
            collectButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //karakter ve itemin etkileþimi kesildiðinde buton ortadan kalkar.
        if (other.CompareTag("Player"))
        {
            collectButton.gameObject.SetActive(false);
        }
    }

    public void Collect()
    {
        //istenilen nesne yok edilir, buton tekrar görünmez hale gelir.
        Destroy(gameObject);
        collectButton.gameObject.SetActive(false);
    }

}
