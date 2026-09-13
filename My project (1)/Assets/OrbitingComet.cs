using UnityEngine;

public class CometOrbit : MonoBehaviour
{
    public double gravity = 0.2;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        Vector3 position = transform.position;
        double distance = System.Math.Sqrt(
            System.Math.Pow(position.x, 2) +
            System.Math.Pow(position.y, 2) +
            System.Math.Pow(position.z, 2)
        );

        float speed = (float)System.Math.Sqrt(gravity / distance);
        velocity = new Vector3(0, 0, speed);
    }

    void Update()
    {
        Vector3 position = transform.position;
        double distance = System.Math.Sqrt(
            System.Math.Pow(position.x, 2) +
            System.Math.Pow(position.y, 2) +
            System.Math.Pow(position.z, 2)
        );

        double ax = -gravity * position.x / System.Math.Pow(distance, 3);
        double ay = -gravity * position.y / System.Math.Pow(distance, 3);
        double az = -gravity * position.z / System.Math.Pow(distance, 3);

        velocity.x += (float)(ax * Time.deltaTime);
        velocity.y += (float)(ay * Time.deltaTime);
        velocity.z += (float)(az * Time.deltaTime);

        transform.position += velocity * Time.deltaTime;
    }
}