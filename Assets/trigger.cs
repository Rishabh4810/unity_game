using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    public bool IsInRange = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<CapsuleCollider2D>().tag == "Player"){
            
            IsInRange = true;
            Debug.Log("ok");
            
        }
    }

    private void Update() {
        if(IsInRange){
            if(Input.GetKeyDown(KeyCode.C)){
                SceneManager.LoadScene("scene2");
            }
        }
    }

}
