#pragma warning disable IDE0051
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCtrl : MonoBehaviour
{

    private Vector3 moveDirection;
    private float moveSpeed = 4f;

    private void Update()
    {
        bool hascontrol = (moveDirection != Vector3.zero);
        if (hascontrol)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        if(input != null)
        {
            moveDirection = new Vector3(input.x, 0f, input.y);
            
        }
    }
    
   