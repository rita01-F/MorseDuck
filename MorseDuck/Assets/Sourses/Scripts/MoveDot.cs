using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDot : MonoBehaviour
{
    public GameObject dotPrefab;
    private Transform dot_Transform;
    private float dot_size;
    private float dot_pos;
    private float temps;
    // Start is called before the first frame update
    void Start()
    {
        dot_Transform = GetComponent<Transform>();
        temps = Time.time;
        dot_pos = -2.293f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if ((Time.time - temps) > 2.6) {
            Destroy(dotPrefab);
        }
    }
    public void Move()
    {
        dot_pos -= Time.deltaTime;
        dot_Transform.position = new Vector3(-0.118f, dot_pos, 0);
    }
}
