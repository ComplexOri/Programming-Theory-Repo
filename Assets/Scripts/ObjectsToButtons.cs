using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectsToButtons : MonoBehaviour
{

    public UnityEvent unityEvent = new UnityEvent();

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                unityEvent.Invoke();
            }
        }
    }
}
