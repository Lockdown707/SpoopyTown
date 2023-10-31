using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float turnMin = 90;
    public float turnMax = 179;
    public float turnSpeed;

    public float speed = 4.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        float degrees = Random.Range(turnMin, turnMax);
        Debug.Log($"I hit a {collision.gameObject.name} ");
        transform.Rotate(Vector3.up, degrees);
            
    }
}
