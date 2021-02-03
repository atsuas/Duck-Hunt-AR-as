using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Transform targetFocus;

    // Start is called before the first frame update
    void Start()
    {
        targetFocus = GameObject.FindGameObjectWithTag("target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = targetFocus.position - this.transform.position;
        Debug.Log(target.magnitude);

        transform.LookAt(targetFocus.transform);
        float speed = Random.Range(15f, 30f);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
