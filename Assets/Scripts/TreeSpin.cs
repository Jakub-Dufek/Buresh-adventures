using UnityEngine;

public class TreeSpin : MonoBehaviour
{
    [SerializeField] int rotate_speed = 1;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, rotate_speed, Space.World);
    }
}
