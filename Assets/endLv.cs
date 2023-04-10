using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class endLv : MonoBehaviour
{

    private PlaceItem placeItem;
    private ItemCollection itemCollection;

    bool placeCheck;
    bool itemcheck;

    public GameObject placedItem;
    public GameObject obj1;
    public GameObject canvasBruh;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        canvasBruh.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        placeCheck = placedItem.GetComponent<PlaceItem>().checkForNextLvL;
        itemcheck = obj1.GetComponent<ItemCollection>().gameObject;
        GetReadyForTheNextLevel();
    }

    public void GetReadyForTheNextLevel()
    {
        if(placeCheck == true || itemcheck == true)
        {
            canvasBruh.SetActive(true);
        }
    }
}
