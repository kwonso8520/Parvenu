using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotatePower;
    public float stopPower;

    private Rigidbody2D rouletteRigidBody;
    private int inRotate;
    // Start is called before the first frame update
    void Start()
    {
        rouletteRigidBody = GetComponent<Rigidbody2D>();
    }
    float t;
    // Update is called once per frame
    void Update()
    {
        if(rouletteRigidBody.angularVelocity > 0)
        {
            rouletteRigidBody.angularVelocity -= stopPower*Time.deltaTime;

            rouletteRigidBody.angularVelocity = Mathf.Clamp(rouletteRigidBody.angularVelocity, 0, 1440);
        }

        if(rouletteRigidBody.angularVelocity == 0 && inRotate == 1)
        {
            t += 1 * Time.deltaTime;
            if(t > 0.5f)
            {
                GetReward();

                inRotate = 0;
                t = 0;
            }
        }
    }

    public void Rotate()
    {
        if(inRotate == 0)
        {
            rouletteRigidBody.AddTorque(rotatePower);
            inRotate = 1;
        }
    }
    public void GetReward()
    {
        float rotate = transform.eulerAngles.z;

        if(rotate > 23 && rotate <= 68f)
        {
            
        }
    }
}
