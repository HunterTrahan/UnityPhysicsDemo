using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastBehavior : MonoBehaviour
{
    public GameObject door;
    public Vector3 raycastOffset;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position + raycastOffset, transform.forward);

        //Fire when the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(transform.position + raycastOffset, transform.forward, out hit))
            {
                if(hit.transform.gameObject == door)
                {
                    door.SetActive(false);
                }
            }
        }
    }
}