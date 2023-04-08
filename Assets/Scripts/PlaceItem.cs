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
        //buton ve itemin baþlangýçta görünmez olmasýný saðlar.
        Place.gameObject.SetActive(false);
        item.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        //karakterle item etkileþime girdiðinde buton ortaya çýkar.
        if (other.CompareTag("Player"))
        {
            Place.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ////karakter ve itemin etkileþimi kesildiðinde buton ortadan kalkar.
        if (other.CompareTag("Player"))
        {
            Place.gameObject.SetActive(false);
        }
    }

    public void Replace()
    {
        ////buton görünmez olur ve plane yok edilir. Ýstenilen nesne oluþur.
        Place.gameObject.SetActive(false);
        Destroy(gameObject);
        item.SetActive(true);

    }


}
