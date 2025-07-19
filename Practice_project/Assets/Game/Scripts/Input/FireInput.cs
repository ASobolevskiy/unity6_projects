
using UnityEngine;

public static class FireInput
{
    public static bool IsFirePressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
