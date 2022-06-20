using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Joystick joystick;
    private GameObject earthPoint;

    [SerializeField] float _rotationSpeed = 30.0f;

    private void Start()
    {
        earthPoint = GameObject.Find("EarthPoint");
    }

    void FixedUpdate()
    {
        RotateCamera();
    }


    void RotateCamera()
    {
        earthPoint.transform.Rotate(RotationVector() * _rotationSpeed * Time.fixedDeltaTime);
    }

    private Vector3 RotationVector()
    {
        float horizontalRotation = joystick.Horizontal;
        float vericalRotation = joystick.Vertical;

        return new Vector3(vericalRotation, horizontalRotation, .0f);
    }
}
