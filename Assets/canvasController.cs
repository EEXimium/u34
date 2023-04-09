using UnityEngine;

public class canvasController : MonoBehaviour
{

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void CloseCanvas()
    {
        Destroy(gameObject);
    }
}
