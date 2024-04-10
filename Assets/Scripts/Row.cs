using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;
    // Start is called before the first frame update
    void Start()
    {
        rowStopped = true;
        GameControl.HandlePulled += StartRotating;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void StartRotating()
    {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }
    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.025f;
        for (int i = 0; i < 30; i++) {
            if (transform.position.y <= -2.85f)
                transform.position = new Vector2(transform.position.x, 2.4f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.75f);

            yield return new WaitForSeconds(timeInterval);
        }
        randomValue = Random.Range(60, 100);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 2;
                break;
            case 2:
                randomValue += 1;
                break;
        }
        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= -2.85f)
                transform.position = new Vector2(transform.position.x, 2.4f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.75f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 0.75f))
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 0.95f))
                timeInterval = 0.2f;

            yield return new WaitForSeconds(timeInterval);
        }

        if (transform.position.y == -2.85f)
            stoppedSlot = "Diamond";
        else if (transform.position.y == -2.1f)
            stoppedSlot = "Crown";
        else if (transform.position.y == -1.35f)
            stoppedSlot = "Melon";
        else if (transform.position.y == -0.6f)
            stoppedSlot = "Bar";
        else if (transform.position.y == 0.15f)
            stoppedSlot = "Seven";
        else if (transform.position.y == 0.9f)
            stoppedSlot = "Cherry";
        else if (transform.position.y == 1.65f)
            stoppedSlot = "Lemon";
        else if (transform.position.y == 2.4f)
            stoppedSlot = "Diamond";

        rowStopped = true;
    }
    private void OnDestroy()
    {
        GameControl.HandlePulled -= StartRotating;
    }
}
