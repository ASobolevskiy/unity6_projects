using UnityEngine;

public static class MoveInput
{
    public static Vector3 GetDirection()
    {
        var direction = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
            direction.z = 1;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
            direction.z = 1;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
            direction.z = -1;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
            direction.z = -1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            direction = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = (Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = (Vector3.right);
        }

        return direction;
    }
}
