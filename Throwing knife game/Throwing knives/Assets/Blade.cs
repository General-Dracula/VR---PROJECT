using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class Blade : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "target")
        {
            transform.parent.GetComponent<Rigidbody>().isKinematic = true;
            transform.parent.transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "target")
        {
            transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    public void ResetRigid()
    {
        transform.parent.GetComponent<Rigidbody>().isKinematic = false;
    }
}
