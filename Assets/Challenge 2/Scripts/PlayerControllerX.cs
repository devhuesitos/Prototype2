using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeBetweenShots = 0.3333f;
    private float timeStamp;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time >= timeStamp && (Input.GetKeyDown(KeyCode.Space)))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeStamp = Time.time + timeBetweenShots;
        }
    }
}
