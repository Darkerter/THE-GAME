using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranRocaDePiedra : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dummy Dummy = collision.gameObject.GetComponent<dummy>();
        if (Dummy != null)
        {
            Destroy(collision.gameObject);
        }
    }
}
