using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    public Action OnCubeArriveAtDestination;

    public void CubeArrived()
    {
        OnCubeArriveAtDestination?.Invoke();
    }
}
