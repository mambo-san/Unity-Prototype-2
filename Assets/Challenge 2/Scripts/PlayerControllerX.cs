using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float minInterval = 0.5f;
    public float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && elapsedTime > minInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            elapsedTime = 0;
        }
    }
}
