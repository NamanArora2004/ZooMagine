using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    [SerializeField] private float s;
    private FixedJoystick fj;
    private Rigidbody a;
    private void OnEnable()
    {
        fj = FindObjectOfType<FixedJoystick>();
        a = gameObject.GetComponent<Rigidbody>();

    }
    private void FixedUpdate()
    {
        float x1 = fj.Horizontal;
        float y1 = fj.Vertical;
        Vector3 movement = new Vector3(x1, 0, y1);
        a.velocity = movement * s;
        if (x1 != 0 && y1 != 0)
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x1, y1) * Mathf.Rad2Deg, transform.eulerAngles.z);
    }
}