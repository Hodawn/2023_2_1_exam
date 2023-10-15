#pragma warning disable IDE0051
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCtrl : MonoBehaviour
{
   
    
    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        Debug.Log($"Move = ({dir.x},{dir.y})");
    }
    void OnAttack()
    {
        Debug.Log("Attack");
    }
    void OnJump()
    {
        Debug.Log("Jump");
    }
}