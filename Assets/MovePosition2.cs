using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositon2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public float distance = 2.0f;
    private Vector3 direction = Vector3.left;
    private Vector3 startPositon;
    void Start()
    {
        startPositon = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        float currentDistance = Vector3.Distance(startPositon, transform.position);
        if (currentDistance >= distance)
        {
            direction = -direction;
        }
    }
}
