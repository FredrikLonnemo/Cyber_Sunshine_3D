using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    private Camera _camCam;
    private Vector2 _mouseLook;

    public GameObject _PlayerCam;

    public int _fieldOfView;

    public ValuesObject gameValues;

    // Start is called before the first frame update
    void Start()
    {
        _camCam = _PlayerCam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameValues.paused)
        {
            Vector2 _mouseRot = (new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"))) * gameValues.lookSensitivity;

            _mouseLook += _mouseRot;

            //_mouseLook.y = Mathf.Clamp(_mouseLook.y, _minY, _maxY);

            _PlayerCam.transform.localRotation = Quaternion.AngleAxis(-_mouseLook.y, Vector3.right);
            transform.localRotation = Quaternion.AngleAxis(_mouseLook.x, transform.up);
        }
    }
}
