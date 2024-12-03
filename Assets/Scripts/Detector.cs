using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField] private MoveToPoints MoveToPoints;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveToPoints.startMoving = true;
        }
    }
}
