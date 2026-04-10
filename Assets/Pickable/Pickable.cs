using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Pickable : MonoBehaviour
{
    public Action<Pickable> OnPicked;
    public PickableType _pickableType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(OnPicked != null)
            {
                OnPicked(this);
            }
        }
    }
}