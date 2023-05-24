using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
   [SerializeField] private bool _TriggerOn;
    void Update()
    {
        if (_TriggerOn == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                trigger();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _TriggerOn = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _TriggerOn = false;

        }
    }
    void trigger()
    {

    }
}
