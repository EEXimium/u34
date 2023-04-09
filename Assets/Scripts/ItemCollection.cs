using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public Button collectButton;
    public bool check = false;

    private void Start()
    {
        collectButton.gameObject.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            collectButton.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            collectButton.gameObject.SetActive(false);
    }

    public void Collect()
    {
        check = true;
        gameObject.SetActive(false);
        //Destroy(gameObject);
        collectButton.gameObject.SetActive(false);

    }

}