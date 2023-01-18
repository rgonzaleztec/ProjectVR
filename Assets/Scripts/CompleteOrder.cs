using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteOrder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cake")
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.transform.parent = this.transform.parent;
            other.gameObject.transform.localPosition = new Vector3(0f, 1.9f, 0f);
        }
    }
}
