using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseControl : MonoBehaviour
{
    private float horseSpeed = 5f;
    private float restTime;
    private bool getToEndLine;

    public void RaceTrigger()
    {
        StartCoroutine(HorseMove());
    }
    private IEnumerator HorseMove()
    {
        while (!getToEndLine)
        {
            horseSpeed = Random.Range(10f, 200f);
            transform.position += Vector3.right * horseSpeed * Time.deltaTime;
            restTime = Random.Range(0.3f, 1f);
            yield return new WaitForSeconds(restTime);
        }
    }
}
