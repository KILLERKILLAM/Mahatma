using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{

    public float xVal = 0.0f;
    private bool forward = true;
    public float dist_towardsX1 = 5.0f;
    public float dist_towardsX2 = -5.0f;
    public GameObject coin;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (forward)
        {
            xVal += 0.1f;
        }
        else
        {
            xVal -= 0.1f;
        }

        if (xVal >= dist_towardsX1 || xVal <= dist_towardsX2)
        {
            forward = !forward;
        }

        this.gameObject.transform.position = new Vector3(xVal, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 RandomPos = new Vector3(Random.Range(-4, 4), Random.Range(2, 4), Random.Range(-4, 4));
            Instantiate(coin, RandomPos, Quaternion.identity);
        }
    }
}
