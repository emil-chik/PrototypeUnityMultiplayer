using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<OwnershipTransferGameObject>().RequestOwnerShit();
        }
        Debug.Log("THIS IS ENTER " + collision.gameObject.name);
    }
}
