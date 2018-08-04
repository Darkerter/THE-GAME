using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchosRobot : MonoBehaviour {
    
   

    public float[] EstadosDelRobot = {0f,-1f, 1f};
    public float TiempoDeCambioDeEstado = 0f;
    public float TiempoDeEstadoNulo = 0f;
    
    public bool RobotDerecha;

    
     void FixedUpdate()
    {
        ComportaminetoDePichosRobot();
    }
    void ComportaminetoDePichosRobot()
    {
        TiempoDeCambioDeEstado += Time.deltaTime;
        if (TiempoDeCambioDeEstado >= 3f)
        {
            TiempoDeEstadoNulo += Time.deltaTime;
            transform.Translate(new Vector2(EstadosDelRobot[0], 0), Space.World);
            if (TiempoDeEstadoNulo >= 0.15f)
            {
                RobotDerecha = !RobotDerecha;

                TiempoDeEstadoNulo = 0;

                TiempoDeCambioDeEstado = 0;
                

            }
        }
        else
        {
            
            if (RobotDerecha == true)
            {
               
                transform.Translate(new Vector2(EstadosDelRobot[2] , 0) * Time.fixedDeltaTime, Space.World);
                
            }
            else
            {
                transform.Translate(new Vector2(EstadosDelRobot[1], 0) * Time.fixedDeltaTime, Space.World);
                
            }
        }
    }
}
