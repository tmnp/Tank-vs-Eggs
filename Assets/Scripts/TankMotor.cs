using UnityEngine;

public class TankMotor : BaseClass
{
    public Transform tankTransform;
    public Rigidbody tangRigidbody;

    private float speed = 10;

    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move(1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(-1);
        }
    }

    public void Move(int direction)
    {
        //tankTransform.Translate(Vector3.forward * direction * Speed * Time.deltaTime);
        //tangRigidbody.position += Vector3.forward * direction * Speed * Time.deltaTime;
        tangRigidbody.MovePosition(tangRigidbody.position + Vector3.forward * direction * Speed * Time.deltaTime);
    }

}