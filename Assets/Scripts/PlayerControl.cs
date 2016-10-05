using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

    public float speed;

    // Use this for initialization
    void Start()
    {
        GetComponent<Collider>().attachedRigidbody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * this.speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.gravity = -Physics.gravity;
        }
    }
}