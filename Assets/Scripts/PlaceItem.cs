using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceItem : MonoBehaviour
{
    public Button Place;
    public GameObject item;

    void Start()
    {
        //buton ve itemin ba�lang��ta g�r�nmez olmas�n� sa�lar.
        Place.gameObject.SetActive(false);
        item.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        //karakterle item etkile�ime girdi�inde buton ortaya ��kar.
        if (other.CompareTag("Player"))
        {
            Place.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ////karakter ve itemin etkile�imi kesildi�inde buton ortadan kalkar.
        if (other.CompareTag("Player"))
        {
            Place.gameObject.SetActive(false);
        }
    }

    public void Replace()
    {
        ////buton g�r�nmez olur ve plane yok edilir. �stenilen nesne olu�ur.
        Place.gameObject.SetActive(false);
        Destroy(gameObject);
        item.SetActive(true);

    }


}
