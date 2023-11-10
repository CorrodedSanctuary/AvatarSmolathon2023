using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTriger : MonoBehaviour
{
    
    public UnityEngine.Events.UnityEvent OnTriggerEnterEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent?.Invoke();
    }
    
}
