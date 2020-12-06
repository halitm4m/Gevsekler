using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FareDONUSU : MonoBehaviour
{
    [Range(50, 500)]
    public float sens;

    public Transform body;

    float xrot = 0f;

    private void Update()
    {
        float rotx = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float roty = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;
        xrot -= roty;
        xrot = Mathf.Clamp(xrot, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);

        body.Rotate(Vector3.up * rotx);
    }

}
