using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceItem : MonoBehaviour
{
    public Button Place;
    public GameObject item;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    private ItemCollection boolCheck;
    private bool check;
    private bool check2;
    private bool check3;

    void Start()
    {
        //buton ve itemin ba�lang��ta g�r�nmez olmas�n� sa�lar.
        Place.gameObject.SetActive(false);
        item.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    private void Update()
    {
        //boolCheck = cadir.GetComponent<ItemCollection>();
        check = obj1.GetComponent<ItemCollection>().check;
        check2 = obj2.GetComponent<ItemCollection>().check;
        check3 = obj3.GetComponent<ItemCollection>().check;

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

        if (check == true && check2 == true && check3 && true)
        {
            Place.gameObject.SetActive(false);
            Destroy(gameObject);
            item.SetActive(true);
        }

        
        
        
    }


}
