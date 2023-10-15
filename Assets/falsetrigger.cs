using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falsetrigger : MonoBehaviour
{
    [SerializeField] private GameObject trig;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<CapsuleCollider2D>().tag == "Player"){
           trig.GetComponent<trigger>().IsInRange = false;
        }
    }
}
