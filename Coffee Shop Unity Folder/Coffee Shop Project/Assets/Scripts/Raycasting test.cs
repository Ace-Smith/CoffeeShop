using UnityEngine;

public class Raycastingtestin : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] private float interactableRange = 6f;
    [SerializeField] private Camera playerCamera;

    void Update()
    {
        DetectIneractable();
    }

    private void DetectIneractable()
    {
        Ray ray = playerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        
        if (Physics.Raycast(ray, out RaycastHit hit, interactableRange, interactableLayer))
        {
            Debug.Log("Raycast Found Object in Interaction Layer");
        }
        else
        {
            Debug.Log("Raycast Didn't Find a Object in Intercation Layer");
        }
    }
}
