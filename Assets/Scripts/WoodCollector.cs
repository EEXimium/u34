using UnityEngine;

public class WoodCollector : MonoBehaviour
{
    public GameObject woodPrefab;
    public Transform woodSpawnPoint;
    public float collectDistance = 2.0f;
    public Material highlightMaterial;
    public Material originalMaterial;

    private bool canCollectWood = false;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canCollectWood = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canCollectWood = false;
        }
    }

    private void Update()
    {
        if (canCollectWood)
        {
            // Detect mouse hover
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Change the material to the highlight material
                GetComponent<MeshRenderer>().material = highlightMaterial;

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    CollectWood();
                }
            }
            else
            {
                // Change the material back to the original material
                GetComponent<MeshRenderer>().material = originalMaterial;
            }
        }


       


    }

    private void CollectWood()
    {
        // Instantiate a new wood object at the tree location
        Instantiate(woodPrefab, woodSpawnPoint.position, Quaternion.identity);

        // TODO: Add the wood to the player's inventory

        // Destroy the tree object to indicate that it has been collected
        Destroy(gameObject);
    }
}
