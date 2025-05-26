using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        if(player.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
