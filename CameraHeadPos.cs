using UnityEngine;
using System.Collections;

public class CameraHeadPos : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 90.0f;
    private Transform myTransform;
    private Transform newTransform;
    public Vector3 offset;
    void Start()
    {
        //offset = new Vector3(5f, -2f, 5f);
        //transform.position = head.position + offset;
        target.Translate(offset.x, offset.y, offset.z);
        transform.position = target.position;
        transform.rotation = target.rotation;

        //transform.position = target.position + offset;
        //newTransform = target;
        //target.Translate(offset.x, offset.y, offset.z);
        //transform.position = target.position ;
        //transform.rotation = target.rotation;
        //myTransform = transform;
    }
    void Update()
    {
        transform.position = target.position;
        //transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        //newTransform = target;
        //newTransform.Translate(offset.x, offset.y, offset.z);
        //myTransform.position = target.position;
        //myTransform.position = Vector3.MoveTowards(myTransform.position, target.position, moveSpeed * Time.deltaTime);
        //myTransform.rotation = Quaternion.RotateTowards(myTransform.rotation, target.rotation, rotateSpeed * Time.deltaTime);
    }

}