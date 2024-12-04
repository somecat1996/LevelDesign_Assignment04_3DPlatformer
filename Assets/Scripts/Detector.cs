using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField] private List<MoveToPoints> MoveToPoints;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (var item in MoveToPoints) {
                item.startMoving = true; 
            }
        }
    }
}
