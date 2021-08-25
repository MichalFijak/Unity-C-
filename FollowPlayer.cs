using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform pl;
    public Vector3 offset;
    void Update()
    {
        transform.position = pl.position+offset;
       
    }
}
