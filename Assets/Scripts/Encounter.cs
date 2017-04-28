using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter : MonoBehaviour
{
    public GameObject Canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Canvas.SendMessage("I smell shit");
            print("Encounterd a square");
            GetComponentInParent<MeshRenderer>().materials[0].color = Random.ColorHSV();
        }
    }
}
