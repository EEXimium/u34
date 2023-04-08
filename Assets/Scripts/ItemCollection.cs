using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public Button collectButton;

    private void Start()
    {
            //buton g�r�nmez olur, mouse simgesi ekranda belirir.
            collectButton.gameObject.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerEnter(Collider other)
    {
        ////karakterle item etkile�ime girdi�inde buton ortaya ��kar.
        if (other.CompareTag("Player"))
        {
            collectButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //karakter ve itemin etkile�imi kesildi�inde buton ortadan kalkar.
        if (other.CompareTag("Player"))
        {
            collectButton.gameObject.SetActive(false);
        }
    }

    public void Collect()
    {
        //istenilen nesne yok edilir, buton tekrar g�r�nmez hale gelir.
        Destroy(gameObject);
        collectButton.gameObject.SetActive(false);
    }

}
