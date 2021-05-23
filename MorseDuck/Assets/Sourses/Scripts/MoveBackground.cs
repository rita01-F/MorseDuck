using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    private Transform back_Transform;
    private float back_size;
    private float back_pos;
    // Start is called before the first frame update
    void Start()
    {
        back_Transform = GetComponent<Transform>();
        back_size = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move() {
        back_pos += Time.deltaTime;
        back_pos = Mathf.Repeat(back_pos, back_size);
        back_Transform.position = new Vector3(0, back_pos, 0);
    }
}
