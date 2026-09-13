using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public InputActionReference action;
    public float shootSpeed = 5f;

    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            GameObject spawned = Instantiate(prefabToSpawn, transform.position, transform.rotation);
            ProjectileMotion motion = spawned.GetComponent<ProjectileMotion>();
            if (motion != null)
            {
                motion.velocity = transform.forward * shootSpeed;
            }
        };
    }
}