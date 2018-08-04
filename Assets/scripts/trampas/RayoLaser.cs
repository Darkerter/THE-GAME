using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoLaser : MonoBehaviour {

    public BoxCollider2D rayo;

    public float TiempoRayo = 0;
    public float TiempoRayoActivo = 0;
    private void Update()
    {
        
        FuncionDelRayo();
    }
    void FuncionDelRayo()
    {
        TiempoRayo += Time.deltaTime;
        if (TiempoRayo >= 5f)
        {
            TiempoRayoActivo += Time.deltaTime;
            rayo.enabled = true;
            if (TiempoRayoActivo >= 1.5f)
            {
               
                TiempoRayo = 0;
                TiempoRayoActivo = 0;
            }
        }
        else
        {
            rayo.enabled = false;
        }
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dummy Dummy = collision.gameObject.GetComponent<dummy>();
        if (Dummy != null)
        {
            Destroy(collision.gameObject);
        }
    }
}
