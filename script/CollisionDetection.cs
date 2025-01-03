using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Acquisition")
        {
            GameManager.instance.AddScore();
            //Debug.Log("衝突を検知");
            Destroy(other.gameObject);
        }
    }
}
