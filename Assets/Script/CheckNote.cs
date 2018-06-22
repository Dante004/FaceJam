using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNote : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Note" && Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Good");
            Destroy(coll.transform.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        Debug.Log("Miss");
        Destroy(coll.transform.gameObject);
    }
}