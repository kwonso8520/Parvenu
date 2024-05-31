using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RouletteBall : MonoBehaviour
{
    public float rotatePower;
    public float stopPower;

    private Rigidbody2D rouletteRigidBody;
    private int inRotate;

    void Start()
    {
        rouletteRigidBody = GetComponent<Rigidbody2D>();
    }
    float t;
    // Update is called once per frame
    void Update()
    {
        if (rouletteRigidBody.angularVelocity < 0)
        {
            rouletteRigidBody.angularVelocity += stopPower * Time.deltaTime;

            rouletteRigidBody.angularVelocity = Mathf.Clamp(rouletteRigidBody.angularVelocity, -1440, 0);
        }

        if (rouletteRigidBody.angularVelocity == 0 && inRotate == 1)
        {
            t += 1 * Time.deltaTime;
            if (t > 0.5f)
            {
                inRotate = 0;
                t = 0;
            }
        }
    }

    public void Rotate()
    {
        if (inRotate == 0)
        {
            rouletteRigidBody.AddTorque(-rotatePower);
            inRotate = 1;
        }
    }
}
